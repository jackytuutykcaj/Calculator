namespace lab3
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
            this.labelHelpText = new System.Windows.Forms.Label();
            this.labelHelpTitle = new System.Windows.Forms.Label();
            this.buttonExitHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHelpText
            // 
            this.labelHelpText.AutoSize = true;
            this.labelHelpText.Location = new System.Drawing.Point(23, 49);
            this.labelHelpText.MaximumSize = new System.Drawing.Size(200, 0);
            this.labelHelpText.Name = "labelHelpText";
            this.labelHelpText.Size = new System.Drawing.Size(135, 13);
            this.labelHelpText.TabIndex = 0;
            this.labelHelpText.Text = "Replaces when form loads.";
            // 
            // labelHelpTitle
            // 
            this.labelHelpTitle.AutoSize = true;
            this.labelHelpTitle.Location = new System.Drawing.Point(58, 13);
            this.labelHelpTitle.Name = "labelHelpTitle";
            this.labelHelpTitle.Size = new System.Drawing.Size(125, 13);
            this.labelHelpTitle.TabIndex = 1;
            this.labelHelpTitle.Text = "How to use a calculator?";
            // 
            // buttonExitHelp
            // 
            this.buttonExitHelp.Location = new System.Drawing.Point(87, 355);
            this.buttonExitHelp.Name = "buttonExitHelp";
            this.buttonExitHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonExitHelp.TabIndex = 2;
            this.buttonExitHelp.Text = "Exit";
            this.buttonExitHelp.UseVisualStyleBackColor = true;
            this.buttonExitHelp.Click += new System.EventHandler(this.buttonExitHelp_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 390);
            this.Controls.Add(this.buttonExitHelp);
            this.Controls.Add(this.labelHelpTitle);
            this.Controls.Add(this.labelHelpText);
            this.Name = "Form2";
            this.Text = "Help";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelpText;
        private System.Windows.Forms.Label labelHelpTitle;
        private System.Windows.Forms.Button buttonExitHelp;
    }
}