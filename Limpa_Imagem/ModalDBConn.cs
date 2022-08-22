using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limpa_Imagem
{
    public partial class ModalDBConn : MaterialForm
    {
        public ModalDBConn()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.EnforceBackcolorOnAllComponents = true;

            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.DeepOrange700, Primary.BlueGrey500, Accent.Orange200, TextShade.WHITE);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            ConnDB meuDB = new ConnDB();

            if (ConnDB.Connected() == false)
            {
                meuDB.Conectar(txtHost.Text,
                    txtPorta.Text,
                    txtDatabase.Text,
                    txtUsuario.Text,
                    txtSenha.Text);

                this.Close();
            }
        }

        
    }
}
