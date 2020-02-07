using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurePlease.UserControls
{
    public partial class PlayerInfoUserControl : UserControl
    {
        public PlayerInfoUserControl()
        {
            InitializeComponent();
        }

        private void PlayerAutoBuffsButton_Click(object sender, EventArgs e)
        {
            PlayerAutoBuffMenuStrip.Show(this, new Point(this.Width, 0));
        }
    }
}
