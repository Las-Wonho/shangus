namespace CodeFight
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.user1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.languege = new System.Windows.Forms.ComboBox();
            this.giveup = new System.Windows.Forms.Button();
            this.compileButton = new System.Windows.Forms.Button();
            this.compilerResultBox = new System.Windows.Forms.TextBox();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.user2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 442);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("경기천년제목 Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(458, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "매칭중";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(587, 354);
            this.textBox1.TabIndex = 2;
            // 
            // user1
            // 
            this.user1.AutoSize = true;
            this.user1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user1.Location = new System.Drawing.Point(545, 32);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(79, 26);
            this.user1.TabIndex = 3;
            this.user1.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.languege);
            this.panel1.Controls.Add(this.giveup);
            this.panel1.Controls.Add(this.compileButton);
            this.panel1.Controls.Add(this.compilerResultBox);
            this.panel1.Controls.Add(this.questionBox);
            this.panel1.Controls.Add(this.user2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.user1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 548);
            this.panel1.TabIndex = 4;
            // 
            // languege
            // 
            this.languege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languege.FormattingEnabled = true;
            this.languege.Items.AddRange(new object[] {
            "C",
            "C++",
            "Java",
            "Python2",
            "Python3"});
            this.languege.Location = new System.Drawing.Point(37, 32);
            this.languege.Name = "languege";
            this.languege.Size = new System.Drawing.Size(121, 20);
            this.languege.TabIndex = 9;
            // 
            // giveup
            // 
            this.giveup.Location = new System.Drawing.Point(876, 12);
            this.giveup.Name = "giveup";
            this.giveup.Size = new System.Drawing.Size(75, 23);
            this.giveup.TabIndex = 8;
            this.giveup.Text = "포기";
            this.giveup.UseVisualStyleBackColor = true;
            this.giveup.Click += new System.EventHandler(this.giveup_Click);
            // 
            // compileButton
            // 
            this.compileButton.Font = new System.Drawing.Font("나눔스퀘어", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.compileButton.Location = new System.Drawing.Point(665, 448);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(239, 70);
            this.compileButton.TabIndex = 7;
            this.compileButton.Text = "컴파일";
            this.compileButton.UseVisualStyleBackColor = true;
            this.compileButton.Click += new System.EventHandler(this.compileButton_ClickAsync);
            // 
            // compilerResultBox
            // 
            this.compilerResultBox.Location = new System.Drawing.Point(37, 448);
            this.compilerResultBox.Multiline = true;
            this.compilerResultBox.Name = "compilerResultBox";
            this.compilerResultBox.ReadOnly = true;
            this.compilerResultBox.Size = new System.Drawing.Size(587, 70);
            this.compilerResultBox.TabIndex = 6;
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(665, 77);
            this.questionBox.Multiline = true;
            this.questionBox.Name = "questionBox";
            this.questionBox.ReadOnly = true;
            this.questionBox.Size = new System.Drawing.Size(239, 354);
            this.questionBox.TabIndex = 5;
            // 
            // user2
            // 
            this.user2.AutoSize = true;
            this.user2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user2.Location = new System.Drawing.Point(314, 32);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(79, 26);
            this.user2.TabIndex = 4;
            this.user2.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label user1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user2;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.Button giveup;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.TextBox compilerResultBox;
        private System.Windows.Forms.ComboBox languege;
    }
}