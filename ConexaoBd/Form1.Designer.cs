namespace ConexaoBd
{
    partial class Form1
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
            lblTitulo = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblData = new Label();
            mkbData = new MaskedTextBox();
            lblSexo = new Label();
            cbbSexo = new ComboBox();
            lblCpf = new Label();
            mstCpf = new MaskedTextBox();
            lblRG = new Label();
            mskbRG = new MaskedTextBox();
            lblUF = new Label();
            cbbUF = new ComboBox();
            btnCadastrar = new Button();
            lblCelular = new Label();
            mskbCelular = new MaskedTextBox();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(154, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(452, 60);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro De Clientes";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(48, 119);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(166, 28);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(220, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(286, 27);
            txtNome.TabIndex = 2;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(26, 174);
            lblData.Name = "lblData";
            lblData.Size = new Size(205, 28);
            lblData.TabIndex = 3;
            lblData.Text = "Data de Nascimento";
            // 
            // mkbData
            // 
            mkbData.Location = new Point(248, 178);
            mkbData.Mask = "00/00/0000";
            mkbData.Name = "mkbData";
            mkbData.Size = new Size(192, 27);
            mkbData.TabIndex = 4;
            mkbData.ValidatingType = typeof(DateTime);
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(78, 289);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(57, 28);
            lblSexo.TabIndex = 5;
            lblSexo.Text = "Sexo";
            // 
            // cbbSexo
            // 
            cbbSexo.FormattingEnabled = true;
            cbbSexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cbbSexo.Location = new Point(233, 293);
            cbbSexo.Name = "cbbSexo";
            cbbSexo.Size = new Size(207, 28);
            cbbSexo.TabIndex = 6;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCpf.Location = new Point(89, 340);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(46, 28);
            lblCpf.TabIndex = 7;
            lblCpf.Text = "CPF";
            // 
            // mstCpf
            // 
            mstCpf.Location = new Point(233, 344);
            mstCpf.Mask = "000,000,000-00";
            mstCpf.Name = "mstCpf";
            mstCpf.Size = new Size(207, 27);
            mstCpf.TabIndex = 8;
            // 
            // lblRG
            // 
            lblRG.AutoSize = true;
            lblRG.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRG.Location = new Point(89, 387);
            lblRG.Name = "lblRG";
            lblRG.Size = new Size(39, 28);
            lblRG.TabIndex = 9;
            lblRG.Text = "RG";
            // 
            // mskbRG
            // 
            mskbRG.Location = new Point(233, 391);
            mskbRG.Mask = "00,000,000-0";
            mskbRG.Name = "mskbRG";
            mskbRG.Size = new Size(207, 27);
            mskbRG.TabIndex = 10;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUF.Location = new Point(92, 437);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(36, 28);
            lblUF.TabIndex = 11;
            lblUF.Text = "UF";
            // 
            // cbbUF
            // 
            cbbUF.FormattingEnabled = true;
            cbbUF.Items.AddRange(new object[] { "Acre - AC", "Alagoas - AL", "Amapá - AP", "Amazonas - AM", "Bahia - BA", "Ceará - CE", "Distrito Federal - DF", "Espírito Santo - ES", "Goiás - GO", "Maranhão - MA", "Mato Grosso - MT", "Mato Grosso do Sul - MS", "Minas Gerais - MG", "Pará - PA", "Paraíba - PB", "Paraná - PR", "Pernambuco - PE", "Piauí - PI", "Rio de Janeiro - RJ", "Rio Grande do Norte - RN", "Rio Grande do Sul - RS", "Rio de Janeiro - RJ", "Rondônia - RO", "Roraima - RR", "Santa Catarina - SC", "São Paulo - SP", "Sergipe - SE", "Tocantins - TO" });
            cbbUF.Location = new Point(233, 441);
            cbbUF.Name = "cbbUF";
            cbbUF.Size = new Size(207, 28);
            cbbUF.TabIndex = 12;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(534, 427);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(133, 73);
            btnCadastrar.TabIndex = 13;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelular.Location = new Point(68, 234);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(78, 28);
            lblCelular.TabIndex = 14;
            lblCelular.Text = "Celular";
            // 
            // mskbCelular
            // 
            mskbCelular.Location = new Point(233, 238);
            mskbCelular.Mask = "(00) 00000-0000";
            mskbCelular.Name = "mskbCelular";
            mskbCelular.Size = new Size(207, 27);
            mskbCelular.TabIndex = 15;
            // 
            // btnDeletar
            // 
            btnDeletar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeletar.Location = new Point(719, 427);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(120, 73);
            btnDeletar.TabIndex = 16;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 533);
            Controls.Add(btnDeletar);
            Controls.Add(mskbCelular);
            Controls.Add(lblCelular);
            Controls.Add(btnCadastrar);
            Controls.Add(cbbUF);
            Controls.Add(lblUF);
            Controls.Add(mskbRG);
            Controls.Add(lblRG);
            Controls.Add(mstCpf);
            Controls.Add(lblCpf);
            Controls.Add(cbbSexo);
            Controls.Add(lblSexo);
            Controls.Add(mkbData);
            Controls.Add(lblData);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblData;
        private MaskedTextBox mkbData;
        private Label lblSexo;
        private ComboBox cbbSexo;
        private Label lblCpf;
        private MaskedTextBox mstCpf;
        private Label lblRG;
        private MaskedTextBox mskbRG;
        private Label lblUF;
        private ComboBox cbbUF;
        private Button btnCadastrar;
        private Label lblCelular;
        private MaskedTextBox mskbCelular;
        private Button btnDeletar;
    }
}
