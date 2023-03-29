namespace diaryProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.nickName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSound = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(137, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nickName
            // 
            this.nickName.Location = new System.Drawing.Point(123, 136);
            this.nickName.Name = "nickName";
            this.nickName.Size = new System.Drawing.Size(215, 26);
            this.nickName.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnOk.Location = new System.Drawing.Point(302, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 59);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Go to entry";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnKill
            // 
            this.btnKill.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnKill.Location = new System.Drawing.Point(172, 198);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(101, 59);
            this.btnKill.TabIndex = 2;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnColor.Location = new System.Drawing.Point(45, 198);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(101, 59);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Change Theme";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSound
            // 
            this.btnSound.Location = new System.Drawing.Point(302, 283);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(101, 59);
            this.btnSound.TabIndex = 3;
            this.btnSound.Text = "Music Player";
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(172, 283);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(101, 59);
            this.btnDate.TabIndex = 4;
            this.btnDate.Text = "Date & Time";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 58);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 367);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.nickName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nickName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSound;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button button2;
    }
}