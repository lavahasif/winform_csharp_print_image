namespace print
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
            this.button3 = new System.Windows.Forms.Button();
            this.txt_left = new System.Windows.Forms.TextBox();
            this.txt_top = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(109, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 52);
            this.button3.TabIndex = 0;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txt_left
            // 
            this.txt_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_left.Location = new System.Drawing.Point(109, 76);
            this.txt_left.Multiline = true;
            this.txt_left.Name = "txt_left";
            this.txt_left.Size = new System.Drawing.Size(456, 43);
            this.txt_left.TabIndex = 1;
            this.txt_left.Text = "100";
            this.txt_left.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_top
            // 
            this.txt_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_top.Location = new System.Drawing.Point(109, 134);
            this.txt_top.Multiline = true;
            this.txt_top.Name = "txt_top";
            this.txt_top.Size = new System.Drawing.Size(456, 43);
            this.txt_top.TabIndex = 1;
            this.txt_top.Text = "100";
            this.txt_top.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_top);
            this.Controls.Add(this.txt_left);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_left;
        private System.Windows.Forms.TextBox txt_top;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;

        #endregion
    }
}