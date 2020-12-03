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
        DragoonStats dragoonStats = null;
        Inventory inventory = null;
        Goods keyItems = null;
        Warp warp = null;
        List<CharacterStats> saveCharacters = new List<CharacterStats>();
        CharacterID selectedCharacter = CharacterID.Dart;
        int selectedAddition = 0;
        int selectedArmorItem = 0;
        int selectedUsedItem = 0;
        int selectedGoodsSlot = 2;

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
            this.dragoonStats = new DragoonStats(saveData);
            this.inventory = new Inventory(saveData);
            this.keyItems = new Goods(saveData);
            this.warp = new Warp(saveData);
            itemSlotItem.DataSource = inventory.getItemList();
            armorSlotItem.DataSource = inventory.getArmorList();
            weapon.DataSource = inventory.getArmorList();
            helmet.DataSource = inventory.getArmorList();
            chest.DataSource = inventory.getArmorList();
            boots.DataSource = inventory.getArmorList();
            accessory.DataSource = inventory.getArmorList();
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
            weapon.SelectedItem = saveCharacter.weapon;
            helmet.SelectedItem = saveCharacter.helmet;
            chest.SelectedItem = saveCharacter.chest;
            boots.SelectedItem = saveCharacter.boots;
            accessory.SelectedItem = saveCharacter.accessory;

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

        private void loadArmorItem()
        {
            selectedArmorItem = (int)armorSlot.Value - 1;
            armorSlotItem.SelectedItem = inventory.armors[selectedArmorItem];
        }

        private void loadUsedItem()
        {
            selectedUsedItem = (int)itemSlot.Value - 1;
            itemSlotItem.SelectedItem = inventory.usedItems[selectedUsedItem];
        }

        private void updateArmorItem()
        {
            inventory.armors[selectedArmorItem] = (InventoryItem)armorSlotItem.SelectedItem;
        }

        private void updateUsedItem()
        {
            inventory.usedItems[selectedUsedItem] = (InventoryItem)itemSlotItem.SelectedItem;
        }

        private void loadKeyItems()
        {
            selectedGoodsSlot = selectedGoodsSlot = (int)clampNumeric(goodSlot);
            goods.Items.Clear();
            switch (selectedGoodsSlot)
            {
                case 2:
                    foreach (Goods2 value in Enum.GetValues(typeof(Goods2)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                case 3:
                    foreach (Goods3 value in Enum.GetValues(typeof(Goods3)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                case 4:
                    foreach (Goods4 value in Enum.GetValues(typeof(Goods4)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                case 5:
                    foreach (Goods5 value in Enum.GetValues(typeof(Goods5)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                case 6:
                    foreach (Goods6 value in Enum.GetValues(typeof(Goods6)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                case 7:
                    foreach (Goods7 value in Enum.GetValues(typeof(Goods7)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                case 8:
                    foreach (Goods8 value in Enum.GetValues(typeof(Goods8)))
                    {
                        goods.Items.Add(value, keyItems.hasGood(value, selectedGoodsSlot));
                    }
                    break;
                default:
                    break;
            }
        }

        private void updateKeyItems()
        {
            for (int i = 0; i < goods.Items.Count; i++)
            {
                CheckState st = goods.GetItemCheckState(i);
                if (st == CheckState.Checked)
                {
                    keyItems.addGood(goods.Items[i], selectedGoodsSlot);
                }
                else
                {
                    keyItems.removeGood(goods.Items[i], selectedGoodsSlot);
                }
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
            saveCharacter.weapon = (InventoryItem)(weapon.SelectedItem ?? saveCharacter.weapon);
            saveCharacter.helmet = (InventoryItem)(helmet.SelectedItem ?? saveCharacter.helmet);
            saveCharacter.chest = (InventoryItem)(chest.SelectedItem ?? saveCharacter.chest);
            saveCharacter.boots = (InventoryItem)(boots.SelectedItem ?? saveCharacter.boots);
            saveCharacter.accessory = (InventoryItem)(accessory.SelectedItem ?? saveCharacter.accessory);
            if (selectedCharacter == CharacterID.Dart)
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

            int dsIter = 0;
            foreach(DragoonSpirit ds in Enum.GetValues(typeof(DragoonSpirit)))
            {
                dragoonSpirits.SetItemChecked(dsIter++, dragoonStats.hasDragoonSpirit(ds));
            }

            loadArmorItem();
            loadUsedItem();
            armorCount.Value = inventory.armorCount;
            itemCount.Value = inventory.itemCount;

            loadKeyItems();
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

            dragoonStats.updateData();

            updateArmorItem();
            updateUsedItem();
            inventory.armorCount = (uint)clampNumeric(armorCount);
            inventory.itemCount = (uint)clampNumeric(itemCount);
            inventory.updateData();

            updateKeyItems();
            keyItems.updateData();

            warp.saveLocation = 4;
            warp.updateData();
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

        private void dragoonSpirits_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DragoonSpirit checkedSpirit = dragoonStats.getFromIndex(e.Index);
            if(e.NewValue == CheckState.Checked)
            {
                dragoonStats.addDragoonSpirit(checkedSpirit);
            }
            else
            {
                dragoonStats.removeDragoonSpirit(checkedSpirit);
            }
        }

        private void armorSlot_ValueChanged(object sender, EventArgs e)
        {
            updateArmorItem();
            loadArmorItem();
        }

        private void itemSlot_ValueChanged(object sender, EventArgs e)
        {
            updateUsedItem();
            loadUsedItem();
        }

        private void goodSlot_ValueChanged(object sender, EventArgs e)
        {
            updateKeyItems();
            loadKeyItems();
        }
    }
}
