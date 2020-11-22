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
        private bool confirmedFlag = false;
        private bool firstRun = true;
        private int currentSaveSlot = 0;
        private SaveData saveData = null;

        public mainWindow()
        {
            InitializeComponent();
        }

        public byte[] initDialog(string windowTitle, byte[] gameSaveData)
        {
            #if DEBUG
                System.Diagnostics.Debugger.Launch();
            #endif
            this.Text = windowTitle;
            this.saveData = new SaveData(gameSaveData, currentSaveSlot);
            loadData();

            firstRun = true;

            this.ShowDialog();

            if (confirmedFlag == true) return this.saveData.getData(); else return null;
        }

        private void loadData()
        {
            goldNumeric.Value = saveData.load16bitUint(0x0314);
            // LOD time is a bit weird... base value is frames (1s = 60 frames)
            Int32 gameTime = saveData.load32bitInt(0x0320) / 60;
            TimeSpan gameTimeSpan = TimeSpan.FromSeconds(gameTime);
            timeHours.Value = Convert.ToDecimal(gameTimeSpan.TotalHours);
            timeMinutes.Value = gameTimeSpan.Minutes;
            timeSeconds.Value = gameTimeSpan.Seconds;
        }

        private void updateData()
        {
            uint gold = (uint)Math.Max(goldNumeric.Minimum, Math.Min(goldNumeric.Value, goldNumeric.Maximum));
            saveData.save16bitUint(0x0314, gold);
            saveData.save16bitUint(0x021C, gold);
            Int32 hours = (Int32)Math.Max(timeHours.Minimum, Math.Min(timeHours.Value, timeHours.Maximum));
            Int32 minutes = (Int32)Math.Max(timeMinutes.Minimum, Math.Min(timeMinutes.Value, timeMinutes.Maximum));
            Int32 seconds = (Int32)Math.Max(timeSeconds.Minimum, Math.Min(timeSeconds.Value, timeSeconds.Maximum));
            // LOD time is a bit weird... base value is frames (1s = 60 frames)
            Int32 gameTime = hours * 60; // hours to minutes
            gameTime += minutes;
            gameTime *= 60; // minutes to seconds
            gameTime += seconds;
            gameTime *= 60; // seconds to frames
            saveData.save32bitInt(0x0320, gameTime);
            saveData.save32bitInt(0x0220, gameTime);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            updateData();

            confirmedFlag = true;
            this.Close();
        }

        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), 0, 0, this.Width, 30);
        }
    }
}
