namespace Final_Project
{
    partial class DataInfor
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fFrom = new System.Windows.Forms.TextBox();
            this.fTo = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fDiv = new System.Windows.Forms.TextBox();
            this.fList = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.fType = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(241, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(31, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên trường nhạy cảm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(31, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miền giá trị (Chỉ điền 1 trong 2 mục):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(363, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(205, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(369, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đến";
            // 
            // fFrom
            // 
            this.fFrom.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fFrom.ForeColor = System.Drawing.Color.Navy;
            this.fFrom.Location = new System.Drawing.Point(252, 269);
            this.fFrom.Name = "fFrom";
            this.fFrom.Size = new System.Drawing.Size(100, 36);
            this.fFrom.TabIndex = 8;
            this.fFrom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fTo
            // 
            this.fTo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fTo.ForeColor = System.Drawing.Color.Navy;
            this.fTo.Location = new System.Drawing.Point(430, 269);
            this.fTo.Name = "fTo";
            this.fTo.Size = new System.Drawing.Size(100, 36);
            this.fTo.TabIndex = 9;
            this.fTo.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fName
            // 
            this.fName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fName.ForeColor = System.Drawing.Color.Navy;
            this.fName.Location = new System.Drawing.Point(288, 153);
            this.fName.Multiline = true;
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(497, 29);
            this.fName.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(552, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "Khoảng chia:";
            // 
            // fDiv
            // 
            this.fDiv.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fDiv.ForeColor = System.Drawing.Color.Navy;
            this.fDiv.Location = new System.Drawing.Point(704, 269);
            this.fDiv.Name = "fDiv";
            this.fDiv.Size = new System.Drawing.Size(81, 36);
            this.fDiv.TabIndex = 15;
            this.fDiv.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // fList
            // 
            this.fList.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fList.ForeColor = System.Drawing.Color.Navy;
            this.fList.Location = new System.Drawing.Point(210, 344);
            this.fList.Multiline = true;
            this.fList.Name = "fList";
            this.fList.Size = new System.Drawing.Size(575, 102);
            this.fList.TabIndex = 19;
            this.fList.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(36, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 29);
            this.label12.TabIndex = 18;
            this.label12.Text = "Liệt kê giá trị:";
            // 
            // fType
            // 
            this.fType.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fType.ForeColor = System.Drawing.Color.Navy;
            this.fType.FormattingEnabled = true;
            this.fType.Items.AddRange(new object[] {
            "Range",
            "First Letter",
            "Last Letter",
            "List"});
            this.fType.Location = new System.Drawing.Point(36, 268);
            this.fType.Name = "fType";
            this.fType.Size = new System.Drawing.Size(156, 37);
            this.fType.TabIndex = 21;
            this.fType.Text = "Miền giá trị";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(530, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 37);
            this.button3.TabIndex = 22;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(667, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fType);
            this.Controls.Add(this.fList);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.fDiv);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.fTo);
            this.Controls.Add(this.fFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DataInfor";
            this.Text = "DataInfor";
            this.Load += new System.EventHandler(this.DataInfor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fFrom;
        private System.Windows.Forms.TextBox fTo;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fDiv;
        private System.Windows.Forms.TextBox fList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox fType;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}