namespace AppSistOdonto.View
{
    partial class TelaMultifuncional
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
            materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPageGerenciar = new TabPage();
            ListViewSaida = new MaterialSkin.Controls.MaterialListView();
            ListViewEntrada = new MaterialSkin.Controls.MaterialListView();
            materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            tabPageReceber = new TabPage();
            atualCaixa = new MaterialSkin.Controls.MaterialButton();
            cadCaixa = new MaterialSkin.Controls.MaterialButton();
            validaFunc = new MaterialSkin.Controls.MaterialButton();
            validaAluno = new MaterialSkin.Controls.MaterialButton();
            comboFunc = new MaterialSkin.Controls.MaterialComboBox();
            comboAluno = new MaterialSkin.Controls.MaterialComboBox();
            entradaDetalhe = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            dateEntrada = new DateTimePicker();
            comboProcedimento = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            tabPageDevolver = new TabPage();
            materialMultiLineTextBox21 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            devolveCaixa = new MaterialSkin.Controls.MaterialButton();
            validaSaidaFunc = new MaterialSkin.Controls.MaterialButton();
            comboSaidaFunc = new MaterialSkin.Controls.MaterialComboBox();
            validaSaidaAluno = new MaterialSkin.Controls.MaterialButton();
            comboSaidaAluno = new MaterialSkin.Controls.MaterialComboBox();
            dateSaida = new DateTimePicker();
            textProcedimento = new MaterialSkin.Controls.MaterialTextBox2();
            comboCaixa = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            tabPageCadastrar = new TabPage();
            biometriaCad = new MaterialSkin.Controls.MaterialButton();
            biometriaCadastrada = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            saveUser = new MaterialSkin.Controls.MaterialButton();
            deleteUser = new MaterialSkin.Controls.MaterialButton();
            userEmail = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            comboTipoUser = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            userFone = new MaterialSkin.Controls.MaterialTextBox2();
            labelfone = new MaterialSkin.Controls.MaterialLabel();
            userCPF = new MaterialSkin.Controls.MaterialTextBox2();
            userNome = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            tabPageRelatorios = new TabPage();
            materialTabControl1.SuspendLayout();
            tabPageGerenciar.SuspendLayout();
            tabPageReceber.SuspendLayout();
            tabPageDevolver.SuspendLayout();
            tabPageCadastrar.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.BaseTabControl = materialTabControl1;
            materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Dock = DockStyle.Top;
            materialTabSelector1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTabSelector1.Location = new Point(0, 60);
            materialTabSelector1.Margin = new Padding(0);
            materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(933, 40);
            materialTabSelector1.TabIndex = 0;
            materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPageGerenciar);
            materialTabControl1.Controls.Add(tabPageReceber);
            materialTabControl1.Controls.Add(tabPageDevolver);
            materialTabControl1.Controls.Add(tabPageCadastrar);
            materialTabControl1.Controls.Add(tabPageRelatorios);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(0, 100);
            materialTabControl1.Margin = new Padding(0);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(933, 592);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPageGerenciar
            // 
            tabPageGerenciar.Controls.Add(ListViewSaida);
            tabPageGerenciar.Controls.Add(ListViewEntrada);
            tabPageGerenciar.Controls.Add(materialLabel18);
            tabPageGerenciar.Controls.Add(materialLabel17);
            tabPageGerenciar.Location = new Point(4, 24);
            tabPageGerenciar.Name = "tabPageGerenciar";
            tabPageGerenciar.Size = new Size(925, 564);
            tabPageGerenciar.TabIndex = 5;
            tabPageGerenciar.Text = "Gerenciar Caixas";
            tabPageGerenciar.UseVisualStyleBackColor = true;
            // 
            // ListViewSaida
            // 
            ListViewSaida.AutoSizeTable = false;
            ListViewSaida.BackColor = Color.FromArgb(255, 255, 255);
            ListViewSaida.BorderStyle = BorderStyle.None;
            ListViewSaida.Depth = 0;
            ListViewSaida.FullRowSelect = true;
            ListViewSaida.Location = new Point(16, 267);
            ListViewSaida.MinimumSize = new Size(200, 100);
            ListViewSaida.MouseLocation = new Point(-1, -1);
            ListViewSaida.MouseState = MaterialSkin.MouseState.OUT;
            ListViewSaida.Name = "ListViewSaida";
            ListViewSaida.OwnerDraw = true;
            ListViewSaida.Size = new Size(904, 202);
            ListViewSaida.TabIndex = 3;
            ListViewSaida.UseCompatibleStateImageBehavior = false;
            ListViewSaida.View = System.Windows.Forms.View.Details;
            // 
            // ListViewEntrada
            // 
            ListViewEntrada.AutoSizeTable = false;
            ListViewEntrada.BackColor = Color.FromArgb(255, 255, 255);
            ListViewEntrada.BorderStyle = BorderStyle.None;
            ListViewEntrada.Depth = 0;
            ListViewEntrada.FullRowSelect = true;
            ListViewEntrada.Location = new Point(18, 36);
            ListViewEntrada.MinimumSize = new Size(200, 100);
            ListViewEntrada.MouseLocation = new Point(-1, -1);
            ListViewEntrada.MouseState = MaterialSkin.MouseState.OUT;
            ListViewEntrada.MultiSelect = false;
            ListViewEntrada.Name = "ListViewEntrada";
            ListViewEntrada.OwnerDraw = true;
            ListViewEntrada.Size = new Size(904, 202);
            ListViewEntrada.TabIndex = 2;
            ListViewEntrada.UseCompatibleStateImageBehavior = false;
            ListViewEntrada.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel18
            // 
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.Location = new Point(16, 241);
            materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(138, 23);
            materialLabel18.TabIndex = 1;
            materialLabel18.Text = "Saida de Caixa";
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel17.Location = new Point(17, 12);
            materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(137, 19);
            materialLabel17.TabIndex = 0;
            materialLabel17.Text = "Entradas de Caixas";
            // 
            // tabPageReceber
            // 
            tabPageReceber.Controls.Add(atualCaixa);
            tabPageReceber.Controls.Add(cadCaixa);
            tabPageReceber.Controls.Add(validaFunc);
            tabPageReceber.Controls.Add(validaAluno);
            tabPageReceber.Controls.Add(comboFunc);
            tabPageReceber.Controls.Add(comboAluno);
            tabPageReceber.Controls.Add(entradaDetalhe);
            tabPageReceber.Controls.Add(dateEntrada);
            tabPageReceber.Controls.Add(comboProcedimento);
            tabPageReceber.Controls.Add(materialLabel10);
            tabPageReceber.Controls.Add(materialLabel9);
            tabPageReceber.Controls.Add(materialLabel8);
            tabPageReceber.Controls.Add(materialLabel7);
            tabPageReceber.Controls.Add(materialLabel6);
            tabPageReceber.Location = new Point(4, 24);
            tabPageReceber.Margin = new Padding(4, 3, 4, 3);
            tabPageReceber.Name = "tabPageReceber";
            tabPageReceber.Padding = new Padding(4, 3, 4, 3);
            tabPageReceber.Size = new Size(925, 564);
            tabPageReceber.TabIndex = 0;
            tabPageReceber.Text = "Receber Caixa";
            tabPageReceber.UseVisualStyleBackColor = true;
            // 
            // atualCaixa
            // 
            atualCaixa.AutoSize = false;
            atualCaixa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            atualCaixa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            atualCaixa.Depth = 0;
            atualCaixa.HighEmphasis = true;
            atualCaixa.Icon = Properties.Resources.disc;
            atualCaixa.Location = new Point(238, 449);
            atualCaixa.Margin = new Padding(4, 6, 4, 6);
            atualCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            atualCaixa.Name = "atualCaixa";
            atualCaixa.NoAccentTextColor = Color.Empty;
            atualCaixa.Size = new Size(205, 49);
            atualCaixa.TabIndex = 13;
            atualCaixa.Text = "Salvar Caixa";
            atualCaixa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            atualCaixa.UseAccentColor = false;
            atualCaixa.UseVisualStyleBackColor = true;
            // 
            // cadCaixa
            // 
            cadCaixa.AutoSize = false;
            cadCaixa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cadCaixa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            cadCaixa.Depth = 0;
            cadCaixa.HighEmphasis = true;
            cadCaixa.Icon = Properties.Resources.inserir;
            cadCaixa.Location = new Point(615, 449);
            cadCaixa.Margin = new Padding(4, 6, 4, 6);
            cadCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            cadCaixa.Name = "cadCaixa";
            cadCaixa.NoAccentTextColor = Color.Empty;
            cadCaixa.Size = new Size(205, 49);
            cadCaixa.TabIndex = 12;
            cadCaixa.Text = "Cadastrar Caixa";
            cadCaixa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            cadCaixa.UseAccentColor = false;
            cadCaixa.UseVisualStyleBackColor = true;
            // 
            // validaFunc
            // 
            validaFunc.AutoSize = false;
            validaFunc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            validaFunc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            validaFunc.Depth = 0;
            validaFunc.HighEmphasis = true;
            validaFunc.Icon = Properties.Resources.bio;
            validaFunc.Location = new Point(675, 316);
            validaFunc.Margin = new Padding(4, 6, 4, 6);
            validaFunc.MouseState = MaterialSkin.MouseState.HOVER;
            validaFunc.Name = "validaFunc";
            validaFunc.NoAccentTextColor = Color.Empty;
            validaFunc.Size = new Size(205, 49);
            validaFunc.TabIndex = 11;
            validaFunc.Text = "Valida Biometria Funcionário";
            validaFunc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            validaFunc.UseAccentColor = false;
            validaFunc.UseVisualStyleBackColor = true;
            // 
            // validaAluno
            // 
            validaAluno.AutoSize = false;
            validaAluno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            validaAluno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            validaAluno.Depth = 0;
            validaAluno.HighEmphasis = true;
            validaAluno.Icon = Properties.Resources.bio;
            validaAluno.Location = new Point(675, 251);
            validaAluno.Margin = new Padding(4, 6, 4, 6);
            validaAluno.MouseState = MaterialSkin.MouseState.HOVER;
            validaAluno.Name = "validaAluno";
            validaAluno.NoAccentTextColor = Color.Empty;
            validaAluno.Size = new Size(205, 47);
            validaAluno.TabIndex = 9;
            validaAluno.Text = "Valida Biometria Aluno";
            validaAluno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            validaAluno.UseAccentColor = false;
            validaAluno.UseVisualStyleBackColor = true;
            // 
            // comboFunc
            // 
            comboFunc.AutoCompleteCustomSource.AddRange(new string[] { "João", "José", "Maria", "Angela", "Lais" });
            comboFunc.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboFunc.AutoResize = false;
            comboFunc.BackColor = Color.FromArgb(255, 255, 255);
            comboFunc.Depth = 0;
            comboFunc.DrawMode = DrawMode.OwnerDrawVariable;
            comboFunc.DropDownHeight = 174;
            comboFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFunc.DropDownWidth = 121;
            comboFunc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboFunc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboFunc.FormattingEnabled = true;
            comboFunc.Hint = "Validação da entrega pelo Funcionário";
            comboFunc.IntegralHeight = false;
            comboFunc.ItemHeight = 43;
            comboFunc.Location = new Point(238, 316);
            comboFunc.MaxDropDownItems = 4;
            comboFunc.MouseState = MaterialSkin.MouseState.OUT;
            comboFunc.Name = "comboFunc";
            comboFunc.Size = new Size(421, 49);
            comboFunc.StartIndex = 0;
            comboFunc.TabIndex = 10;
            // 
            // comboAluno
            // 
            comboAluno.AutoCompleteCustomSource.AddRange(new string[] { "João", "José", "Maria", "Angela", "Lais" });
            comboAluno.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboAluno.AutoResize = false;
            comboAluno.BackColor = Color.FromArgb(255, 255, 255);
            comboAluno.Depth = 0;
            comboAluno.DrawMode = DrawMode.OwnerDrawVariable;
            comboAluno.DropDownHeight = 174;
            comboAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboAluno.DropDownWidth = 121;
            comboAluno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboAluno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboAluno.FormattingEnabled = true;
            comboAluno.Hint = "Validação da entrega pelo Aluno";
            comboAluno.IntegralHeight = false;
            comboAluno.ItemHeight = 43;
            comboAluno.Items.AddRange(new object[] { "João", "José", "Maria", "Ângela", "Lais" });
            comboAluno.Location = new Point(238, 249);
            comboAluno.MaxDropDownItems = 4;
            comboAluno.MouseState = MaterialSkin.MouseState.OUT;
            comboAluno.Name = "comboAluno";
            comboAluno.Size = new Size(421, 49);
            comboAluno.StartIndex = 0;
            comboAluno.TabIndex = 8;
            // 
            // entradaDetalhe
            // 
            entradaDetalhe.AnimateReadOnly = false;
            entradaDetalhe.BackgroundImageLayout = ImageLayout.None;
            entradaDetalhe.CharacterCasing = CharacterCasing.Normal;
            entradaDetalhe.Depth = 0;
            entradaDetalhe.HideSelection = true;
            entradaDetalhe.Hint = "Há informações adicionais?";
            entradaDetalhe.Location = new Point(238, 142);
            entradaDetalhe.MaxLength = 32767;
            entradaDetalhe.MouseState = MaterialSkin.MouseState.OUT;
            entradaDetalhe.Name = "entradaDetalhe";
            entradaDetalhe.PasswordChar = '\0';
            entradaDetalhe.ReadOnly = false;
            entradaDetalhe.ScrollBars = ScrollBars.None;
            entradaDetalhe.SelectedText = "";
            entradaDetalhe.SelectionLength = 0;
            entradaDetalhe.SelectionStart = 0;
            entradaDetalhe.ShortcutsEnabled = true;
            entradaDetalhe.Size = new Size(656, 100);
            entradaDetalhe.TabIndex = 7;
            entradaDetalhe.TabStop = false;
            entradaDetalhe.TextAlign = HorizontalAlignment.Left;
            entradaDetalhe.UseSystemPasswordChar = false;
            // 
            // dateEntrada
            // 
            dateEntrada.CalendarTitleBackColor = Color.Teal;
            dateEntrada.Location = new Point(238, 113);
            dateEntrada.Name = "dateEntrada";
            dateEntrada.Size = new Size(200, 23);
            dateEntrada.TabIndex = 6;
            // 
            // comboProcedimento
            // 
            comboProcedimento.AutoResize = false;
            comboProcedimento.BackColor = Color.FromArgb(255, 255, 255);
            comboProcedimento.Depth = 0;
            comboProcedimento.DrawMode = DrawMode.OwnerDrawVariable;
            comboProcedimento.DropDownHeight = 174;
            comboProcedimento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProcedimento.DropDownWidth = 121;
            comboProcedimento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboProcedimento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboProcedimento.FormattingEnabled = true;
            comboProcedimento.Hint = "Indique o tipo de procedimento";
            comboProcedimento.IntegralHeight = false;
            comboProcedimento.ItemHeight = 43;
            comboProcedimento.Location = new Point(238, 58);
            comboProcedimento.MaxDropDownItems = 4;
            comboProcedimento.MouseState = MaterialSkin.MouseState.OUT;
            comboProcedimento.Name = "comboProcedimento";
            comboProcedimento.Size = new Size(312, 49);
            comboProcedimento.StartIndex = 0;
            comboProcedimento.TabIndex = 5;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(143, 316);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(89, 19);
            materialLabel10.TabIndex = 4;
            materialLabel10.Text = "Funcionário:";
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.Location = new Point(186, 249);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(46, 19);
            materialLabel9.TabIndex = 3;
            materialLabel9.Text = "Aluno:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(84, 148);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(148, 19);
            materialLabel8.TabIndex = 2;
            materialLabel8.Text = "Detalhes da Entrada:";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(134, 113);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(98, 19);
            materialLabel7.TabIndex = 1;
            materialLabel7.Text = "Data Entrada:";
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(93, 58);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(139, 19);
            materialLabel6.TabIndex = 0;
            materialLabel6.Text = "Tipo Procedimento:";
            // 
            // tabPageDevolver
            // 
            tabPageDevolver.Controls.Add(materialMultiLineTextBox21);
            tabPageDevolver.Controls.Add(devolveCaixa);
            tabPageDevolver.Controls.Add(validaSaidaFunc);
            tabPageDevolver.Controls.Add(comboSaidaFunc);
            tabPageDevolver.Controls.Add(validaSaidaAluno);
            tabPageDevolver.Controls.Add(comboSaidaAluno);
            tabPageDevolver.Controls.Add(dateSaida);
            tabPageDevolver.Controls.Add(textProcedimento);
            tabPageDevolver.Controls.Add(comboCaixa);
            tabPageDevolver.Controls.Add(materialLabel16);
            tabPageDevolver.Controls.Add(materialLabel15);
            tabPageDevolver.Controls.Add(materialLabel14);
            tabPageDevolver.Controls.Add(materialLabel13);
            tabPageDevolver.Controls.Add(materialLabel12);
            tabPageDevolver.Controls.Add(materialLabel11);
            tabPageDevolver.Location = new Point(4, 24);
            tabPageDevolver.Margin = new Padding(4, 3, 4, 3);
            tabPageDevolver.Name = "tabPageDevolver";
            tabPageDevolver.Padding = new Padding(4, 3, 4, 3);
            tabPageDevolver.Size = new Size(925, 564);
            tabPageDevolver.TabIndex = 1;
            tabPageDevolver.Text = "Devolver Caixa";
            tabPageDevolver.UseVisualStyleBackColor = true;
            // 
            // materialMultiLineTextBox21
            // 
            materialMultiLineTextBox21.AnimateReadOnly = false;
            materialMultiLineTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBox21.Depth = 0;
            materialMultiLineTextBox21.HideSelection = true;
            materialMultiLineTextBox21.Hint = "Alguma informação necessária?";
            materialMultiLineTextBox21.Location = new Point(196, 191);
            materialMultiLineTextBox21.MaxLength = 32767;
            materialMultiLineTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialMultiLineTextBox21.Name = "materialMultiLineTextBox21";
            materialMultiLineTextBox21.PasswordChar = '\0';
            materialMultiLineTextBox21.ReadOnly = false;
            materialMultiLineTextBox21.ScrollBars = ScrollBars.None;
            materialMultiLineTextBox21.SelectedText = "";
            materialMultiLineTextBox21.SelectionLength = 0;
            materialMultiLineTextBox21.SelectionStart = 0;
            materialMultiLineTextBox21.ShortcutsEnabled = true;
            materialMultiLineTextBox21.Size = new Size(640, 100);
            materialMultiLineTextBox21.TabIndex = 9;
            materialMultiLineTextBox21.TabStop = false;
            materialMultiLineTextBox21.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBox21.UseSystemPasswordChar = false;
            // 
            // devolveCaixa
            // 
            devolveCaixa.AutoSize = false;
            devolveCaixa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            devolveCaixa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            devolveCaixa.Depth = 0;
            devolveCaixa.HighEmphasis = true;
            devolveCaixa.Icon = Properties.Resources.devolver;
            devolveCaixa.Location = new Point(418, 464);
            devolveCaixa.Margin = new Padding(4, 6, 4, 6);
            devolveCaixa.MouseState = MaterialSkin.MouseState.HOVER;
            devolveCaixa.Name = "devolveCaixa";
            devolveCaixa.NoAccentTextColor = Color.Empty;
            devolveCaixa.Size = new Size(205, 51);
            devolveCaixa.TabIndex = 14;
            devolveCaixa.Text = "Devolver Caixa";
            devolveCaixa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            devolveCaixa.UseAccentColor = false;
            devolveCaixa.UseVisualStyleBackColor = true;
            // 
            // validaSaidaFunc
            // 
            validaSaidaFunc.AutoSize = false;
            validaSaidaFunc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            validaSaidaFunc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            validaSaidaFunc.Depth = 0;
            validaSaidaFunc.HighEmphasis = true;
            validaSaidaFunc.Icon = Properties.Resources.bio;
            validaSaidaFunc.Location = new Point(680, 362);
            validaSaidaFunc.Margin = new Padding(4, 6, 4, 6);
            validaSaidaFunc.MouseState = MaterialSkin.MouseState.HOVER;
            validaSaidaFunc.Name = "validaSaidaFunc";
            validaSaidaFunc.NoAccentTextColor = Color.Empty;
            validaSaidaFunc.Size = new Size(205, 49);
            validaSaidaFunc.TabIndex = 13;
            validaSaidaFunc.Text = "Valida Biometria Funcionário";
            validaSaidaFunc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            validaSaidaFunc.UseAccentColor = false;
            validaSaidaFunc.UseVisualStyleBackColor = true;
            // 
            // comboSaidaFunc
            // 
            comboSaidaFunc.AutoResize = false;
            comboSaidaFunc.BackColor = Color.FromArgb(255, 255, 255);
            comboSaidaFunc.Depth = 0;
            comboSaidaFunc.DrawMode = DrawMode.OwnerDrawVariable;
            comboSaidaFunc.DropDownHeight = 174;
            comboSaidaFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSaidaFunc.DropDownWidth = 121;
            comboSaidaFunc.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboSaidaFunc.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboSaidaFunc.FormattingEnabled = true;
            comboSaidaFunc.Hint = "Validação da retirada pelo Funcionário";
            comboSaidaFunc.IntegralHeight = false;
            comboSaidaFunc.ItemHeight = 43;
            comboSaidaFunc.Location = new Point(196, 362);
            comboSaidaFunc.MaxDropDownItems = 4;
            comboSaidaFunc.MouseState = MaterialSkin.MouseState.OUT;
            comboSaidaFunc.Name = "comboSaidaFunc";
            comboSaidaFunc.Size = new Size(455, 49);
            comboSaidaFunc.StartIndex = 0;
            comboSaidaFunc.TabIndex = 12;
            // 
            // validaSaidaAluno
            // 
            validaSaidaAluno.AutoSize = false;
            validaSaidaAluno.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            validaSaidaAluno.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            validaSaidaAluno.Depth = 0;
            validaSaidaAluno.HighEmphasis = true;
            validaSaidaAluno.Icon = Properties.Resources.bio;
            validaSaidaAluno.Location = new Point(680, 303);
            validaSaidaAluno.Margin = new Padding(4, 6, 4, 6);
            validaSaidaAluno.MouseState = MaterialSkin.MouseState.HOVER;
            validaSaidaAluno.Name = "validaSaidaAluno";
            validaSaidaAluno.NoAccentTextColor = Color.Empty;
            validaSaidaAluno.Size = new Size(205, 49);
            validaSaidaAluno.TabIndex = 11;
            validaSaidaAluno.Text = "Valida Biometria Aluno";
            validaSaidaAluno.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            validaSaidaAluno.UseAccentColor = false;
            validaSaidaAluno.UseVisualStyleBackColor = true;
            // 
            // comboSaidaAluno
            // 
            comboSaidaAluno.AutoResize = false;
            comboSaidaAluno.BackColor = Color.FromArgb(255, 255, 255);
            comboSaidaAluno.Depth = 0;
            comboSaidaAluno.DrawMode = DrawMode.OwnerDrawVariable;
            comboSaidaAluno.DropDownHeight = 174;
            comboSaidaAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSaidaAluno.DropDownWidth = 121;
            comboSaidaAluno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboSaidaAluno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboSaidaAluno.FormattingEnabled = true;
            comboSaidaAluno.Hint = "Validação da retirada pelo Aluno";
            comboSaidaAluno.IntegralHeight = false;
            comboSaidaAluno.ItemHeight = 43;
            comboSaidaAluno.Location = new Point(196, 303);
            comboSaidaAluno.MaxDropDownItems = 4;
            comboSaidaAluno.MouseState = MaterialSkin.MouseState.OUT;
            comboSaidaAluno.Name = "comboSaidaAluno";
            comboSaidaAluno.Size = new Size(455, 49);
            comboSaidaAluno.StartIndex = 0;
            comboSaidaAluno.TabIndex = 10;
            // 
            // dateSaida
            // 
            dateSaida.Location = new Point(196, 155);
            dateSaida.Name = "dateSaida";
            dateSaida.Size = new Size(200, 23);
            dateSaida.TabIndex = 8;
            // 
            // textProcedimento
            // 
            textProcedimento.AnimateReadOnly = false;
            textProcedimento.BackgroundImageLayout = ImageLayout.None;
            textProcedimento.CharacterCasing = CharacterCasing.Normal;
            textProcedimento.Depth = 0;
            textProcedimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            textProcedimento.HideSelection = true;
            textProcedimento.Hint = "Tipo de Procedimento";
            textProcedimento.LeadingIcon = null;
            textProcedimento.Location = new Point(196, 95);
            textProcedimento.MaxLength = 32767;
            textProcedimento.MouseState = MaterialSkin.MouseState.OUT;
            textProcedimento.Name = "textProcedimento";
            textProcedimento.PasswordChar = '\0';
            textProcedimento.PrefixSuffixText = null;
            textProcedimento.ReadOnly = false;
            textProcedimento.RightToLeft = RightToLeft.No;
            textProcedimento.SelectedText = "";
            textProcedimento.SelectionLength = 0;
            textProcedimento.SelectionStart = 0;
            textProcedimento.ShortcutsEnabled = true;
            textProcedimento.Size = new Size(640, 48);
            textProcedimento.TabIndex = 7;
            textProcedimento.TabStop = false;
            textProcedimento.TextAlign = HorizontalAlignment.Left;
            textProcedimento.TrailingIcon = null;
            textProcedimento.UseSystemPasswordChar = false;
            // 
            // comboCaixa
            // 
            comboCaixa.AutoResize = false;
            comboCaixa.BackColor = Color.FromArgb(255, 255, 255);
            comboCaixa.Depth = 0;
            comboCaixa.DrawMode = DrawMode.OwnerDrawVariable;
            comboCaixa.DropDownHeight = 174;
            comboCaixa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCaixa.DropDownWidth = 121;
            comboCaixa.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboCaixa.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboCaixa.FormattingEnabled = true;
            comboCaixa.Hint = "Nome da Caixa";
            comboCaixa.IntegralHeight = false;
            comboCaixa.ItemHeight = 43;
            comboCaixa.Location = new Point(196, 34);
            comboCaixa.MaxDropDownItems = 4;
            comboCaixa.MouseState = MaterialSkin.MouseState.OUT;
            comboCaixa.Name = "comboCaixa";
            comboCaixa.Size = new Size(442, 49);
            comboCaixa.StartIndex = 0;
            comboCaixa.TabIndex = 6;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel16.Location = new Point(90, 362);
            materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(89, 19);
            materialLabel16.TabIndex = 5;
            materialLabel16.Text = "Funcionário:";
            // 
            // materialLabel15
            // 
            materialLabel15.AutoSize = true;
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.Location = new Point(133, 306);
            materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(46, 19);
            materialLabel15.TabIndex = 4;
            materialLabel15.Text = "Aluno:";
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(75, 191);
            materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(104, 19);
            materialLabel14.TabIndex = 3;
            materialLabel14.Text = "Detalhe Saída:";
            // 
            // materialLabel13
            // 
            materialLabel13.AutoSize = true;
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.Location = new Point(95, 155);
            materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(84, 19);
            materialLabel13.TabIndex = 2;
            materialLabel13.Text = "Data Saída:";
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(19, 95);
            materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(160, 19);
            materialLabel12.TabIndex = 1;
            materialLabel12.Text = "Tipo de Procedimento:";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(134, 34);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(45, 19);
            materialLabel11.TabIndex = 0;
            materialLabel11.Text = "Caixa:";
            // 
            // tabPageCadastrar
            // 
            tabPageCadastrar.Controls.Add(biometriaCad);
            tabPageCadastrar.Controls.Add(biometriaCadastrada);
            tabPageCadastrar.Controls.Add(materialLabel5);
            tabPageCadastrar.Controls.Add(saveUser);
            tabPageCadastrar.Controls.Add(deleteUser);
            tabPageCadastrar.Controls.Add(userEmail);
            tabPageCadastrar.Controls.Add(materialLabel4);
            tabPageCadastrar.Controls.Add(comboTipoUser);
            tabPageCadastrar.Controls.Add(materialLabel3);
            tabPageCadastrar.Controls.Add(userFone);
            tabPageCadastrar.Controls.Add(labelfone);
            tabPageCadastrar.Controls.Add(userCPF);
            tabPageCadastrar.Controls.Add(userNome);
            tabPageCadastrar.Controls.Add(materialLabel2);
            tabPageCadastrar.Controls.Add(materialLabel1);
            tabPageCadastrar.Location = new Point(4, 24);
            tabPageCadastrar.Margin = new Padding(4, 3, 4, 3);
            tabPageCadastrar.Name = "tabPageCadastrar";
            tabPageCadastrar.Padding = new Padding(4, 3, 4, 3);
            tabPageCadastrar.Size = new Size(925, 564);
            tabPageCadastrar.TabIndex = 2;
            tabPageCadastrar.Text = "Cadastrar Usuario";
            tabPageCadastrar.UseVisualStyleBackColor = true;
            // 
            // biometriaCad
            // 
            biometriaCad.AutoSize = false;
            biometriaCad.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            biometriaCad.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            biometriaCad.Depth = 0;
            biometriaCad.HighEmphasis = true;
            biometriaCad.Icon = Properties.Resources.bio;
            biometriaCad.Location = new Point(370, 345);
            biometriaCad.Margin = new Padding(4, 6, 4, 6);
            biometriaCad.MouseState = MaterialSkin.MouseState.HOVER;
            biometriaCad.Name = "biometriaCad";
            biometriaCad.NoAccentTextColor = Color.Empty;
            biometriaCad.Size = new Size(205, 49);
            biometriaCad.TabIndex = 12;
            biometriaCad.Text = "Cadastrar Biometria";
            biometriaCad.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            biometriaCad.UseAccentColor = false;
            biometriaCad.UseVisualStyleBackColor = true;
            // 
            // biometriaCadastrada
            // 
            biometriaCadastrada.Depth = 0;
            biometriaCadastrada.Location = new Point(156, 346);
            biometriaCadastrada.Margin = new Padding(0);
            biometriaCadastrada.MouseLocation = new Point(-1, -1);
            biometriaCadastrada.MouseState = MaterialSkin.MouseState.HOVER;
            biometriaCadastrada.Name = "biometriaCadastrada";
            biometriaCadastrada.ReadOnly = false;
            biometriaCadastrada.Ripple = true;
            biometriaCadastrada.Size = new Size(181, 49);
            biometriaCadastrada.TabIndex = 11;
            biometriaCadastrada.Text = "Biometria Capturada";
            biometriaCadastrada.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(77, 355);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(73, 19);
            materialLabel5.TabIndex = 15;
            materialLabel5.Text = "Biometria:";
            // 
            // saveUser
            // 
            saveUser.AutoSize = false;
            saveUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            saveUser.Depth = 0;
            saveUser.HighEmphasis = true;
            saveUser.Icon = Properties.Resources.disc;
            saveUser.Location = new Point(513, 454);
            saveUser.Margin = new Padding(4, 6, 4, 6);
            saveUser.MouseState = MaterialSkin.MouseState.HOVER;
            saveUser.Name = "saveUser";
            saveUser.NoAccentTextColor = Color.Empty;
            saveUser.Size = new Size(205, 49);
            saveUser.TabIndex = 13;
            saveUser.Text = "Salvar Usuario";
            saveUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            saveUser.UseAccentColor = false;
            saveUser.UseVisualStyleBackColor = true;
            // 
            // deleteUser
            // 
            deleteUser.AutoSize = false;
            deleteUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            deleteUser.Depth = 0;
            deleteUser.HighEmphasis = true;
            deleteUser.Icon = Properties.Resources.excluir;
            deleteUser.Location = new Point(233, 454);
            deleteUser.Margin = new Padding(4, 6, 4, 6);
            deleteUser.MouseState = MaterialSkin.MouseState.HOVER;
            deleteUser.Name = "deleteUser";
            deleteUser.NoAccentTextColor = Color.Empty;
            deleteUser.Size = new Size(205, 49);
            deleteUser.TabIndex = 14;
            deleteUser.Text = "Excluir Usuário";
            deleteUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            deleteUser.UseAccentColor = false;
            deleteUser.UseVisualStyleBackColor = true;
            // 
            // userEmail
            // 
            userEmail.AnimateReadOnly = false;
            userEmail.BackgroundImageLayout = ImageLayout.None;
            userEmail.CharacterCasing = CharacterCasing.Normal;
            userEmail.Depth = 0;
            userEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userEmail.HideSelection = true;
            userEmail.Hint = "Qual o e-mail do usuário";
            userEmail.LeadingIcon = null;
            userEmail.Location = new Point(156, 291);
            userEmail.MaxLength = 32767;
            userEmail.MouseState = MaterialSkin.MouseState.OUT;
            userEmail.Name = "userEmail";
            userEmail.PasswordChar = '\0';
            userEmail.PrefixSuffixText = null;
            userEmail.ReadOnly = false;
            userEmail.RightToLeft = RightToLeft.No;
            userEmail.SelectedText = "";
            userEmail.SelectionLength = 0;
            userEmail.SelectionStart = 0;
            userEmail.ShortcutsEnabled = true;
            userEmail.Size = new Size(722, 48);
            userEmail.TabIndex = 10;
            userEmail.TabStop = false;
            userEmail.TextAlign = HorizontalAlignment.Left;
            userEmail.TrailingIcon = null;
            userEmail.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(101, 291);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(49, 19);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "E-mail:";
            // 
            // comboTipoUser
            // 
            comboTipoUser.AutoResize = false;
            comboTipoUser.BackColor = Color.FromArgb(255, 255, 255);
            comboTipoUser.Depth = 0;
            comboTipoUser.DrawMode = DrawMode.OwnerDrawVariable;
            comboTipoUser.DropDownHeight = 174;
            comboTipoUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTipoUser.DropDownWidth = 121;
            comboTipoUser.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            comboTipoUser.ForeColor = Color.FromArgb(222, 0, 0, 0);
            comboTipoUser.FormattingEnabled = true;
            comboTipoUser.Hint = "Tipo de Usuário";
            comboTipoUser.IntegralHeight = false;
            comboTipoUser.ItemHeight = 43;
            comboTipoUser.Items.AddRange(new object[] { "Funcionario", "Aluno" });
            comboTipoUser.Location = new Point(156, 233);
            comboTipoUser.MaxDropDownItems = 4;
            comboTipoUser.MouseState = MaterialSkin.MouseState.OUT;
            comboTipoUser.Name = "comboTipoUser";
            comboTipoUser.Size = new Size(322, 49);
            comboTipoUser.StartIndex = 0;
            comboTipoUser.TabIndex = 8;
            comboTipoUser.UseWaitCursor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(55, 233);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(95, 19);
            materialLabel3.TabIndex = 7;
            materialLabel3.Text = "Tipo Usuario:";
            // 
            // userFone
            // 
            userFone.AnimateReadOnly = false;
            userFone.BackgroundImageLayout = ImageLayout.None;
            userFone.CharacterCasing = CharacterCasing.Normal;
            userFone.Depth = 0;
            userFone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userFone.HideSelection = true;
            userFone.Hint = "Qual o telefone";
            userFone.LeadingIcon = null;
            userFone.Location = new Point(156, 179);
            userFone.MaxLength = 32767;
            userFone.MouseState = MaterialSkin.MouseState.OUT;
            userFone.Name = "userFone";
            userFone.PasswordChar = '\0';
            userFone.PrefixSuffixText = null;
            userFone.ReadOnly = false;
            userFone.RightToLeft = RightToLeft.No;
            userFone.SelectedText = "";
            userFone.SelectionLength = 0;
            userFone.SelectionStart = 0;
            userFone.ShortcutsEnabled = true;
            userFone.Size = new Size(325, 48);
            userFone.TabIndex = 6;
            userFone.TabStop = false;
            userFone.TextAlign = HorizontalAlignment.Left;
            userFone.TrailingIcon = null;
            userFone.UseSystemPasswordChar = false;
            // 
            // labelfone
            // 
            labelfone.AutoSize = true;
            labelfone.Depth = 0;
            labelfone.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            labelfone.Location = new Point(83, 179);
            labelfone.MouseState = MaterialSkin.MouseState.HOVER;
            labelfone.Name = "labelfone";
            labelfone.Size = new Size(67, 19);
            labelfone.TabIndex = 5;
            labelfone.Text = "Telefone:";
            // 
            // userCPF
            // 
            userCPF.AnimateReadOnly = false;
            userCPF.BackgroundImageLayout = ImageLayout.None;
            userCPF.CharacterCasing = CharacterCasing.Normal;
            userCPF.Depth = 0;
            userCPF.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userCPF.HideSelection = true;
            userCPF.Hint = "Digite o CPF do Usuário";
            userCPF.LeadingIcon = null;
            userCPF.Location = new Point(156, 125);
            userCPF.MaxLength = 32767;
            userCPF.MouseState = MaterialSkin.MouseState.OUT;
            userCPF.Name = "userCPF";
            userCPF.PasswordChar = '\0';
            userCPF.PrefixSuffixText = null;
            userCPF.ReadOnly = false;
            userCPF.RightToLeft = RightToLeft.No;
            userCPF.SelectedText = "";
            userCPF.SelectionLength = 0;
            userCPF.SelectionStart = 0;
            userCPF.ShortcutsEnabled = true;
            userCPF.Size = new Size(325, 48);
            userCPF.TabIndex = 4;
            userCPF.TabStop = false;
            userCPF.TextAlign = HorizontalAlignment.Left;
            userCPF.TrailingIcon = null;
            userCPF.UseSystemPasswordChar = false;
            // 
            // userNome
            // 
            userNome.AnimateReadOnly = false;
            userNome.BackgroundImageLayout = ImageLayout.None;
            userNome.CharacterCasing = CharacterCasing.Normal;
            userNome.Depth = 0;
            userNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            userNome.HideSelection = true;
            userNome.Hint = "Digite o nome do usuário";
            userNome.LeadingIcon = null;
            userNome.Location = new Point(156, 71);
            userNome.MaxLength = 32767;
            userNome.MouseState = MaterialSkin.MouseState.OUT;
            userNome.Name = "userNome";
            userNome.PasswordChar = '\0';
            userNome.PrefixSuffixText = null;
            userNome.ReadOnly = false;
            userNome.RightToLeft = RightToLeft.No;
            userNome.SelectedText = "";
            userNome.SelectionLength = 0;
            userNome.SelectionStart = 0;
            userNome.ShortcutsEnabled = true;
            userNome.Size = new Size(725, 48);
            userNome.TabIndex = 3;
            userNome.TabStop = false;
            userNome.TextAlign = HorizontalAlignment.Left;
            userNome.TrailingIcon = null;
            userNome.UseSystemPasswordChar = false;
            userNome.UseWaitCursor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(117, 125);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(34, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "CPF:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(104, 71);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(47, 19);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Nome:";
            // 
            // tabPageRelatorios
            // 
            tabPageRelatorios.Location = new Point(4, 24);
            tabPageRelatorios.Margin = new Padding(4, 3, 4, 3);
            tabPageRelatorios.Name = "tabPageRelatorios";
            tabPageRelatorios.Padding = new Padding(4, 3, 4, 3);
            tabPageRelatorios.Size = new Size(925, 564);
            tabPageRelatorios.TabIndex = 4;
            tabPageRelatorios.Text = "Relatórios";
            tabPageRelatorios.UseVisualStyleBackColor = true;
            // 
            // TelaMultifuncional
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 692);
            Controls.Add(materialTabControl1);
            Controls.Add(materialTabSelector1);
            Margin = new Padding(0);
            Name = "TelaMultifuncional";
            Padding = new Padding(0, 60, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Multifuncional";
            materialTabControl1.ResumeLayout(false);
            tabPageGerenciar.ResumeLayout(false);
            tabPageGerenciar.PerformLayout();
            tabPageReceber.ResumeLayout(false);
            tabPageReceber.PerformLayout();
            tabPageDevolver.ResumeLayout(false);
            tabPageDevolver.PerformLayout();
            tabPageCadastrar.ResumeLayout(false);
            tabPageCadastrar.PerformLayout();
            ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage tabPageReceber;
        private TabPage tabPageDevolver;
        private TabPage tabPageCadastrar;
        private MaterialSkin.Controls.MaterialTextBox2 userEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox comboTipoUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 userFone;
        private MaterialSkin.Controls.MaterialLabel labelfone;
        private MaterialSkin.Controls.MaterialTextBox2 userCPF;
        private MaterialSkin.Controls.MaterialTextBox2 userNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private TabPage tabPageRelatorios;
        private MaterialSkin.Controls.MaterialButton saveUser;
        private MaterialSkin.Controls.MaterialButton deleteUser;
        private TabPage tabPageGerenciar;
        private MaterialSkin.Controls.MaterialCheckbox biometriaCadastrada;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton biometriaCad;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 entradaDetalhe;
        private DateTimePicker dateEntrada;
        private MaterialSkin.Controls.MaterialComboBox comboProcedimento;
        private MaterialSkin.Controls.MaterialComboBox comboAluno;
        private MaterialSkin.Controls.MaterialComboBox comboFunc;
        private MaterialSkin.Controls.MaterialButton atualCaixa;
        private MaterialSkin.Controls.MaterialButton cadCaixa;
        private MaterialSkin.Controls.MaterialButton validaFunc;
        private MaterialSkin.Controls.MaterialButton validaAluno;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private DateTimePicker dateSaida;
        private MaterialSkin.Controls.MaterialTextBox2 textProcedimento;
        private MaterialSkin.Controls.MaterialComboBox comboCaixa;
        private MaterialSkin.Controls.MaterialButton validaSaidaFunc;
        private MaterialSkin.Controls.MaterialComboBox comboSaidaFunc;
        private MaterialSkin.Controls.MaterialButton validaSaidaAluno;
        private MaterialSkin.Controls.MaterialComboBox comboSaidaAluno;
        private MaterialSkin.Controls.MaterialButton devolveCaixa;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialListView ListViewSaida;
        private MaterialSkin.Controls.MaterialListView ListViewEntrada;
    }
}