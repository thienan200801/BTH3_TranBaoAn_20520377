namespace Bai03
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
            this.changeColorBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeColorBtn
            // 
            this.changeColorBtn.Location = new System.Drawing.Point(311, 154);
            this.changeColorBtn.Name = "changeColorBtn";
            this.changeColorBtn.Size = new System.Drawing.Size(176, 104);
            this.changeColorBtn.TabIndex = 0;
            this.changeColorBtn.Text = "Change Color";
            this.changeColorBtn.UseVisualStyleBackColor = true;
            this.changeColorBtn.Click += new System.EventHandler(this.changeColorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeColorBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeColorBtn;
    }
}

