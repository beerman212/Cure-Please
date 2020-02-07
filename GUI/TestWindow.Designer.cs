namespace CurePlease.GUI
{
    partial class TestWindow
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
            this.playerInfoUserControl1 = new CurePlease.UserControls.PlayerInfoUserControl();
            this.SuspendLayout();
            // 
            // playerInfoUserControl1
            // 
            this.playerInfoUserControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playerInfoUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerInfoUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerInfoUserControl1.Location = new System.Drawing.Point(68, 60);
            this.playerInfoUserControl1.Name = "playerInfoUserControl1";
            this.playerInfoUserControl1.Size = new System.Drawing.Size(602, 49);
            this.playerInfoUserControl1.TabIndex = 0;
            // 
            // TestWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 401);
            this.Controls.Add(this.playerInfoUserControl1);
            this.Name = "TestWindow";
            this.Text = "TestWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.PlayerInfoUserControl playerInfoUserControl1;
    }
}