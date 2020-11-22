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
            party1.SelectedIndex = saveData.load32bitInt(0x0208) + 1;
            party2.SelectedIndex = saveData.load32bitInt(0x020C) + 1;
            party3.SelectedIndex = saveData.load32bitInt(0x0210) + 1;
            CharacterStats characterStats = new CharacterStats(CharacterID.Dart, saveData);
            lvl.Value = characterStats.lvl;
            exp.Value = characterStats.exp;
            dlvl.Value = characterStats.dlvl;
            dexp.Value = characterStats.dexp;
            hp.Value = characterStats.hp;
            mp.Value = characterStats.mp;
            sp.Value = characterStats.sp;
            // TODO Dart Max HP
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
            int partySelect1 = party1.SelectedIndex - 1;
            int partySelect2 = party2.SelectedIndex - 1;
            int partySelect3 = party3.SelectedIndex - 1;
            saveData.save32bitInt(0x0208, partySelect1);
            saveData.save32bitInt(0x0308, partySelect1);
            saveData.save32bitInt(0x020C, partySelect2);
            saveData.save32bitInt(0x030C, partySelect2);
            saveData.save32bitInt(0x0210, partySelect3);
            saveData.save32bitInt(0x0310, partySelect3);
            CharacterStats characterStats = new CharacterStats(CharacterID.Dart, saveData);
            characterStats.lvl = (int)Math.Max(lvl.Minimum, Math.Min(lvl.Value, lvl.Maximum));
            characterStats.exp = (int)Math.Max(exp.Minimum, Math.Min(exp.Value, exp.Maximum));
            characterStats.dlvl = (int)Math.Max(dlvl.Minimum, Math.Min(dlvl.Value, dlvl.Maximum));
            characterStats.dexp = (int)Math.Max(dexp.Minimum, Math.Min(dexp.Value, dexp.Maximum));
            characterStats.hp = (int)Math.Max(hp.Minimum, Math.Min(hp.Value, hp.Maximum));
            characterStats.mp = (int)Math.Max(mp.Minimum, Math.Min(mp.Value, mp.Maximum));
            characterStats.sp = (int)Math.Max(sp.Minimum, Math.Min(sp.Value, sp.Maximum));
            characterStats.updateData();
            // TODO darts stats for save info
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

        private void addition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void character_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
