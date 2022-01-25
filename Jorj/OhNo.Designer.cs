namespace Jorj
{
    partial class OhNo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backToWorkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToWorkButton
            // 
            this.backToWorkButton.Location = new System.Drawing.Point(213, 313);
            this.backToWorkButton.Name = "backToWorkButton";
            this.backToWorkButton.Size = new System.Drawing.Size(151, 23);
            this.backToWorkButton.TabIndex = 0;
            this.backToWorkButton.Text = "Guess I\'ll Go Back To Work";
            this.backToWorkButton.UseVisualStyleBackColor = true;
            this.backToWorkButton.Click += new System.EventHandler(this.backToWorkButton_Click);
            // 
            // OhNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jorj.Properties.Resources.oh_no_screen;
            this.Controls.Add(this.backToWorkButton);
            this.Name = "OhNo";
            this.Size = new System.Drawing.Size(567, 383);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToWorkButton;
    }
}
