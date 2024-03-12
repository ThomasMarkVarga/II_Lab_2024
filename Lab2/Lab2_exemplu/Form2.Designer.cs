namespace Lab2_exemplu
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
            this.exitForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitForm2
            // 
            this.exitForm2.Location = new System.Drawing.Point(364, 183);
            this.exitForm2.Name = "exitForm2";
            this.exitForm2.Size = new System.Drawing.Size(75, 23);
            this.exitForm2.TabIndex = 0;
            this.exitForm2.Text = "Exit";
            this.exitForm2.UseVisualStyleBackColor = true;
            this.exitForm2.Click += new System.EventHandler(this.exitForm2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitForm2;
    }
}