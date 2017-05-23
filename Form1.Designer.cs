namespace Clicker
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.millisecondsBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpsLabel = new System.Windows.Forms.Label();
            this.leftCheck = new System.Windows.Forms.CheckBox();
            this.rightCheck = new System.Windows.Forms.CheckBox();
            this.iterations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.infinityIt = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Stop (ALT)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // secondsBox
            // 
            this.secondsBox.Location = new System.Drawing.Point(93, 229);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(42, 20);
            this.secondsBox.TabIndex = 16;
            this.secondsBox.Text = "0";
            this.secondsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.secondsBox.TextChanged += new System.EventHandler(this.secondsBox_TextChanged);
            // 
            // millisecondsBox
            // 
            this.millisecondsBox.Location = new System.Drawing.Point(148, 229);
            this.millisecondsBox.Name = "millisecondsBox";
            this.millisecondsBox.Size = new System.Drawing.Size(50, 20);
            this.millisecondsBox.TabIndex = 15;
            this.millisecondsBox.Text = "0";
            this.millisecondsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.millisecondsBox.TextChanged += new System.EventHandler(this.millisecondsBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(111, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 59);
            this.button3.TabIndex = 4;
            this.button3.Text = "CPS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Milliseconds";
            // 
            // cpsLabel
            // 
            this.cpsLabel.AutoSize = true;
            this.cpsLabel.Location = new System.Drawing.Point(126, 74);
            this.cpsLabel.Name = "cpsLabel";
            this.cpsLabel.Size = new System.Drawing.Size(13, 13);
            this.cpsLabel.TabIndex = 7;
            this.cpsLabel.Text = "0";
            // 
            // leftCheck
            // 
            this.leftCheck.AutoSize = true;
            this.leftCheck.Checked = true;
            this.leftCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftCheck.Location = new System.Drawing.Point(204, 103);
            this.leftCheck.Name = "leftCheck";
            this.leftCheck.Size = new System.Drawing.Size(70, 17);
            this.leftCheck.TabIndex = 8;
            this.leftCheck.Text = "Left Click";
            this.leftCheck.UseVisualStyleBackColor = true;
            this.leftCheck.CheckedChanged += new System.EventHandler(this.leftCheck_CheckedChanged);
            // 
            // rightCheck
            // 
            this.rightCheck.AutoSize = true;
            this.rightCheck.Location = new System.Drawing.Point(204, 126);
            this.rightCheck.Name = "rightCheck";
            this.rightCheck.Size = new System.Drawing.Size(77, 17);
            this.rightCheck.TabIndex = 9;
            this.rightCheck.Text = "Right Click";
            this.rightCheck.UseVisualStyleBackColor = true;
            this.rightCheck.CheckedChanged += new System.EventHandler(this.rightCheck_CheckedChanged);
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(12, 117);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(100, 20);
            this.iterations.TabIndex = 14;
            this.iterations.Text = "0";
            this.iterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.iterations.TextChanged += new System.EventHandler(this.iterations_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Iterations";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Location = new System.Drawing.Point(126, 87);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(13, 13);
            this.iterationsLabel.TabIndex = 12;
            this.iterationsLabel.Text = "0";
            // 
            // infinityIt
            // 
            this.infinityIt.AutoSize = true;
            this.infinityIt.Location = new System.Drawing.Point(12, 143);
            this.infinityIt.Name = "infinityIt";
            this.infinityIt.Size = new System.Drawing.Size(109, 17);
            this.infinityIt.TabIndex = 13;
            this.infinityIt.Text = "Infinite Iterations?";
            this.infinityIt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 39);
            this.label4.TabIndex = 17;
            this.label4.Text = "Run as Admin\r\nto use in your\r\napplications :)\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infinityIt);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iterations);
            this.Controls.Add(this.rightCheck);
            this.Controls.Add(this.leftCheck);
            this.Controls.Add(this.cpsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.millisecondsBox);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox secondsBox;
        private System.Windows.Forms.TextBox millisecondsBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cpsLabel;
        private System.Windows.Forms.CheckBox leftCheck;
        private System.Windows.Forms.CheckBox rightCheck;
        private System.Windows.Forms.TextBox iterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label iterationsLabel;
        private System.Windows.Forms.CheckBox infinityIt;
        private System.Windows.Forms.Label label4;
    }
}

