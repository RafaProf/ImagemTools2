using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.WindowsAPICodePack.Dialogs;

//using MaterialWinforms;

namespace Limpa_Imagem
{
    public partial class Form1 : MaterialForm
    {

        public static string nomeArquivo1, nomeArquivo2, bkpImg1, bkpImg2;
        public Bitmap img1, img2;
        public int contador1 = 0, contador2 = 0;
        public bool flag = true;
        bool bt1, bt2 = false;
        double result_porcento = 0;
        int falhas = 0;

        private List<string> auxPixels = new List<string>();

        private void materialButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Imagens";
            openFileDialog1.Filter = "Todas Imagens|*.jpg; *.bmp; *.png";
            materialProgressBar1.Value = 0;
            materialProgressBar1.Visible = false;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.ToString() != "")
            {
                nomeArquivo1 = openFileDialog1.FileName.ToString();
                pictureBox1.Image = new Bitmap(nomeArquivo1);
                bt1 = true;
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            openFileDialog2.FileName = "";
            openFileDialog2.Title = "Imagens";
            openFileDialog2.Filter = "Todas Imagens|*.jpg; *.bmp; *.png";

            openFileDialog2.ShowDialog();
            if (openFileDialog2.FileName.ToString() != "")
            {
                nomeArquivo2 = openFileDialog2.FileName.ToString();
                pictureBox2.Image = new Bitmap(nomeArquivo2);
                bt2 = true;

                if (bt1 == true && bt2 == true)
                {
                    materialButton3.Enabled = true;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ZeraFotos();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        //Botaão da Pasta Inicial
        private void materialButton4_Click(object sender, EventArgs e)
        {
  
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(dialog.FileName))
            {
                //Identificar diretório
                string[] files = Directory.GetFiles(dialog.FileName);
                Global.listaImagens.Clear();
                deletarBtnPasta.Enabled = false;
                BtnExecutePasta.Enabled = true;

                CaminhoLbPasta.Text = dialog.FileName;
                labelNumdeArquivos.Text = "Quantidade de Arquivos: " + files.Length.ToString();


                //Listar
                materialMultiLinePasta.Text = "";
                foreach (var item in files)
                {
                    materialMultiLinePasta.Text = materialMultiLinePasta.Text + "\n" + item.ToString();
                    Global.listaImagens.Add(item);
                }
            }

        }

        private async void BtnExecutePasta_Click(object sender, EventArgs e)
        {
            Global.resultGeralPasta.Clear();
            falhas = 0;
            escolherBtnPasta.Enabled = false;
            BtnExecutePasta.Enabled = false;
            deletarBtnPasta.Enabled = false;
            materialProgressBar2.Value = 0;
            result_porcento = 0;
            materialProgressBar2.Maximum = Global.listaImagens.Count - 1;
            BtnExecutePasta.Enabled = false;
            

            Task task = new Task(new Action(ExeFotosPasta));
            task.Start();
            EsperaLablPasta.Text = "Processando...";
            await task; //top
            EsperaLablPasta.Text = "Concluido - Etapa 1";
            

            //Segunda Etapa
            lblEtapaPasta.Text = "Etapa 2 de 2";
            Task task_limpar = new Task(new Action(LimparDaPasta));
            task_limpar.Start();
            EsperaLablPasta.Text = "Processando - Etapa 2...";
            await task_limpar; //top
            deletarBtnPasta.Enabled = true;


            EsperaLablPasta.Text = "Sucesso no processo";          
            escolherBtnPasta.Enabled = true;
            Global.listaTamanho.Clear();
            Global.listaPixels.Clear();
            
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            contador1 = 0;
            contador2 = 0;
            materialProgressBar1.Visible = true;
            btnLimpar.Enabled = true;
            string img1_ref, img2_ref;
            img1 = new Bitmap(nomeArquivo1);
            img2 = new Bitmap(nomeArquivo2);
            flag = true;

            materialProgressBar1.Maximum = img1.Width;

            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            contador2++;
                            flag = false;
                            break;
                        }
                        contador1++;
                    }
                    materialProgressBar1.Value++;
                }

