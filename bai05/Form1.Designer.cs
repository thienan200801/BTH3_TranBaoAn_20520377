namespace bai05
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
            this.label2 = new System.Windows.Forms.Label();
            this.no1 = new System.Windows.Forms.TextBox();
            this.no2 = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ans = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // no1
            // 
            this.no1.Location = new System.Drawing.Point(252, 53);
            this.no1.Name = "no1";
            this.no1.Size = new System.Drawing.Size(356, 22);
            this.no1.TabIndex = 2;
            // 
            // no2
            // 
            this.no2.Location = new System.Drawing.Point(254, 109);
            this.no2.Name = "no2";
            this.no2.Size = new System.Drawing.Size(356, 22);
            this.no2.TabIndex = 3;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(169, 203);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(76, 68);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(288, 203);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(76, 68);
            this.minus.TabIndex = 5;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(406, 203);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(76, 68);
            this.times.TabIndex = 6;
            this.times.Text = "x";
            this.times.UseVisualStyleBackColor = true;
            this.times.Click += new System.EventHandler(this.times_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(532, 203);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(76, 68);
            this.divide.TabIndex = 7;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Answer";
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(239, 322);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(370, 22);
            this.ans.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.times);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.no2);
            this.Controls.Add(this.no1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox no1;
        private System.Windows.Forms.TextBox no2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ans;
    }
}

