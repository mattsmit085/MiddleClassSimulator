namespace Jorj
{
    partial class Driving
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
            this.components = new System.ComponentModel.Container();
            this.driveBox = new System.Windows.Forms.PictureBox();
            this.driveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.driveBox)).BeginInit();
            this.SuspendLayout();
            // 
            // driveBox
            // 
            this.driveBox.Image = global::Jorj.Properties.Resources.d__1_;
            this.driveBox.Location = new System.Drawing.Point(0, 0);
            this.driveBox.Name = "driveBox";
            this.driveBox.Size = new System.Drawing.Size(551, 344);
            this.driveBox.TabIndex = 0;
            this.driveBox.TabStop = false;
            // 
            // driveTimer
            // 
            this.driveTimer.Enabled = true;
            this.driveTimer.Tick += new System.EventHandler(this.driveTimer_Tick);
            // 
            // Driving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.driveBox);
            this.DoubleBuffered = true;
            this.Name = "Driving";
            this.Size = new System.Drawing.Size(551, 344);
            ((System.ComponentModel.ISupportInitialize)(this.driveBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox driveBox;
        private System.Windows.Forms.Timer driveTimer;
    }
}
