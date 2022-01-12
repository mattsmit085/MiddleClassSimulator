namespace Jorj
{
    partial class Phone
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
            this.carPicture = new System.Windows.Forms.PictureBox();
            this.PauseEngine = new System.Windows.Forms.Timer(this.components);
            this.balanceLabel = new System.Windows.Forms.Label();
            this.debtLabel = new System.Windows.Forms.Label();
            this.paymentPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // carPicture
            // 
            this.carPicture.BackColor = System.Drawing.Color.Transparent;
            this.carPicture.Image = global::Jorj.Properties.Resources.BUY_CAR___INSUFFICIENT;
            this.carPicture.Location = new System.Drawing.Point(222, 241);
            this.carPicture.Name = "carPicture";
            this.carPicture.Size = new System.Drawing.Size(123, 75);
            this.carPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPicture.TabIndex = 0;
            this.carPicture.TabStop = false;
            this.carPicture.Click += new System.EventHandler(this.carPicture_Click);
            // 
            // PauseEngine
            // 
            this.PauseEngine.Enabled = true;
            this.PauseEngine.Interval = 10;
            this.PauseEngine.Tick += new System.EventHandler(this.PauseEngine_Tick);
            // 
            // balanceLabel
            // 
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.balanceLabel.Location = new System.Drawing.Point(222, 78);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(123, 23);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "BALANCE: ";
            this.balanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debtLabel
            // 
            this.debtLabel.BackColor = System.Drawing.Color.Transparent;
            this.debtLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.debtLabel.Location = new System.Drawing.Point(219, 101);
            this.debtLabel.Name = "debtLabel";
            this.debtLabel.Size = new System.Drawing.Size(123, 23);
            this.debtLabel.TabIndex = 2;
            this.debtLabel.Text = "DEBT:";
            this.debtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentPicture
            // 
            this.paymentPicture.BackColor = System.Drawing.Color.Transparent;
            this.paymentPicture.Image = global::Jorj.Properties.Resources.moneyPNG;
            this.paymentPicture.Location = new System.Drawing.Point(219, 149);
            this.paymentPicture.Name = "paymentPicture";
            this.paymentPicture.Size = new System.Drawing.Size(123, 75);
            this.paymentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paymentPicture.TabIndex = 5;
            this.paymentPicture.TabStop = false;
            this.paymentPicture.Click += new System.EventHandler(this.paymentPicture_Click);
            // 
            // Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Jorj.Properties.Resources.PHONE_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.paymentPicture);
            this.Controls.Add(this.debtLabel);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.carPicture);
            this.DoubleBuffered = true;
            this.Name = "Phone";
            this.Size = new System.Drawing.Size(551, 344);
            this.Load += new System.EventHandler(this.Phone_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Phone_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.carPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox carPicture;
        private System.Windows.Forms.Timer PauseEngine;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label debtLabel;
        private System.Windows.Forms.PictureBox paymentPicture;
    }
}
