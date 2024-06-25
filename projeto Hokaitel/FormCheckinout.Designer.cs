namespace projeto_Hokaitel
{
    partial class FormCheckinout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckinout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.btnentrar1 = new System.Windows.Forms.Button();
            this.textCheckin = new System.Windows.Forms.TextBox();
            this.textCheckout = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.bntMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnFechar = new FontAwesome.Sharp.IconButton();
            this.dateTimeCheckin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckuot = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnentrar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNome.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textNome.Location = new System.Drawing.Point(282, 101);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(413, 21);
            this.textNome.TabIndex = 2;
            this.textNome.Text = "................................................................................." +
    "..............";
            // 
            // textCPF
            // 
            this.textCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCPF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCPF.Location = new System.Drawing.Point(282, 145);
            this.textCPF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(413, 21);
            this.textCPF.TabIndex = 3;
            this.textCPF.Text = "................................................................................." +
    "...............";
            // 
            // btnentrar1
            // 
            this.btnentrar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnentrar1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnentrar1.Location = new System.Drawing.Point(29, 404);
            this.btnentrar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnentrar1.Name = "btnentrar1";
            this.btnentrar1.Size = new System.Drawing.Size(148, 33);
            this.btnentrar1.TabIndex = 4;
            this.btnentrar1.Text = "Reservar";
            this.btnentrar1.UseVisualStyleBackColor = true;
            this.btnentrar1.Click += new System.EventHandler(this.btnentrar1_Click);
            // 
            // textCheckin
            // 
            this.textCheckin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textCheckin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCheckin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCheckin.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCheckin.Location = new System.Drawing.Point(282, 311);
            this.textCheckin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCheckin.Name = "textCheckin";
            this.textCheckin.Size = new System.Drawing.Size(413, 21);
            this.textCheckin.TabIndex = 5;
            this.textCheckin.Text = "................................................................................." +
    "....";
            // 
            // textCheckout
            // 
            this.textCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textCheckout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCheckout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCheckout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textCheckout.Location = new System.Drawing.Point(282, 364);
            this.textCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textCheckout.Name = "textCheckout";
            this.textCheckout.Size = new System.Drawing.Size(413, 21);
            this.textCheckout.TabIndex = 6;
            this.textCheckout.Text = "................................................................................." +
    "...........";
            this.textCheckout.TextChanged += new System.EventHandler(this.textCheckout_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(445, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 44);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(324, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clientes/Check-in";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(282, 91);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 21);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Nome";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(282, 134);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(413, 21);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "CPF";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox3.Location = new System.Drawing.Point(282, 299);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 21);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Check-in";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(282, 353);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 21);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Check-out";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            this.bntMinimizar.Location = new System.Drawing.Point(754, 0);
            this.bntMinimizar.Name = "bntMinimizar";
            this.bntMinimizar.Size = new System.Drawing.Size(49, 31);
            this.bntMinimizar.TabIndex = 14;
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
            this.btnFechar.Location = new System.Drawing.Point(809, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 31);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dateTimeCheckin
            // 
            this.dateTimeCheckin.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimeCheckin.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimeCheckin.CalendarTitleBackColor = System.Drawing.SystemColors.MenuText;
            this.dateTimeCheckin.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimeCheckin.CalendarTrailingForeColor = System.Drawing.SystemColors.InfoText;
            this.dateTimeCheckin.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheckin.Location = new System.Drawing.Point(385, 299);
            this.dateTimeCheckin.Name = "dateTimeCheckin";
            this.dateTimeCheckin.Size = new System.Drawing.Size(293, 23);
            this.dateTimeCheckin.TabIndex = 15;
            // 
            // dateTimeCheckuot
            // 
            this.dateTimeCheckuot.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimeCheckuot.CalendarMonthBackground = System.Drawing.SystemColors.ScrollBar;
            this.dateTimeCheckuot.CalendarTitleBackColor = System.Drawing.SystemColors.MenuText;
            this.dateTimeCheckuot.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateTimeCheckuot.CalendarTrailingForeColor = System.Drawing.SystemColors.InfoText;
            this.dateTimeCheckuot.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeCheckuot.Location = new System.Drawing.Point(385, 351);
            this.dateTimeCheckuot.Name = "dateTimeCheckuot";
            this.dateTimeCheckuot.Size = new System.Drawing.Size(293, 23);
            this.dateTimeCheckuot.TabIndex = 16;
            this.dateTimeCheckuot.ValueChanged += new System.EventHandler(this.dateTimeCheckuot_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(282, 173);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(413, 21);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "Telefone";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(282, 183);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(413, 21);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "................................................................................." +
    "..............";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(282, 212);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(413, 21);
            this.textBox7.TabIndex = 20;
            this.textBox7.Text = "Email";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(282, 222);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(413, 21);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "................................................................................." +
    "..............";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox9.Location = new System.Drawing.Point(282, 251);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(413, 21);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "Id Reserva";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.Location = new System.Drawing.Point(282, 261);
            this.textBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(413, 21);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = "................................................................................." +
    "..............";
            // 
            // FormCheckinout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.dateTimeCheckuot);
            this.Controls.Add(this.dateTimeCheckin);
            this.Controls.Add(this.bntMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCheckout);
            this.Controls.Add(this.textCheckin);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckinout";
            this.Opacity = 0.95D;
            this.Text = "FormCheckinout";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Button btnentrar1;
        private System.Windows.Forms.TextBox textCheckin;
        private System.Windows.Forms.TextBox textCheckout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private FontAwesome.Sharp.IconButton bntMinimizar;
        private FontAwesome.Sharp.IconButton btnFechar;
        private System.Windows.Forms.DateTimePicker dateTimeCheckin;
        private System.Windows.Forms.DateTimePicker dateTimeCheckuot;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
    }
}