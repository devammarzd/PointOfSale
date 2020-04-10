namespace GeneralStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Donetxtbox = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tempcosttxtbox = new System.Windows.Forms.TextBox();
            this.Reciept = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.barcodetxtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Counter = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Donetxtbox
            // 
            this.Donetxtbox.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Donetxtbox.Location = new System.Drawing.Point(326, 78);
            this.Donetxtbox.Name = "Donetxtbox";
            this.Donetxtbox.Size = new System.Drawing.Size(75, 23);
            this.Donetxtbox.TabIndex = 3;
            this.Donetxtbox.Text = "Done";
            this.Donetxtbox.UseVisualStyleBackColor = false;
            this.Donetxtbox.Click += new System.EventHandler(this.Donetxtbox_Click);
            // 
            // Item
            // 
            this.Item.Location = new System.Drawing.Point(95, 81);
            this.Item.Multiline = true;
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(168, 20);
            this.Item.TabIndex = 1;
            this.Item.TextChanged += new System.EventHandler(this.Item_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(284, 81);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(36, 20);
            this.Quantity.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Item";
            // 
            // tempcosttxtbox
            // 
            this.tempcosttxtbox.Location = new System.Drawing.Point(288, 332);
            this.tempcosttxtbox.Multiline = true;
            this.tempcosttxtbox.Name = "tempcosttxtbox";
            this.tempcosttxtbox.Size = new System.Drawing.Size(77, 32);
            this.tempcosttxtbox.TabIndex = 4;
            // 
            // Reciept
            // 
            this.Reciept.Image = ((System.Drawing.Image)(resources.GetObject("Reciept.Image")));
            this.Reciept.Location = new System.Drawing.Point(285, 370);
            this.Reciept.Name = "Reciept";
            this.Reciept.Size = new System.Drawing.Size(80, 57);
            this.Reciept.TabIndex = 4;
            this.Reciept.Text = "Reciept";
            this.Reciept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Reciept.UseVisualStyleBackColor = true;
            this.Reciept.Click += new System.EventHandler(this.Reciept_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 173);
            this.listBox1.TabIndex = 80;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(227, 139);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(62, 173);
            this.listBox2.TabIndex = 14;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(285, 139);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(80, 173);
            this.listBox3.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(285, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 21;
            this.label12.Text = "Amount(Rs.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(224, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Items Purchased";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(161, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Amount(Rs.)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Qty.";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(21, 450);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Log Out";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(288, 450);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(77, 23);
            this.RESET.TabIndex = 5;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(157, 139);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(73, 173);
            this.listBox4.TabIndex = 25;
            // 
            // dataGrid1
            // 
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(407, 56);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(261, 417);
            this.dataGrid1.TabIndex = 28;
            // 
            // barcodetxtbox
            // 
            this.barcodetxtbox.Location = new System.Drawing.Point(21, 81);
            this.barcodetxtbox.Name = "barcodetxtbox";
            this.barcodetxtbox.Size = new System.Drawing.Size(55, 20);
            this.barcodetxtbox.TabIndex = 1;
            this.barcodetxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cost/Item";
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.Location = new System.Drawing.Point(404, 21);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(0, 23);
            this.Counter.TabIndex = 34;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(20, 21);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(43, 16);
            this.username.TabIndex = 35;
            this.username.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(713, 487);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodetxtbox);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.Reciept);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.tempcosttxtbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Donetxtbox);
            this.Name = "Form1";
            this.Text = "Point Of Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Donetxtbox;
        private System.Windows.Forms.TextBox Item;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tempcosttxtbox;
        private System.Windows.Forms.Button Reciept;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.TextBox barcodetxtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Label username;
    }
}

