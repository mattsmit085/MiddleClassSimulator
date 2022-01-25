namespace Jorj
{
    partial class WinScreen
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
            this.WinLabel = new System.Windows.Forms.Label();
            this.ohSickButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WinLabel
            // 
            this.WinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLabel.Location = new System.Drawing.Point(203, 299);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(164, 39);
            this.WinLabel.TabIndex = 0;
            this.WinLabel.Text = "Submit to Capitalism";
            this.WinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WinLabel.Click += new System.EventHandler(this.WinLabel_Click);
            // 
            // ohSickButton
            // 
            this.ohSickButton.AutoSize = true;
            this.ohSickButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ohSickButton.Location = new System.Drawing.Point(85, 338);
            this.ohSickButton.Name = "ohSickButton";
            this.ohSickButton.Size = new System.Drawing.Size(0, 18);
            this.ohSickButton.TabIndex = 2;
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jorj.Properties.Resources.WinScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.ohSickButton);
            this.Controls.Add(this.WinLabel);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(567, 383);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Label ohSickButton;
    }
}
