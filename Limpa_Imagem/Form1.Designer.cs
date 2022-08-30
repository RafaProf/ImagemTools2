namespace Limpa_Imagem
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEtapaPasta = new MaterialSkin.Controls.MaterialLabel();
            this.materialProgressBar2 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.deletarBtnPasta = new MaterialSkin.Controls.MaterialButton();
            this.lblFalhaPasta = new MaterialSkin.Controls.MaterialLabel();
            this.lblPorcentPasta = new MaterialWinforms.Controls.MaterialLabel();
            this.EsperaLablPasta = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialMultiLinePasta = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialCardPasta = new MaterialSkin.Controls.MaterialCard();
            this.BtnExecutePasta = new MaterialSkin.Controls.MaterialButton();
            this.labelNumdeArquivos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.CaminhoLbPasta = new MaterialSkin.Controls.MaterialLabel();
            this.escolherBtnPasta = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnExcluirDB = new MaterialSkin.Controls.MaterialButton();
            this.lblEtapaDB = new MaterialSkin.Controls.MaterialLabel();
            this.materialProgressBar3 = new MaterialSkin.Controls.MaterialProgressBar();
            this.btnExeDb = new MaterialSkin.Controls.MaterialButton();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.btnCargaDados = new MaterialSkin.Controls.MaterialButton();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.MultTxtDB = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCardPasta.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(944, 508);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.Click += new System.EventHandler(this.materialTabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Controls.Add(this.materialProgressBar1);
            this.tabPage1.Controls.Add(this.materialButton3);
            this.tabPage1.Controls.Add(this.materialButton2);
            this.tabPage1.Controls.Add(this.materialCard2);
            this.tabPage1.Controls.Add(this.materialButton1);
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "camera-fotografica.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Comparar - Dual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnLimpar.IconColor = System.Drawing.Color.OrangeRed;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.Location = new System.Drawing.Point(398, 182);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Rotation = 180D;
            this.btnLimpar.Size = new System.Drawing.Size(41, 77);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.ForeColor = System.Drawing.Color.Aqua;
            this.materialProgressBar1.Location = new System.Drawing.Point(10, 452);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(815, 5);
            this.materialProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.materialProgressBar1.TabIndex = 5;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(365, 9);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(101, 36);
            this.materialButton3.TabIndex = 4;
            this.materialButton3.Text = "Comparar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(557, 6);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(162, 36);
            this.materialButton2.TabIndex = 3;
            this.materialButton2.Text = "Selecionar Foto 2";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(439, 47);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(386, 377);
            this.materialCard2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(17, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 343);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(128, 6);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(162, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Selecionar Foto 1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(10, 47);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(386, 377);
            this.materialCard1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "localizacao";
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblEtapaPasta);
            this.tabPage2.Controls.Add(this.materialProgressBar2);
            this.tabPage2.Controls.Add(this.materialCard4);
            this.tabPage2.Controls.Add(this.materialCard3);
            this.tabPage2.Controls.Add(this.materialCardPasta);
            this.tabPage2.Controls.Add(this.CaminhoLbPasta);
            this.tabPage2.Controls.Add(this.escolherBtnPasta);
            this.tabPage2.Controls.Add(this.materialLabel1);
            this.tabPage2.ImageKey = "camada.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Pasta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblEtapaPasta
            // 
            this.lblEtapaPasta.AutoSize = true;
            this.lblEtapaPasta.Depth = 0;
            this.lblEtapaPasta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEtapaPasta.Location = new System.Drawing.Point(640, 17);
            this.lblEtapaPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEtapaPasta.Name = "lblEtapaPasta";
            this.lblEtapaPasta.Size = new System.Drawing.Size(89, 19);
            this.lblEtapaPasta.TabIndex = 7;
            this.lblEtapaPasta.Text = "Etapa 1 de 2";
            // 
            // materialProgressBar2
            // 
            this.materialProgressBar2.Depth = 0;
            this.materialProgressBar2.Location = new System.Drawing.Point(23, 460);
            this.materialProgressBar2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar2.Name = "materialProgressBar2";
            this.materialProgressBar2.Size = new System.Drawing.Size(850, 5);
            this.materialProgressBar2.TabIndex = 6;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.deletarBtnPasta);
            this.materialCard4.Controls.Add(this.lblFalhaPasta);
            this.materialCard4.Controls.Add(this.lblPorcentPasta);
            this.materialCard4.Controls.Add(this.EsperaLablPasta);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(23, 314);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(315, 125);
            this.materialCard4.TabIndex = 5;
            // 
            // deletarBtnPasta
            // 
            this.deletarBtnPasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deletarBtnPasta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deletarBtnPasta.Depth = 0;
            this.deletarBtnPasta.Enabled = false;
            this.deletarBtnPasta.HighEmphasis = true;
            this.deletarBtnPasta.Icon = null;
            this.deletarBtnPasta.Location = new System.Drawing.Point(19, 84);
            this.deletarBtnPasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deletarBtnPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.deletarBtnPasta.Name = "deletarBtnPasta";
            this.deletarBtnPasta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deletarBtnPasta.Size = new System.Drawing.Size(84, 36);
            this.deletarBtnPasta.TabIndex = 3;
            this.deletarBtnPasta.Text = "Deletar";
            this.deletarBtnPasta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deletarBtnPasta.UseAccentColor = false;
            this.deletarBtnPasta.UseVisualStyleBackColor = true;
            this.deletarBtnPasta.Click += new System.EventHandler(this.deletarBtnPasta_Click);
            // 
            // lblFalhaPasta
            // 
            this.lblFalhaPasta.AutoSize = true;
            this.lblFalhaPasta.Depth = 0;
            this.lblFalhaPasta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFalhaPasta.Location = new System.Drawing.Point(22, 59);
            this.lblFalhaPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFalhaPasta.Name = "lblFalhaPasta";
            this.lblFalhaPasta.Size = new System.Drawing.Size(105, 19);
            this.lblFalhaPasta.TabIndex = 2;
            this.lblFalhaPasta.Text = "Não são fotos:";
            // 
            // lblPorcentPasta
            // 
            this.lblPorcentPasta.AutoSize = true;
            this.lblPorcentPasta.Depth = 0;
            this.lblPorcentPasta.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPorcentPasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblPorcentPasta.Location = new System.Drawing.Point(19, 39);
            this.lblPorcentPasta.MouseState = MaterialWinforms.MouseState.HOVER;
            this.lblPorcentPasta.Name = "lblPorcentPasta";
            this.lblPorcentPasta.Size = new System.Drawing.Size(27, 18);
            this.lblPorcentPasta.TabIndex = 1;
            this.lblPorcentPasta.Text = "0%";
            // 
            // EsperaLablPasta
            // 
            this.EsperaLablPasta.AutoSize = true;
            this.EsperaLablPasta.Depth = 0;
            this.EsperaLablPasta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.EsperaLablPasta.Location = new System.Drawing.Point(22, 18);
            this.EsperaLablPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.EsperaLablPasta.Name = "EsperaLablPasta";
            this.EsperaLablPasta.Size = new System.Drawing.Size(79, 19);
            this.EsperaLablPasta.TabIndex = 0;
            this.EsperaLablPasta.Text = "Em espera.";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialMultiLinePasta);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(366, 86);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(487, 362);
            this.materialCard3.TabIndex = 4;
            // 
            // materialMultiLinePasta
            // 
            this.materialMultiLinePasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLinePasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialMultiLinePasta.Depth = 0;
            this.materialMultiLinePasta.EnableAutoDragDrop = true;
            this.materialMultiLinePasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLinePasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLinePasta.Location = new System.Drawing.Point(22, 18);
            this.materialMultiLinePasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLinePasta.Name = "materialMultiLinePasta";
            this.materialMultiLinePasta.ReadOnly = true;
            this.materialMultiLinePasta.Size = new System.Drawing.Size(442, 315);
            this.materialMultiLinePasta.TabIndex = 0;
            this.materialMultiLinePasta.Text = "Seus arquivos apareceram aqui.";
            // 
            // materialCardPasta
            // 
            this.materialCardPasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardPasta.Controls.Add(this.BtnExecutePasta);
            this.materialCardPasta.Controls.Add(this.labelNumdeArquivos);
            this.materialCardPasta.Controls.Add(this.materialLabel2);
            this.materialCardPasta.Depth = 0;
            this.materialCardPasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardPasta.Location = new System.Drawing.Point(23, 142);
            this.materialCardPasta.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardPasta.Name = "materialCardPasta";
            this.materialCardPasta.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardPasta.Size = new System.Drawing.Size(315, 154);
            this.materialCardPasta.TabIndex = 3;
            // 
            // BtnExecutePasta
            // 
            this.BtnExecutePasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnExecutePasta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnExecutePasta.Depth = 0;
            this.BtnExecutePasta.HighEmphasis = true;
            this.BtnExecutePasta.Icon = null;
            this.BtnExecutePasta.Location = new System.Drawing.Point(19, 98);
            this.BtnExecutePasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnExecutePasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnExecutePasta.Name = "BtnExecutePasta";
            this.BtnExecutePasta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnExecutePasta.Size = new System.Drawing.Size(95, 36);
            this.BtnExecutePasta.TabIndex = 2;
            this.BtnExecutePasta.Text = "Executar";
            this.BtnExecutePasta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnExecutePasta.UseAccentColor = false;
            this.BtnExecutePasta.UseVisualStyleBackColor = true;
            this.BtnExecutePasta.Click += new System.EventHandler(this.BtnExecutePasta_Click);
            // 
            // labelNumdeArquivos
            // 
            this.labelNumdeArquivos.AutoSize = true;
            this.labelNumdeArquivos.Depth = 0;
            this.labelNumdeArquivos.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelNumdeArquivos.Location = new System.Drawing.Point(19, 61);
            this.labelNumdeArquivos.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelNumdeArquivos.Name = "labelNumdeArquivos";
            this.labelNumdeArquivos.Size = new System.Drawing.Size(148, 19);
            this.labelNumdeArquivos.TabIndex = 1;
            this.labelNumdeArquivos.Text = "Número de Arquivos:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(18, 18);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Resumo:";
            // 
            // CaminhoLbPasta
            // 
            this.CaminhoLbPasta.AutoSize = true;
            this.CaminhoLbPasta.Depth = 0;
            this.CaminhoLbPasta.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CaminhoLbPasta.Location = new System.Drawing.Point(199, 61);
            this.CaminhoLbPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.CaminhoLbPasta.Name = "CaminhoLbPasta";
            this.CaminhoLbPasta.Size = new System.Drawing.Size(13, 19);
            this.CaminhoLbPasta.TabIndex = 2;
            this.CaminhoLbPasta.Text = "...";
            // 
            // escolherBtnPasta
            // 
            this.escolherBtnPasta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.escolherBtnPasta.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.escolherBtnPasta.Depth = 0;
            this.escolherBtnPasta.HighEmphasis = true;
            this.escolherBtnPasta.Icon = null;
            this.escolherBtnPasta.Location = new System.Drawing.Point(23, 86);
            this.escolherBtnPasta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.escolherBtnPasta.MouseState = MaterialSkin.MouseState.HOVER;
            this.escolherBtnPasta.Name = "escolherBtnPasta";
            this.escolherBtnPasta.NoAccentTextColor = System.Drawing.Color.Empty;
            this.escolherBtnPasta.Size = new System.Drawing.Size(95, 36);
            this.escolherBtnPasta.TabIndex = 1;
            this.escolherBtnPasta.Text = "Escolher";
            this.escolherBtnPasta.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.escolherBtnPasta.UseAccentColor = false;
            this.escolherBtnPasta.UseVisualStyleBackColor = true;
            this.escolherBtnPasta.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialLabel1.Location = new System.Drawing.Point(23, 61);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(174, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Escolha a pasta destino:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnExcluirDB);
            this.tabPage3.Controls.Add(this.lblEtapaDB);
            this.tabPage3.Controls.Add(this.materialProgressBar3);
            this.tabPage3.Controls.Add(this.btnExeDb);
            this.tabPage3.Controls.Add(this.materialCard6);
            this.tabPage3.Controls.Add(this.materialCard5);
            this.tabPage3.ImageKey = "tecnologia.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(936, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Por DB";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnExcluirDB
            // 
            this.btnExcluirDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluirDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExcluirDB.Depth = 0;
            this.btnExcluirDB.Enabled = false;
            this.btnExcluirDB.HighEmphasis = true;
            this.btnExcluirDB.Icon = null;
            this.btnExcluirDB.Location = new System.Drawing.Point(224, 314);
            this.btnExcluirDB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluirDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluirDB.Name = "btnExcluirDB";
            this.btnExcluirDB.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExcluirDB.Size = new System.Drawing.Size(73, 36);
            this.btnExcluirDB.TabIndex = 5;
            this.btnExcluirDB.Text = "teste..";
            this.btnExcluirDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExcluirDB.UseAccentColor = false;
            this.btnExcluirDB.UseVisualStyleBackColor = true;
            this.btnExcluirDB.Click += new System.EventHandler(this.btnExcluirDB_Click);
            // 
            // lblEtapaDB
            // 
            this.lblEtapaDB.AutoSize = true;
            this.lblEtapaDB.Depth = 0;
            this.lblEtapaDB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEtapaDB.Location = new System.Drawing.Point(34, 388);
            this.lblEtapaDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEtapaDB.Name = "lblEtapaDB";
            this.lblEtapaDB.Size = new System.Drawing.Size(63, 19);
            this.lblEtapaDB.TabIndex = 4;
            this.lblEtapaDB.Text = "Etapa 1: ";
            // 
            // materialProgressBar3
            // 
            this.materialProgressBar3.Depth = 0;
            this.materialProgressBar3.Location = new System.Drawing.Point(37, 439);
            this.materialProgressBar3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar3.Name = "materialProgressBar3";
            this.materialProgressBar3.Size = new System.Drawing.Size(820, 5);
            this.materialProgressBar3.TabIndex = 3;
            // 
            // btnExeDb
            // 
            this.btnExeDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExeDb.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExeDb.Depth = 0;
            this.btnExeDb.HighEmphasis = true;
            this.btnExeDb.Icon = null;
            this.btnExeDb.Location = new System.Drawing.Point(121, 314);
            this.btnExeDb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExeDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExeDb.Name = "btnExeDb";
            this.btnExeDb.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExeDb.Size = new System.Drawing.Size(95, 36);
            this.btnExeDb.TabIndex = 2;
            this.btnExeDb.Text = "Executar";
            this.btnExeDb.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExeDb.UseAccentColor = false;
            this.btnExeDb.UseVisualStyleBackColor = true;
            this.btnExeDb.Click += new System.EventHandler(this.btnExeDb_Click);
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.btnCargaDados);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(14, 100);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(392, 194);
            this.materialCard6.TabIndex = 1;
            // 
            // btnCargaDados
            // 
            this.btnCargaDados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCargaDados.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCargaDados.Depth = 0;
            this.btnCargaDados.HighEmphasis = true;
            this.btnCargaDados.Icon = null;
            this.btnCargaDados.Location = new System.Drawing.Point(18, 20);
            this.btnCargaDados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCargaDados.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCargaDados.Name = "btnCargaDados";
            this.btnCargaDados.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCargaDados.Size = new System.Drawing.Size(136, 36);
            this.btnCargaDados.TabIndex = 3;
            this.btnCargaDados.Text = "Deletar Carga";
            this.btnCargaDados.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCargaDados.UseAccentColor = false;
            this.btnCargaDados.UseVisualStyleBackColor = true;
            this.btnCargaDados.Click += new System.EventHandler(this.btnCargaDados_Click);
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.MultTxtDB);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(417, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(446, 393);
            this.materialCard5.TabIndex = 0;
            // 
            // MultTxtDB
            // 
            this.MultTxtDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MultTxtDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MultTxtDB.Depth = 0;
            this.MultTxtDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MultTxtDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultTxtDB.Hint = "Dados";
            this.MultTxtDB.Location = new System.Drawing.Point(18, 18);
            this.MultTxtDB.MouseState = MaterialSkin.MouseState.HOVER;
            this.MultTxtDB.Name = "MultTxtDB";
            this.MultTxtDB.ReadOnly = true;
            this.MultTxtDB.Size = new System.Drawing.Size(411, 358);
            this.MultTxtDB.TabIndex = 0;
            this.MultTxtDB.Text = "Lista de pastas que serão analisadas irá aparecer aqui.";
            // 
            // tabPage4
            // 
            this.tabPage4.ImageKey = "ajustar.png";
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(936, 465);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Por Diretorio";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "camera-dslr.png");
            this.imageList1.Images.SetKeyName(1, "camada.png");
            this.imageList1.Images.SetKeyName(2, "camera cel.png");
            this.imageList1.Images.SetKeyName(3, "camera-fotografica.png");
            this.imageList1.Images.SetKeyName(4, "ajustamento.png");
            this.imageList1.Images.SetKeyName(5, "ajustar (1).png");
            this.imageList1.Images.SetKeyName(6, "ajustar.png");
            this.imageList1.Images.SetKeyName(7, "project-management.png");
            this.imageList1.Images.SetKeyName(8, "tecnologia (1).png");
            this.imageList1.Images.SetKeyName(9, "tecnologia.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Title = "Escolher caminho-foto";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 575);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Limpa Imagem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.materialCardPasta.ResumeLayout(false);
            this.materialCardPasta.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private FontAwesome.Sharp.IconButton btnLimpar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton escolherBtnPasta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MaterialSkin.Controls.MaterialLabel CaminhoLbPasta;
        private MaterialSkin.Controls.MaterialCard materialCardPasta;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton BtnExecutePasta;
        private MaterialSkin.Controls.MaterialLabel labelNumdeArquivos;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLinePasta;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar2;
        private MaterialSkin.Controls.MaterialLabel EsperaLablPasta;
        private MaterialWinforms.Controls.MaterialLabel lblPorcentPasta;
        private MaterialSkin.Controls.MaterialLabel lblEtapaPasta;
        private MaterialSkin.Controls.MaterialLabel lblFalhaPasta;
        private MaterialSkin.Controls.MaterialButton deletarBtnPasta;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialButton btnExeDb;
        private MaterialSkin.Controls.MaterialMultiLineTextBox MultTxtDB;
        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar3;
        private MaterialSkin.Controls.MaterialLabel lblEtapaDB;
        private MaterialSkin.Controls.MaterialButton btnExcluirDB;
        private MaterialSkin.Controls.MaterialButton btnCargaDados;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}

