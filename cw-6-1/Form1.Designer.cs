namespace cw_6_1
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
            this.EnterText = new System.Windows.Forms.TextBox();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterText
            // 
            this.EnterText.Location = new System.Drawing.Point(279, 215);
            this.EnterText.Name = "EnterText";
            this.EnterText.Size = new System.Drawing.Size(205, 20);
            this.EnterText.TabIndex = 0;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(745, 215);
            this.ResultText.Name = "ResultText";
            this.ResultText.Size = new System.Drawing.Size(272, 20);
            this.ResultText.TabIndex = 1;
            this.ResultText.TextChanged += new System.EventHandler(this.ResultText_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "ToBinary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.EnterText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnterText;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button button1;
    }
}

