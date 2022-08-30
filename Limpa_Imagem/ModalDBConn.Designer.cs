namespace Limpa_Imagem
{
    partial class ModalDBConn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnConectar = new MaterialSkin.Controls.MaterialButton();
            this.txtSenha = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPorta = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtDatabase = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtHost = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblIntro = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnCancelar);
            this.materialCard1.Controls.Add(this.btnConectar);
            this.materialCard1.Controls.Add(this.txtSenha);
            this.materialCard1.Controls.Add(this.txtUsuario);
            this.materialCard1.Controls.Add(this.txtPorta);
            this.materialCard1.Controls.Add(this.txtDatabase);
            this.materialCard1.Controls.Add(this.txtHost);
            this.materialCard1.Controls.Add(this.lblIntro);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(574, 260);
            this.materialCard1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(447, 207);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConectar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConectar.Depth = 0;
            this.btnConectar.HighEmphasis = true;
            this.btnConectar.Icon = null;
            this.btnConectar.Location = new System.Drawing.Point(307, 206);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConectar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConectar.Size = new System.Drawing.Size(98, 36);
            this.btnConectar.TabIndex = 6;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConectar.UseAccentColor = false;
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AnimateReadOnly = false;
            this.txtSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSenha.Depth = 0;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSenha.HideSelection = true;
            this.txtSenha.Hint = "Password";
            this.txtSenha.LeadingIcon = null;
            this.txtSenha.Location = new System.Drawing.Point(307, 125);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtSenha.PrefixSuffixText = "Senha:";
            this.txtSenha.ReadOnly = false;
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(250, 48);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.TabStop = false;
            this.txtSenha.Text = "#intellissis--40";
            this.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSenha.TrailingIcon = null;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AnimateReadOnly = false;
            this.txtUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.Hint = "User";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(307, 55);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtUsuario.PrefixSuffixText = "Usuário";
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(250, 48);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "postgres";
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtPorta
            // 
            this.txtPorta.AnimateReadOnly = false;
            this.txtPorta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPorta.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPorta.Depth = 0;
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorta.HideSelection = true;
            this.txtPorta.Hint = "Porta de entrada";
            this.txtPorta.LeadingIcon = null;
            this.txtPorta.Location = new System.Drawing.Point(17, 195);
            this.txtPorta.MaxLength = 32767;
            this.txtPorta.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.PasswordChar = '\0';
            this.txtPorta.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtPorta.PrefixSuffixText = "Porta:";
            this.txtPorta.ReadOnly = false;
            this.txtPorta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPorta.SelectedText = "";
            this.txtPorta.SelectionLength = 0;
            this.txtPorta.SelectionStart = 0;
            this.txtPorta.ShortcutsEnabled = true;
            this.txtPorta.Size = new System.Drawing.Size(217, 48);
            this.txtPorta.TabIndex = 3;
            this.txtPorta.TabStop = false;
            this.txtPorta.Text = "5433";
            this.txtPorta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPorta.TrailingIcon = null;
            this.txtPorta.UseSystemPasswordChar = false;
            // 
            // txtDatabase
            // 
            this.txtDatabase.AnimateReadOnly = false;
            this.txtDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDatabase.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDatabase.Depth = 0;
            this.txtDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDatabase.HideSelection = true;
            this.txtDatabase.Hint = "Dados";
            this.txtDatabase.LeadingIcon = null;
            this.txtDatabase.Location = new System.Drawing.Point(17, 126);
            this.txtDatabase.MaxLength = 32767;
            this.txtDatabase.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '\0';
            this.txtDatabase.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtDatabase.PrefixSuffixText = "Database:";
            this.txtDatabase.ReadOnly = false;
            this.txtDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDatabase.SelectedText = "";
            this.txtDatabase.SelectionLength = 0;
            this.txtDatabase.SelectionStart = 0;
            this.txtDatabase.ShortcutsEnabled = true;
            this.txtDatabase.Size = new System.Drawing.Size(217, 48);
            this.txtDatabase.TabIndex = 2;
            this.txtDatabase.TabStop = false;
            this.txtDatabase.Text = "feira_santana";
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDatabase.TrailingIcon = null;
            this.txtDatabase.UseSystemPasswordChar = false;
            // 
            // txtHost
            // 
            this.txtHost.AnimateReadOnly = true;
            this.txtHost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtHost.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtHost.Depth = 0;
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHost.HelperText = "teste";
            this.txtHost.HideSelection = true;
            this.txtHost.Hint = "Endereço de IP";
            this.txtHost.LeadingIcon = null;
            this.txtHost.Location = new System.Drawing.Point(17, 55);
            this.txtHost.MaxLength = 32767;
            this.txtHost.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHost.Name = "txtHost";
            this.txtHost.PasswordChar = '\0';
            this.txtHost.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtHost.PrefixSuffixText = "Host:";
            this.txtHost.ReadOnly = false;
            this.txtHost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHost.SelectedText = "";
            this.txtHost.SelectionLength = 0;
            this.txtHost.SelectionStart = 0;
            this.txtHost.ShortcutsEnabled = true;
            this.txtHost.Size = new System.Drawing.Size(217, 48);
            this.txtHost.TabIndex = 1;
            this.txtHost.TabStop = false;
            this.txtHost.Text = "192.168.0.6";
            this.txtHost.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtHost.TrailingIcon = null;
            this.txtHost.UseSystemPasswordChar = false;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Depth = 0;
            this.lblIntro.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblIntro.Location = new System.Drawing.Point(107, 14);
            this.lblIntro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(355, 19);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Informe os Dados da conexão do Banco de Dados";
            // 
            // ModalDBConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 355);
            this.Controls.Add(this.materialCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModalDBConn";
            this.Opacity = 0.95D;
            this.Text = "Conexão - Banco de Dados";
            this.TopMost = true;
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnConectar;
        private MaterialSkin.Controls.MaterialTextBox2 txtSenha;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsuario;
        private MaterialSkin.Controls.MaterialTextBox2 txtPorta;
        private MaterialSkin.Controls.MaterialTextBox2 txtDatabase;
        private MaterialSkin.Controls.MaterialTextBox2 txtHost;
        private MaterialSkin.Controls.MaterialLabel lblIntro;
    }
}