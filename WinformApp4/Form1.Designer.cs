namespace WinFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxByear = new System.Windows.Forms.TextBox();
            this.textBoxGpa = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNameMaxGrade = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMaxGrade = new System.Windows.Forms.Label();
            this.labelMinGrade = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelNameMinGrade = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ชื่อ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "ปีเกิด";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(69, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 33);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxByear
            // 
            this.textBoxByear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxByear.Location = new System.Drawing.Point(69, 51);
            this.textBoxByear.Name = "textBoxByear";
            this.textBoxByear.Size = new System.Drawing.Size(123, 33);
            this.textBoxByear.TabIndex = 4;
            // 
            // textBoxGpa
            // 
            this.textBoxGpa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGpa.Location = new System.Drawing.Point(69, 90);
            this.textBoxGpa.Name = "textBoxGpa";
            this.textBoxGpa.Size = new System.Drawing.Size(123, 33);
            this.textBoxGpa.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Lime;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.Location = new System.Drawing.Point(69, 129);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(123, 41);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "เพิ่มข้อมูล";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "รายชื่อ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "GPA Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(19, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "GPA Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(114, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "อายุรวม";
            // 
            // labelNameMaxGrade
            // 
            this.labelNameMaxGrade.AutoSize = true;
            this.labelNameMaxGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameMaxGrade.Location = new System.Drawing.Point(64, 68);
            this.labelNameMaxGrade.Name = "labelNameMaxGrade";
            this.labelNameMaxGrade.Size = new System.Drawing.Size(0, 25);
            this.labelNameMaxGrade.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(110, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "เกรด";
            // 
            // labelMaxGrade
            // 
            this.labelMaxGrade.AutoSize = true;
            this.labelMaxGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxGrade.Location = new System.Drawing.Point(163, 29);
            this.labelMaxGrade.Name = "labelMaxGrade";
            this.labelMaxGrade.Size = new System.Drawing.Size(0, 25);
            this.labelMaxGrade.TabIndex = 14;
            // 
            // labelMinGrade
            // 
            this.labelMinGrade.AutoSize = true;
            this.labelMinGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinGrade.Location = new System.Drawing.Point(162, 117);
            this.labelMinGrade.Name = "labelMinGrade";
            this.labelMinGrade.Size = new System.Drawing.Size(0, 25);
            this.labelMinGrade.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(110, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "เกรด";
            // 
            // labelNameMinGrade
            // 
            this.labelNameMinGrade.AutoSize = true;
            this.labelNameMinGrade.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameMinGrade.Location = new System.Drawing.Point(64, 158);
            this.labelNameMinGrade.Name = "labelNameMinGrade";
            this.labelNameMinGrade.Size = new System.Drawing.Size(0, 25);
            this.labelNameMinGrade.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(19, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 30);
            this.label15.TabIndex = 18;
            this.label15.Text = "ชื่อ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(19, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 30);
            this.label16.TabIndex = 19;
            this.label16.Text = "ชื่อ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(184, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 21);
            this.label17.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelMinGrade);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.labelMaxGrade);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labelNameMaxGrade);
            this.groupBox1.Controls.Add(this.labelNameMinGrade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(198, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 443);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลรายวิชา";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 455);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxGpa);
            this.Controls.Add(this.textBoxByear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxByear;
        private TextBox textBoxGpa;
        private Button buttonAdd;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelNameMaxGrade;
        private Label label10;
        private Label labelMaxGrade;
        private Label labelMinGrade;
        private Label label13;
        private Label labelNameMinGrade;
        private Label label15;
        private Label label16;
        private Label label17;
        private GroupBox groupBox1;
    }
}