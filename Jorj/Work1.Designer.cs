namespace Jorj
{
    partial class Work1
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
            this.workTimer = new System.Windows.Forms.Timer(this.components);
            this.georgeLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workTimer
            // 
            this.workTimer.Enabled = true;
            this.workTimer.Tick += new System.EventHandler(this.workTimer_Tick);
            // 
            // georgeLabel
            // 
            this.georgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.georgeLabel.Image = global::Jorj.Properties.Resources.WALK1;
            this.georgeLabel.Location = new System.Drawing.Point(236, 280);
            this.georgeLabel.Name = "georgeLabel";
            this.georgeLabel.Size = new System.Drawing.Size(40, 67);
            this.georgeLabel.TabIndex = 0;
            this.georgeLabel.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.georgeLabel_PreviewKeyDown);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.BackColor = System.Drawing.Color.Transparent;
            this.warningLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.Location = new System.Drawing.Point(4, 4);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(107, 21);
            this.warningLabel.TabIndex = 1;
            this.warningLabel.Text = "WARNINGS: ";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.BackColor = System.Drawing.Color.Transparent;
            this.moneyLabel.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(6, 35);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(97, 21);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "EARNINGS:";
            // 
            // Work1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jorj.Properties.Resources.AWAZONBG;
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.georgeLabel);
            this.DoubleBuffered = true;
            this.Name = "Work1";
            this.Size = new System.Drawing.Size(567, 383);
            this.Load += new System.EventHandler(this.Work1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Work1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Work1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Work1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer workTimer;
        private System.Windows.Forms.Label georgeLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label moneyLabel;
    }
}
