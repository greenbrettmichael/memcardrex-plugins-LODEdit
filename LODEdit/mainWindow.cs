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
        private int currentSaveSlot = 0;
        private SaveData saveData = null;
        Gold saveGold = null;
        TimePlayed saveTime = null;
        Party saveParty = null;
        List<CharacterStats> saveCharacters = new List<CharacterStats>();
        CharacterID selectedCharacter = CharacterID.Dart;
        int selectedAddition = 0;

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
            this.saveGold = new Gold(saveData);
            this.saveTime = new TimePlayed(saveData);
            this.saveParty = new Party(saveData);
            foreach (CharacterID characterID in Enum.GetValues(typeof(CharacterID)))
            {
                if(characterID == CharacterID.None)
                {
                    continue;
                }
                this.saveCharacters.Add(new CharacterStats(characterID, saveData));
            }
            loadData();

            this.ShowDialog();

            if (confirmedFlag == true) return this.saveData.getData(); else return null;
        }

        private void loadAddition()
        {
            CharacterStats saveCharacter = saveCharacters[(int)selectedCharacter];
            if(saveCharacter.additions.Count > selectedAddition)
            {
                hits.Value = saveCharacter.additions[selectedAddition].hits;
                addition.Text = saveCharacter.additions[selectedAddition].name;
            }
            else
            {
                hits.Value = 0;
                addition.Text = "";
            }
        }

        private void loadCharacterStats()
        {
            CharacterStats saveCharacter = saveCharacters[(int)selectedCharacter];
            lvl.Value = saveCharacter.lvl;
            exp.Value = saveCharacter.exp;
            dlvl.Value = saveCharacter.dlvl;
            dexp.Value = saveCharacter.dexp;
            hp.Value = saveCharacter.hp;
            mp.Value = saveCharacter.mp;
            sp.Value = saveCharacter.sp;
            if(selectedCharacter == CharacterID.Dart)
            {
                dartMaxHP.Value = saveCharacter.dartMaxHp;
                dartMaxHP.Enabled = true;
            }
            else
            {
                dartMaxHP.Value = 0;
                dartMaxHP.Enabled = false;
            }

            addition.Items.Clear();
            selectedAddition = 0;
            foreach (Addition characterAddition in saveCharacter.additions)
            {
                addition.Items.Add(characterAddition.name);
            }
            loadAddition();
        }

        private decimal clampNumeric(NumericUpDown numCtrl)
        {
            return Math.Max(numCtrl.Minimum, Math.Min(numCtrl.Value, numCtrl.Maximum));
        }

        private void updateAddition()
        {
            CharacterStats saveCharacter = saveCharacters[(int)selectedCharacter];
            if (saveCharacter.additions.Count > selectedAddition)
            {
                saveCharacter.additions[selectedAddition].hits = (int)clampNumeric(hits);
            }
        }

        private void updateCharacterStats()
        {
            CharacterStats saveCharacter = saveCharacters[(int)selectedCharacter];
            saveCharacter.lvl = (int)clampNumeric(lvl);
            saveCharacter.exp = (int)clampNumeric(exp);
            saveCharacter.dlvl = (int)clampNumeric(dlvl);
            saveCharacter.dexp = (int)clampNumeric(dexp);
            saveCharacter.hp = (int)clampNumeric(hp);
            saveCharacter.mp = (int)clampNumeric(mp);
            saveCharacter.sp = (int)clampNumeric(sp);
            if(selectedCharacter == CharacterID.Dart)
            {
                saveCharacter.dartMaxHp = (int)clampNumeric(dartMaxHP);
            }

            updateAddition();
        }

        private void loadData()
        {
            goldNumeric.Value = saveGold.gold;

            timeHours.Value = saveTime.hours;
            timeMinutes.Value = saveTime.minutes;
            timeSeconds.Value = saveTime.seconds;

            party1.SelectedIndex = (int)saveParty.party1 + 1;
            party2.SelectedIndex = (int)saveParty.party2 + 1;
            party3.SelectedIndex = (int)saveParty.party3 + 1;

            loadCharacterStats();
            character.SelectedIndex = (int)selectedCharacter;
            addition.SelectedIndex = selectedAddition;
        }

        private void updateData()
        {
            saveGold.gold = (uint)clampNumeric(goldNumeric);
            saveGold.updateData();

            saveTime.hours = (int)clampNumeric(timeHours);
            saveTime.minutes = (int)clampNumeric(timeMinutes);
            saveTime.seconds = (int)clampNumeric(timeSeconds);
            saveTime.updateData();

            saveParty.party1 = (CharacterID)party1.SelectedIndex - 1;
            saveParty.party2 = (CharacterID)party2.SelectedIndex - 1;
            saveParty.party3 = (CharacterID)party3.SelectedIndex - 1;
            saveParty.updateData();

            updateCharacterStats();
            foreach (CharacterStats saveCharacter in saveCharacters)
            {
                saveCharacter.updateData();
            }
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
            updateAddition();
            selectedAddition = addition.SelectedIndex;
            loadAddition();
        }

        private void character_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateCharacterStats();
            selectedCharacter = (CharacterID)character.SelectedIndex;
            loadCharacterStats();
        }
    }
}
