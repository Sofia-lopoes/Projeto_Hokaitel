namespace projeto_Hokaitel
{
    partial class FormCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txt123 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.btnRegistrado = new System.Windows.Forms.Button();
            this.textsla = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.bntMinimizar);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 70);
            this.panel1.TabIndex = 2;
            // 
            // bntMinimizar
            // 
            this.bntMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bntMinimizar.FlatAppearance.BorderSize = 0;
            this.bntMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimizar.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bntMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.bntMinimizar.IconColor = System.Drawing.SystemColors.ControlDark;
            this.bntMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntMinimizar.IconSize = 30;
            this.bntMinimizar.Location = new System.Drawing.Point(841, 0);
            this.bntMinimizar.Name = "bntMinimizar";
            this.bntMinimizar.Size = new System.Drawing.Size(49, 31);
            this.bntMinimizar.TabIndex = 10;
            this.bntMinimizar.UseVisualStyleBackColor = true;
            this.bntMinimizar.Click += new System.EventHandler(this.bntMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnFechar.IconColor = System.Drawing.SystemColors.ControlDark;
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 30;
            this.btnFechar.Location = new System.Drawing.Point(896, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 31);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(391, -48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txt123
            // 
            this.txt123.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt123.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt123.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt123.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt123.Location = new System.Drawing.Point(295, 223);
            this.txt123.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt123.Name = "txt123";
            this.txt123.Size = new System.Drawing.Size(413, 21);
            this.txt123.TabIndex = 3;
            this.txt123.Text = "................................................................................." +
    ".........................................................";
            this.txt123.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt.Location = new System.Drawing.Point(295, 268);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(413, 21);
            this.txt.TabIndex = 4;
            this.txt.Text = "................................................................................." +
    "...............................";
            this.txt.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.text.Location = new System.Drawing.Point(295, 311);
            this.text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(413, 21);
            this.text.TabIndex = 6;
            this.text.Text = "................................................................................." +
    "....................................................";
            this.text.TextChanged += new System.EventHandler(this.textCPF_TextChanged);
            // 
            // btnRegistrado
            // 
            this.btnRegistrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRegistrado.Location = new System.Drawing.Point(295, 463);
            this.btnRegistrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrado.Name = "btnRegistrado";
            this.btnRegistrado.Size = new System.Drawing.Size(413, 43);
            this.btnRegistrado.TabIndex = 7;
            this.btnRegistrado.Text = "Registrado";
            this.btnRegistrado.UseVisualStyleBackColor = true;
            this.btnRegistrado.Click += new System.EventHandler(this.btnRegistrado_Click);
            // 
            // textsla
            // 
            this.textsla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textsla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textsla.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsla.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textsla.Location = new System.Drawing.Point(295, 353);
            this.textsla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textsla.Name = "textsla";
            this.textsla.Size = new System.Drawing.Size(413, 21);
            this.textsla.TabIndex = 9;
            this.textsla.Text = "................................................................................." +
    ".........";
            this.textsla.TextChanged += new System.EventHandler(this.textSetor_TextChanged);
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textNome.Location = new System.Drawing.Point(295, 209);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(413, 21);
            this.textNome.TabIndex = 10;
            this.textNome.Text = "Nome";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textEmail.Location = new System.Drawing.Point(295, 252);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(413, 21);
            this.textEmail.TabIndex = 11;
            this.textEmail.Text = "Email";
            // 
            // textCPF
            // 
            this.textCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCPF.Location = new System.Drawing.Point(295, 297);
            this.textCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(413, 21);
            this.textCPF.TabIndex = 12;
            this.textCPF.Text = "CPF";
            this.textCPF.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textCargo
            // 
            this.textCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCargo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCargo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCargo.Location = new System.Drawing.Point(295, 340);
            this.textCargo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(413, 21);
            this.textCargo.TabIndex = 13;
            this.textCargo.Text = "Cargo";
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textSenha.Location = new System.Drawing.Point(295, 393);
            this.textSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(413, 21);
            this.textSenha.TabIndex = 14;
            this.textSenha.Text = "Senha ";
            this.textSenha.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(295, 406);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(413, 21);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "................................................................................." +
    ".............................";
            this.textBox6.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(383, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cadastrar";
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(945, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textCargo);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textsla);
            this.Controls.Add(this.btnRegistrado);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.text);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txt123);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrar";
            this.Opacity = 0.9D;
            this.Text = "FormCadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt123;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button btnRegistrado;
        private System.Windows.Forms.TextBox textsla;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton bntMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
    }
}