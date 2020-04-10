namespace GeneralStore
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.Passwordtxtbox = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // idtxtbox
            // 
            this.idtxtbox.Location = new System.Drawing.Point(112, 21);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.Size = new System.Drawing.Size(100, 20);
            this.idtxtbox.TabIndex = 2;
            // 
            // Passwordtxtbox
            // 
            this.Passwordtxtbox.Location = new System.Drawing.Point(112, 62);
            this.Passwordtxtbox.Name = "Passwordtxtbox";
            this.Passwordtxtbox.PasswordChar = '*';
            this.Passwordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.Passwordtxtbox.TabIndex = 3;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.login.Location = new System.Drawing.Point(21, 118);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.main.Location = new System.Drawing.Point(183, 117);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(75, 23);
            this.main.TabIndex = 5;
            this.main.Text = "Main Menu";
            this.main.UseVisualStyleBackColor = false;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.main);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.Passwordtxtbox);
            this.groupBox1.Controls.Add(this.idtxtbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 169);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salesman Login";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(337, 221);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idtxtbox;
        private System.Windows.Forms.TextBox Passwordtxtbox;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button main;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}