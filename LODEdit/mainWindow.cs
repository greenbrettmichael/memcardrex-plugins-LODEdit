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
        private byte[] saveData = null;

        public mainWindow()
        {
            InitializeComponent();
        }

        //Set up dialog and fetch data
        public byte[] initDialog(string windowTitle, byte[] gameSaveData)
        {
            this.Text = windowTitle;
            saveData = gameSaveData;
            loadData(currentSaveSlot);

            //Init default values
            firstRun = true;

            this.ShowDialog();

            //Check what kind of data should be returned to host application (MemcardRex)
            if (confirmedFlag == true) return saveData; else return null;
        }

        //Update slot (save old data, load new data)
        private void updateSlot(int slotValue)
        {
            //Save old data
            if (firstRun == false) updateData(currentSaveSlot);

            //Update current slot
            currentSaveSlot = slotValue;

            //Load new data
            loadData(currentSaveSlot);

            //This is no longer first run
            firstRun = false;
        }

        //Load data from the save
        private void loadData(int slotNumber)
        {
            //Load gold
            goldNumeric.Value = saveData[0x0314 + (slotNumber * 0x600)] | saveData[0x0314 + (slotNumber * 0x600) + 1]<<8;
        }

        //Place data in the save
        private void updateData(int slotNumber)
        {
            //Store gems in little-endian byte order (16 bit)
            saveData[0x0314 + (slotNumber * 0x600)] = (byte)((uint)goldNumeric.Value & 0xFF);
            saveData[0x0314 + (slotNumber * 0x600) + 1] = (byte)(((uint)goldNumeric.Value & 0xFF00)>>8);
            saveData[0x021C + (slotNumber * 0x600)] = (byte)((uint)goldNumeric.Value & 0xFF);
            saveData[0x021C + (slotNumber * 0x600) + 1] = (byte)(((uint)goldNumeric.Value & 0xFF00) >> 8);

            calcChecksum(slotNumber);
        }

        //Calculate checksum for the currently selected slot
        private void calcChecksum(int slotNumber)
        {
            int saveChecksum = 0;

            for (int i = 0; i < 1420; i++)
            {
                saveChecksum += saveData[0x280 + (slotNumber * 0x600) + i];
            }

            //Store checksum in little-endian byte order
            saveData[0x80C + (slotNumber * 0x600)] = (byte)(saveChecksum & 0xFF);
            saveData[0x80D + (slotNumber * 0x600)] = (byte)((saveChecksum & 0xFF00) >> 8);
            saveData[0x80E + (slotNumber * 0x600)] = (byte)((saveChecksum & 0xFF0000) >> 16);
            saveData[0x80F + (slotNumber * 0x600)] = (byte)((saveChecksum & 0xFF000000) >> 24);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //Update save data
            updateData(currentSaveSlot);

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
