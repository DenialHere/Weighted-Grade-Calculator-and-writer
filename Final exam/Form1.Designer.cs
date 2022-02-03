namespace Final_exam
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_session = new System.Windows.Forms.ComboBox();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_midTerm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_project = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_letterGrade = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_finalPercentage = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ProjectPercentage = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_midTermPercentage = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_writeText = new System.Windows.Forms.Button();
            this.btn_writeXml = new System.Windows.Forms.Button();
            this.btn_readXml = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(270, 62);
            this.txt_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(1226, 39);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Enter your name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course Number:";
            // 
            // txt_course
            // 
            this.txt_course.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_course.Location = new System.Drawing.Point(270, 152);
            this.txt_course.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_course.Name = "txt_course";
            this.txt_course.Size = new System.Drawing.Size(234, 39);
            this.txt_course.TabIndex = 3;
            this.txt_course.Text = "420-???-AS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Session:";
            // 
            // txt_session
            // 
            this.txt_session.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_session.FormattingEnabled = true;
            this.txt_session.Items.AddRange(new object[] {
            "Summer",
            "Fall",
            "Winter"});
            this.txt_session.Location = new System.Drawing.Point(796, 152);
            this.txt_session.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_session.Name = "txt_session";
            this.txt_session.Size = new System.Drawing.Size(238, 37);
            this.txt_session.TabIndex = 6;
            this.txt_session.Text = "Winter";
            // 
            // txt_year
            // 
            this.txt_year.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_year.Location = new System.Drawing.Point(1262, 150);
            this.txt_year.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(234, 39);
            this.txt_year.TabIndex = 8;
            this.txt_year.Text = "2020";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1168, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year:";
            // 
            // txt_midTerm
            // 
            this.txt_midTerm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_midTerm.Location = new System.Drawing.Point(66, 356);
            this.txt_midTerm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_midTerm.Name = "txt_midTerm";
            this.txt_midTerm.Size = new System.Drawing.Size(228, 39);
            this.txt_midTerm.TabIndex = 10;
            this.txt_midTerm.Text = "0";
            this.txt_midTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mid term:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 425);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "0 to 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "0 to 100";
            // 
            // txt_project
            // 
            this.txt_project.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_project.Location = new System.Drawing.Point(466, 356);
            this.txt_project.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(228, 39);
            this.txt_project.TabIndex = 14;
            this.txt_project.Text = "0";
            this.txt_project.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 290);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 39);
            this.label8.TabIndex = 13;
            this.label8.Text = "Project:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(936, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "0 to 100";
            // 
            // txt_final
            // 
            this.txt_final.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_final.Location = new System.Drawing.Point(876, 356);
            this.txt_final.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(228, 39);
            this.txt_final.TabIndex = 17;
            this.txt_final.Text = "0";
            this.txt_final.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(934, 290);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 39);
            this.label10.TabIndex = 16;
            this.label10.Text = "Final:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1328, 425);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "0 to 100";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(1268, 356);
            this.txt_total.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(228, 39);
            this.txt_total.TabIndex = 20;
            this.txt_total.TabStop = false;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1342, 290);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 39);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1306, 577);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 32);
            this.label13.TabIndex = 29;
            this.label13.Text = "A,B,C,D or F";
            // 
            // txt_letterGrade
            // 
            this.txt_letterGrade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_letterGrade.Location = new System.Drawing.Point(1268, 508);
            this.txt_letterGrade.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_letterGrade.Name = "txt_letterGrade";
            this.txt_letterGrade.ReadOnly = true;
            this.txt_letterGrade.Size = new System.Drawing.Size(228, 39);
            this.txt_letterGrade.TabIndex = 28;
            this.txt_letterGrade.TabStop = false;
            this.txt_letterGrade.Text = "0";
            this.txt_letterGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(936, 577);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 32);
            this.label14.TabIndex = 27;
            this.label14.Text = "0 to 40%";
            // 
            // txt_finalPercentage
            // 
            this.txt_finalPercentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_finalPercentage.Location = new System.Drawing.Point(876, 508);
            this.txt_finalPercentage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_finalPercentage.Name = "txt_finalPercentage";
            this.txt_finalPercentage.ReadOnly = true;
            this.txt_finalPercentage.Size = new System.Drawing.Size(228, 39);
            this.txt_finalPercentage.TabIndex = 26;
            this.txt_finalPercentage.TabStop = false;
            this.txt_finalPercentage.Text = "0";
            this.txt_finalPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(526, 577);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 32);
            this.label15.TabIndex = 25;
            this.label15.Text = "0 to 30%";
            // 
            // txt_ProjectPercentage
            // 
            this.txt_ProjectPercentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProjectPercentage.Location = new System.Drawing.Point(466, 508);
            this.txt_ProjectPercentage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_ProjectPercentage.Name = "txt_ProjectPercentage";
            this.txt_ProjectPercentage.ReadOnly = true;
            this.txt_ProjectPercentage.Size = new System.Drawing.Size(228, 39);
            this.txt_ProjectPercentage.TabIndex = 24;
            this.txt_ProjectPercentage.TabStop = false;
            this.txt_ProjectPercentage.Text = "0";
            this.txt_ProjectPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(126, 577);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 32);
            this.label16.TabIndex = 23;
            this.label16.Text = "0 to 30%";
            // 
            // txt_midTermPercentage
            // 
            this.txt_midTermPercentage.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_midTermPercentage.Location = new System.Drawing.Point(66, 508);
            this.txt_midTermPercentage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_midTermPercentage.Name = "txt_midTermPercentage";
            this.txt_midTermPercentage.ReadOnly = true;
            this.txt_midTermPercentage.Size = new System.Drawing.Size(228, 39);
            this.txt_midTermPercentage.TabIndex = 22;
            this.txt_midTermPercentage.TabStop = false;
            this.txt_midTermPercentage.Text = "0";
            this.txt_midTermPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1280, 625);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 32);
            this.label17.TabIndex = 30;
            this.label17.Text = "60-100% to pass";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(40, 663);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(284, 154);
            this.btn_calculate.TabIndex = 31;
            this.btn_calculate.Text = "&Validate - Calculate Data";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_writeText
            // 
            this.btn_writeText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_writeText.Location = new System.Drawing.Point(422, 663);
            this.btn_writeText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_writeText.Name = "btn_writeText";
            this.btn_writeText.Size = new System.Drawing.Size(304, 154);
            this.btn_writeText.TabIndex = 32;
            this.btn_writeText.Text = "&Write/Add Student data into a textfile";
            this.btn_writeText.UseVisualStyleBackColor = true;
            this.btn_writeText.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_writeXml
            // 
            this.btn_writeXml.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_writeXml.Location = new System.Drawing.Point(796, 663);
            this.btn_writeXml.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_writeXml.Name = "btn_writeXml";
            this.btn_writeXml.Size = new System.Drawing.Size(194, 154);
            this.btn_writeXml.TabIndex = 33;
            this.btn_writeXml.Text = "&Create/add XML file";
            this.btn_writeXml.UseVisualStyleBackColor = true;
            this.btn_writeXml.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_readXml
            // 
            this.btn_readXml.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_readXml.Location = new System.Drawing.Point(1002, 663);
            this.btn_readXml.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_readXml.Name = "btn_readXml";
            this.btn_readXml.Size = new System.Drawing.Size(194, 154);
            this.btn_readXml.TabIndex = 34;
            this.btn_readXml.Text = "&Read XML file";
            this.btn_readXml.UseVisualStyleBackColor = true;
            this.btn_readXml.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(1268, 769);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(232, 48);
            this.btn_exit.TabIndex = 35;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 787);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_readXml);
            this.Controls.Add(this.btn_writeXml);
            this.Controls.Add(this.btn_writeText);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_letterGrade);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_finalPercentage);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_ProjectPercentage);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_midTermPercentage);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_project);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_midTerm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_session);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_course);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1530, 858);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danial Gosse - 1912983";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_session;
        private System.Windows.Forms.TextBox txt_year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_midTerm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_project;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_letterGrade;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_finalPercentage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ProjectPercentage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_midTermPercentage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_writeText;
        private System.Windows.Forms.Button btn_writeXml;
        private System.Windows.Forms.Button btn_readXml;
        private System.Windows.Forms.Button btn_exit;
    }
}