                if (flag == false)
                {
                    DialogResult d;
                    d = MessageBox.Show("As imagens não são as mesmas, " + contador2 + " pixels diferentes foram encontrados", "Resposta", MessageBoxButtons.OK);
                    if (d == DialogResult.OK) { ZeraFotos(); }
                }
                else
                {
                    // contador2 = 0;
                    DialogResult d;
                    d = MessageBox.Show("As imagens são as mesmas, " + contador1 + " pixels iguais foram encontrados, e  " + contador2 + " pixels incorretos foram encontrados", "Resposta", MessageBoxButtons.OK);
                    if (d == DialogResult.OK) { ZeraFotos(); }

                }
            }
            else
            {
                MessageBox.Show("As imagens não podem ser comparadas");
            }
            bkpImg1 = nomeArquivo1;
            bkpImg2 = nomeArquivo2;
            contador1 = 0;
            contador2 = 0;
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.DeepOrange700, Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialProgressBar1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            materialButton3.Enabled = false;
            materialProgressBar1.ForeColor = Color.Aqua;
            materialProgressBar1.BackColor = Color.Wheat;
            //materialProgressBar2.ForeColor = Color.DarkOrange;
            materialProgressBar2.BackColor = Color.LightBlue;


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void deletarBtnPasta_Click(object sender, EventArgs e)
        {
            materialMultiLinePasta.Text = materialMultiLinePasta.Text + "\n\n";
            materialProgressBar2.Value = 0;
            materialProgressBar2.Maximum = Global.resultGeralPasta.Count;

            foreach (string item in Global.resultGeralPasta)
            {
                try
                {
                    File.Delete(item);

                    materialProgressBar2.Value++;
                    BtnExecutePasta.Enabled = true;
                    materialMultiLinePasta.Text = materialMultiLinePasta.Text + "\nDeletado: " + item ;
                }
                catch (Exception)
                {
                    materialMultiLinePasta.Text = materialMultiLinePasta.Text + "\nErro ao deletar: " + item;
                    throw;
                }
            }
            BtnExecutePasta.Enabled = false;
            deletarBtnPasta.Enabled = false;
        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
           // Task task = new Task(new Action(AbrirConexao));
           // task.Start();
           // await task;
            ModalDBConn db = new ModalDBConn();
            db.ShowDialog();
        }

        public void ZeraFotos()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            materialProgressBar1.Value = 0;
            materialButton3.Enabled = false;
        }

        private void btnExeDb_Click(object sender, EventArgs e)
        {
            ConnDB meuDB = new ConnDB();

            ConnDB.LerImagemColeta();
        }

        public void AbrirConexao()
        {
            ModalDBConn db = new ModalDBConn();
            db.ShowDialog();
        }


        //Execução da Pasta
        public void ExeFotosPasta()
        {
            int x = 0;
            materialProgressBar2.Value = 0;
            Global.listaImagens.Sort();
            for (int y = 0; y < Global.listaImagens.Count; y++)
            {
                
                try
                {
                    //materialProgressBar2.Visible = true;
                    Bitmap bitmap;

                    foreach (var item in Global.listaImagens)
                    {
                        //caminho do arquivo
                        string caminho = Global.listaImagens[x];

                        //verificar tamanho
                        FileInfo fileinfo = new FileInfo(caminho);
                        if (fileinfo.Exists)
                        {
                            try
                            {
                                bitmap = new Bitmap(caminho);
                                Global.listaTamanho.Add(fileinfo.Length.ToString());
                                bitmap.Dispose();
                            }
                            catch
                            {
                                // Esse aquivo não é uma imagem.
                                falhas++;
                                x++;
                                break;
                            }


                        }
                        string[] aux = new string[200];
                        string img1_ref;
                        img1 = new Bitmap(caminho);
                        int contAux = 0;
                        

                        for (int i = 0; i < img1.Width; i = i + 500)
                        {
                            for (int j = 0; j < img1.Height; j = j + 500)
                            {
                                img1_ref = img1.GetPixel(i, j).ToString();

                                aux[contAux] = img1_ref;
                                contAux++;

                                
                                //contador1++;
                                //materialProgressBar2.Value++;

                            }
                            
                        }

                        Global.listaPixels.Add(aux);
                        AvançarProg(x);
                        x++;
                        
                        img1.Dispose(); //importante
                        aux = null;
                    }
                }
                catch (Exception)
                {

                    y++;
                }
            }
        }

        delegate void AvançarProgCallback(int tt);
        public void AvançarProg(int tt) {

            if (InvokeRequired)
            {
                AvançarProgCallback callback = AvançarProg;
               
                Invoke(callback, tt);
            }
            else
            {
                if (tt != 0)
                {
                    double teste = float.Parse((Global.listaImagens.Count - 1).ToString());
                    double porcento = (100.0 / teste );
                    
                    result_porcento = result_porcento + porcento;
                    materialProgressBar2.Value = tt;
                    EsperaLablPasta.Text = "Processando... " + tt.ToString() + " Fotos ";
                    lblPorcentPasta.Text = result_porcento.ToString("F") + "%";
                    lblFalhaPasta.Text = "Não são fotos: " + falhas.ToString() + "Item(s)";
                }
                
            }

            }

        delegate void LimparDaPastaCallback();
        public void LimparDaPasta() {

            if (InvokeRequired)
            {
                LimparDaPastaCallback callback = LimparDaPasta;

                Invoke(callback);
            }
            else {

                materialMultiLinePasta.Text = "Processando seu resultado de duplicatas:";
                try
                {
                    for (int i = 0; i < Global.listaTamanho.Count; i++)
                    {
                        //Comparação da primeira com as outras
                        for (int y = 0; y < Global.listaTamanho.Count; y++)
                        {

                            //Recurso pra não pegar arquivos duplicados dos dois lados
                            while (y <= i )
                            {
                                if (i != Global.listaTamanho.Count-1)
                                {
                                    y++;
                                }
                                else
                                {
                                    break;
                                    
                                }
                            }

                            //Se caminhos diferentes
                            if (Global.listaImagens[i + falhas] != Global.listaImagens[y + falhas])
                            {
                                //Se tamanho igual
                                if (Global.listaTamanho[i] == Global.listaTamanho[y])
                                {
                                    //Se pixels iguais

                                    for (int b = 0; b < Global.listaPixels.Count/10; b++)
                                    {
                                        if (Global.listaPixels[i][b].Equals(Global.listaPixels[y][b]))
                                        {
                                            
                                            Global.resultGeralPasta.Add(Global.listaImagens[i + falhas]);

                                            //Tratar a falha do ultimo item
                                            if (i ==  Global.listaImagens.Count  + falhas - 1)
                                            {
                                                Global.resultGeralPasta.RemoveAt(Global.resultGeralPasta.Count - 1);

                                                //Exibir resultado
                                                materialMultiLinePasta.Text = "Resultado de duplicatas:";
                                                foreach (var item in Global.resultGeralPasta)
                                                {
                                                    materialMultiLinePasta.Text = materialMultiLinePasta.Text + "\n" + item.ToString();
                                                }

                                            }
                                            //materialMultiLinePasta.Text = materialMultiLinePasta.Text + "\n" + i.ToString() + " - " + Global.listaImagens[i];

                                        }
                                        else
                                        {

                                        }
                                    }          
                                }
                            }
                         
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }

            
        }
            
    }
}


