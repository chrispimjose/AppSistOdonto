namespace AppSistOdonto
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox1 = new PictureBox();
            recebeCxa = new MaterialSkin.Controls.MaterialButton();
            devolveCxa = new MaterialSkin.Controls.MaterialButton();
            cadastraUsuario = new MaterialSkin.Controls.MaterialButton();
            gerenciar = new MaterialSkin.Controls.MaterialButton();
            relatorios = new MaterialSkin.Controls.MaterialButton();
            sairSistema = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // recebeCxa
            // 
            recebeCxa.AutoSize = false;
            recebeCxa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            recebeCxa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            recebeCxa.Depth = 0;
            recebeCxa.HighEmphasis = true;
            recebeCxa.Icon = null;
            recebeCxa.Location = new Point(569, 139);
            recebeCxa.Margin = new Padding(4, 6, 4, 6);
            recebeCxa.MouseState = MaterialSkin.MouseState.HOVER;
            recebeCxa.Name = "recebeCxa";
            recebeCxa.NoAccentTextColor = Color.Empty;
            recebeCxa.Size = new Size(206, 36);
            recebeCxa.TabIndex = 2;
            recebeCxa.Text = "Receber Caixa  ";
            recebeCxa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            recebeCxa.UseAccentColor = false;
            recebeCxa.UseVisualStyleBackColor = true;
            recebeCxa.Click += recebeCxa_Click;
            // 
            // devolveCxa
            // 
            devolveCxa.AutoSize = false;
            devolveCxa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            devolveCxa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            devolveCxa.Depth = 0;
            devolveCxa.HighEmphasis = true;
            devolveCxa.Icon = null;
            devolveCxa.Location = new Point(569, 187);
            devolveCxa.Margin = new Padding(4, 6, 4, 6);
            devolveCxa.MouseState = MaterialSkin.MouseState.HOVER;
            devolveCxa.Name = "devolveCxa";
            devolveCxa.NoAccentTextColor = Color.Empty;
            devolveCxa.Size = new Size(206, 36);
            devolveCxa.TabIndex = 3;
            devolveCxa.Text = "Devolver Caixa";
            devolveCxa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            devolveCxa.UseAccentColor = false;
            devolveCxa.UseVisualStyleBackColor = true;
            devolveCxa.Click += devolveCxa_Click;
            // 
            // cadastraUsuario
            // 
            cadastraUsuario.AutoSize = false;
            cadastraUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cadastraUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cadastraUsuario.Depth = 0;
            cadastraUsuario.HighEmphasis = true;
            cadastraUsuario.Icon = null;
            cadastraUsuario.Location = new Point(569, 255);
            cadastraUsuario.Margin = new Padding(4, 6, 4, 6);
            cadastraUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            cadastraUsuario.Name = "cadastraUsuario";
            cadastraUsuario.NoAccentTextColor = Color.Empty;
            cadastraUsuario.Size = new Size(206, 36);
            cadastraUsuario.TabIndex = 4;
            cadastraUsuario.Text = "Cadastrar Usuário";
            cadastraUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cadastraUsuario.UseAccentColor = false;
            cadastraUsuario.UseVisualStyleBackColor = true;
            cadastraUsuario.Click += cadastraAluno_Click;
            // 
            // gerenciar
            // 
            gerenciar.AutoSize = false;
            gerenciar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gerenciar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            gerenciar.Depth = 0;
            gerenciar.HighEmphasis = true;
            gerenciar.Icon = null;
            gerenciar.Location = new Point(569, 91);
            gerenciar.Margin = new Padding(4, 6, 4, 6);
            gerenciar.MouseState = MaterialSkin.MouseState.HOVER;
            gerenciar.Name = "gerenciar";
            gerenciar.NoAccentTextColor = Color.Empty;
            gerenciar.Size = new Size(206, 36);
            gerenciar.TabIndex = 1;
            gerenciar.Text = "Gerenciar Caixas";
            gerenciar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            gerenciar.UseAccentColor = false;
            gerenciar.UseVisualStyleBackColor = true;
            gerenciar.Click += gerenciar_Click;
            // 
            // relatorios
            // 
            relatorios.AutoSize = false;
            relatorios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            relatorios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            relatorios.Depth = 0;
            relatorios.HighEmphasis = true;
            relatorios.Icon = null;
            relatorios.Location = new Point(569, 303);
            relatorios.Margin = new Padding(4, 6, 4, 6);
            relatorios.MouseState = MaterialSkin.MouseState.HOVER;
            relatorios.Name = "relatorios";
            relatorios.NoAccentTextColor = Color.Empty;
            relatorios.Size = new Size(206, 36);
            relatorios.TabIndex = 5;
            relatorios.Text = "Relatórios";
            relatorios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            relatorios.UseAccentColor = false;
            relatorios.UseVisualStyleBackColor = true;
            relatorios.Click += relatorios_Click;
            // 
            // sairSistema
            // 
            sairSistema.AutoSize = false;
            sairSistema.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sairSistema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            sairSistema.Depth = 0;
            sairSistema.HighEmphasis = true;
            sairSistema.Icon = null;
            sairSistema.Location = new Point(569, 378);
            sairSistema.Margin = new Padding(4, 6, 4, 6);
            sairSistema.MouseState = MaterialSkin.MouseState.HOVER;
            sairSistema.Name = "sairSistema";
            sairSistema.NoAccentTextColor = Color.Empty;
            sairSistema.Size = new Size(206, 36);
            sairSistema.TabIndex = 6;
            sairSistema.Text = "Sair do Sistema";
            sairSistema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            sairSistema.UseAccentColor = false;
            sairSistema.UseVisualStyleBackColor = true;
            sairSistema.Click += sairSistema_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 446);
            Controls.Add(sairSistema);
            Controls.Add(relatorios);
            Controls.Add(gerenciar);
            Controls.Add(cadastraUsuario);
            Controls.Add(devolveCxa);
            Controls.Add(recebeCxa);
            Controls.Add(pictureBox1);
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton recebeCxa;
        private MaterialSkin.Controls.MaterialButton devolveCxa;
        private MaterialSkin.Controls.MaterialButton cadastraUsuario;
        private MaterialSkin.Controls.MaterialButton gerenciar;
        private MaterialSkin.Controls.MaterialButton relatorios;
        private MaterialSkin.Controls.MaterialButton sairSistema;
    }
}
