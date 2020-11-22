using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LODEdit
{
    public partial class mainWindow : Form
    {
        //Flag for the return value
        private bool confirmedFlag = false;
        
        //A flag for the first run
        private bool firstRun = true;

        //Currently edited slot
        private int currentSaveSlot = 0;

        //A data to edit
        private SaveData saveData = null;

        public mainWindow()
        {
            InitializeComponent();
        }

        //Set up dialog and fetch data
        public byte[] initDialog(string windowTitle, byte[] gameSaveData)
        {
            this.Text = windowTitle;
            this.saveData = new SaveData(gameSaveData, currentSaveSlot);
            loadData();

            //Init default values
            firstRun = true;

            this.ShowDialog();

            //Check what kind of data should be returned to host application (MemcardRex)
            if (confirmedFlag == true) return this.saveData.getData(); else return null;
        }

        //Load data from the save
        private void loadData()
        {
            //Load gold
            goldNumeric.Value = saveData.load16bitUint(0x0314);
        }

        //Place data in the save
        private void updateData()
        {
            //Store gems in little-endian byte order (16 bit)
            uint gold = (uint)Math.Max(goldNumeric.Minimum, Math.Min(goldNumeric.Value, goldNumeric.Maximum));
            saveData.save16bitUint(0x0314, gold);
            saveData.save16bitUint(0x021C, gold);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Update save data
            updateData();

            //Edited data should be return after pressing OK button
            confirmedFlag = true;
            this.Close();
        }

        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            //Draw gray rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), 0, 0, this.Width, 30);
        }
    }
}
