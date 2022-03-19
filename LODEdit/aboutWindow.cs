//Generic about window
//Shendo 2009-2012

using System;
using System.Drawing;
using System.Windows.Forms;

namespace LODEdit
{
    public partial class AboutWindow : Form
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        public void InitDialog(string applicationName, string applicationVersion, string supportedGames, string copyrightInfo, string additionalInfo)
        {
            //Set Window title
            Text = @"About";

            //Display program name
            appNameLabel.Text = applicationName;

            //Display program version
            appVersionLabel.Text = @"Version: " + applicationVersion;

            //Display program compile date
            supportedGamesLabel.Text = @"Save editor for " + supportedGames;

            //Display copyright information
            copyrightLabel.Text = copyrightInfo;

            //Display other info
            infoLabel.Text = additionalInfo;

            //Resize dialog according to the quantity of text
            Size = new Size(Size.Width, 132 + infoLabel.Height);

            //Display a dialog
            ShowDialog();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            //Close the form
            Close();
        }

        private void AboutWindow_Paint(object sender, PaintEventArgs e)
        {
            //Draw gray rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80,80,80)), 0, 0, Width, 52);
        }
    }
}
