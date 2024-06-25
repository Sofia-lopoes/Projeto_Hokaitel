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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.btnRegistrado = new System.Windows.Forms.Button();
            this.textSetor = new System.Windows.Forms.TextBox();
            this.bntMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
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
            this.panel1.Size = new System.Drawing.Size(616, 70);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(207, -48);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 166);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textNome.Location = new System.Drawing.Point(81, 125);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(413, 21);
            this.textNome.TabIndex = 3;
            this.textNome.Text = "Nome";
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textEmail.Location = new System.Drawing.Point(81, 170);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(413, 21);
            this.textEmail.TabIndex = 4;
            this.textEmail.Text = "Email";
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textSenha
            // 
            this.textSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSenha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenha.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textSenha.Location = new System.Drawing.Point(81, 269);
            this.textSenha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(413, 21);
            this.textSenha.TabIndex = 5;
            this.textSenha.Text = "Senha ";
            this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // textCPF
            // 
            this.textCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCPF.Location = new System.Drawing.Point(81, 219);
            this.textCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(413, 21);
            this.textCPF.TabIndex = 6;
            this.textCPF.Text = "CPF";
            this.textCPF.TextChanged += new System.EventHandler(this.textCPF_TextChanged);
            // 
            // btnRegistrado
            // 
            this.btnRegistrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRegistrado.Location = new System.Drawing.Point(65, 357);
            this.btnRegistrado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistrado.Name = "btnRegistrado";
            this.btnRegistrado.Size = new System.Drawing.Size(413, 43);
            this.btnRegistrado.TabIndex = 7;
            this.btnRegistrado.Text = "Registrado";
            this.btnRegistrado.UseVisualStyleBackColor = true;
            // 
            // textSetor
            // 
            this.textSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textSetor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSetor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSetor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textSetor.Location = new System.Drawing.Point(81, 314);
            this.textSetor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSetor.Name = "textSetor";
            this.textSetor.Size = new System.Drawing.Size(413, 21);
            this.textSetor.TabIndex = 9;
            this.textSetor.Text = "Setor";
            this.textSetor.TextChanged += new System.EventHandler(this.textSetor_TextChanged);
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
            this.bntMinimizar.Location = new System.Drawing.Point(512, 0);
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
            this.btnFechar.Location = new System.Drawing.Point(567, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 31);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.textSetor);
            this.Controls.Add(this.btnRegistrado);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
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
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Button btnRegistrado;
        private System.Windows.Forms.TextBox textSetor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton bntMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
    }
}