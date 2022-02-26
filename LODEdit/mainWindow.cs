using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LODEdit
{
    public partial class MainWindow : Form
    {
        private bool confirmedFlag;
        private const int CurrentSaveSlot = 0;
        private DragoonStats dragoonStats;
        private Inventory inventory;
        private Goods keyItems;
        private readonly List<CharacterStats> saveCharacters = new List<CharacterStats>();
        private SaveData saveData;
        private Gold saveGold;
        private Party saveParty;
        private TimePlayed saveTime;
        private int selectedAddition;
        private int selectedArmorItem;
        private CharacterId selectedCharacter = CharacterId.Dart;
        private int selectedGoodsSlot = 2;
        private int selectedUsedItem;
        private Warp warp;

        public MainWindow()
        {
            InitializeComponent();
        }

        public byte[] InitDialog(string windowTitle, byte[] gameSaveData)
        {
#if DEBUG
                System.Diagnostics.Debugger.Launch();
#endif
            Text = windowTitle;
            saveData = new SaveData(gameSaveData, CurrentSaveSlot);
            saveGold = new Gold(saveData);
            saveTime = new TimePlayed(saveData);
            saveParty = new Party(saveData);
            dragoonStats = new DragoonStats(saveData);
            inventory = new Inventory(saveData);
            keyItems = new Goods(saveData);
            warp = new Warp(saveData);
            itemSlotItem.DataSource = inventory.GetItemList();
            armorSlotItem.DataSource = inventory.GetArmorList();
            weapon.DataSource = inventory.GetArmorList();
            helmet.DataSource = inventory.GetArmorList();
            chest.DataSource = inventory.GetArmorList();
            boots.DataSource = inventory.GetArmorList();
            accessory.DataSource = inventory.GetArmorList();
            foreach (CharacterId characterId in Enum.GetValues(typeof(CharacterId)))
            {
                if (characterId == CharacterId.None) continue;
                saveCharacters.Add(new CharacterStats(characterId, saveData));
            }

            LoadData();

            ShowDialog();

            return confirmedFlag ? saveData.GetData() : null;
        }

        private void LoadAddition()
        {
            var saveCharacter = saveCharacters[(int) selectedCharacter];
            if (saveCharacter.additions.Count > selectedAddition)
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

        private void LoadCharacterStats()
        {
            var saveCharacter = saveCharacters[(int) selectedCharacter];
            lvl.Value = saveCharacter.lvl;
            exp.Value = saveCharacter.exp;
            dlvl.Value = saveCharacter.dlvl;
            dexp.Value = saveCharacter.dexp;
            hp.Value = saveCharacter.hp;
            mp.Value = saveCharacter.mp;
            sp.Value = saveCharacter.sp;
            if (selectedCharacter == CharacterId.Dart)
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
            foreach (var characterAddition in saveCharacter.additions) addition.Items.Add(characterAddition.name);
            LoadAddition();
        }

        private static decimal ClampNumeric(NumericUpDown numCtrl)
        {
            return Math.Max(numCtrl.Minimum, Math.Min(numCtrl.Value, numCtrl.Maximum));
        }

        private void UpdateAddition()
        {
            var saveCharacter = saveCharacters[(int) selectedCharacter];
            if (saveCharacter.additions.Count > selectedAddition)
                saveCharacter.additions[selectedAddition].hits = (int) ClampNumeric(hits);
        }

        private void LoadArmorItem()
        {
            selectedArmorItem = (int) armorSlot.Value - 1;
            armorSlotItem.SelectedItem = inventory.armors[selectedArmorItem];
        }

        private void LoadUsedItem()
        {
            selectedUsedItem = (int) itemSlot.Value - 1;
            itemSlotItem.SelectedItem = inventory.usedItems[selectedUsedItem];
        }

        private void UpdateArmorItem()
        {
            inventory.armors[selectedArmorItem] = (InventoryItem) armorSlotItem.SelectedItem;
        }

        private void UpdateUsedItem()
        {
            inventory.usedItems[selectedUsedItem] = (InventoryItem) itemSlotItem.SelectedItem;
        }

        private void LoadKeyItems()
        {
            selectedGoodsSlot = selectedGoodsSlot = (int) ClampNumeric(goodSlot);
            goods.Items.Clear();
            switch (selectedGoodsSlot)
            {
                case 2:
                    foreach (Goods2 value in Enum.GetValues(typeof(Goods2)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
                case 3:
                    foreach (Goods3 value in Enum.GetValues(typeof(Goods3)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
                case 4:
                    foreach (Goods4 value in Enum.GetValues(typeof(Goods4)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
                case 5:
                    foreach (Goods5 value in Enum.GetValues(typeof(Goods5)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
                case 6:
                    foreach (Goods6 value in Enum.GetValues(typeof(Goods6)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
                case 7:
                    foreach (Goods7 value in Enum.GetValues(typeof(Goods7)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
                case 8:
                    foreach (Goods8 value in Enum.GetValues(typeof(Goods8)))
                        goods.Items.Add(value, keyItems.HasGood(value, selectedGoodsSlot));
                    break;
            }
        }

        private void UpdateKeyItems()
        {
            for (var i = 0; i < goods.Items.Count; i++)
            {
                var st = goods.GetItemCheckState(i);
                if (st == CheckState.Checked)
                    keyItems.AddGood(goods.Items[i], selectedGoodsSlot);
                else
                    keyItems.RemoveGood(goods.Items[i], selectedGoodsSlot);
            }
        }

        private void UpdateCharacterStats()
        {
            var saveCharacter = saveCharacters[(int) selectedCharacter];
            saveCharacter.lvl = (int) ClampNumeric(lvl);
            saveCharacter.exp = (int) ClampNumeric(exp);
            saveCharacter.dlvl = (int) ClampNumeric(dlvl);
            saveCharacter.dexp = (int) ClampNumeric(dexp);
            saveCharacter.hp = (int) ClampNumeric(hp);
            saveCharacter.mp = (int) ClampNumeric(mp);
            saveCharacter.sp = (int) ClampNumeric(sp);
            saveCharacter.weapon = (InventoryItem) (weapon.SelectedItem ?? saveCharacter.weapon);
            saveCharacter.helmet = (InventoryItem) (helmet.SelectedItem ?? saveCharacter.helmet);
            saveCharacter.chest = (InventoryItem) (chest.SelectedItem ?? saveCharacter.chest);
            saveCharacter.boots = (InventoryItem) (boots.SelectedItem ?? saveCharacter.boots);
            saveCharacter.accessory = (InventoryItem) (accessory.SelectedItem ?? saveCharacter.accessory);
            if (selectedCharacter == CharacterId.Dart) saveCharacter.dartMaxHp = (int) ClampNumeric(dartMaxHP);

            UpdateAddition();
        }

        private void LoadData()
        {
            goldNumeric.Value = saveGold.gold;

            timeHours.Value = saveTime.hours;
            timeMinutes.Value = saveTime.minutes;
            timeSeconds.Value = saveTime.seconds;

            party1.SelectedIndex = (int) saveParty.party1 + 1;
            party2.SelectedIndex = (int) saveParty.party2 + 1;
            party3.SelectedIndex = (int) saveParty.party3 + 1;

            LoadCharacterStats();
            character.SelectedIndex = (int) selectedCharacter;
            addition.SelectedIndex = selectedAddition;

            var dsIter = 0;
            foreach (DragoonSpirit ds in Enum.GetValues(typeof(DragoonSpirit)))
                dragoonSpirits.SetItemChecked(dsIter++, dragoonStats.HasDragoonSpirit(ds));

            LoadArmorItem();
            LoadUsedItem();
            armorCount.Value = inventory.armorCount;
            itemCount.Value = inventory.itemCount;

            LoadKeyItems();
        }

        private void UpdateData()
        {
            saveGold.gold = (uint) ClampNumeric(goldNumeric);
            saveGold.UpdateData();

            saveTime.hours = (int) ClampNumeric(timeHours);
            saveTime.minutes = (int) ClampNumeric(timeMinutes);
            saveTime.seconds = (int) ClampNumeric(timeSeconds);
            saveTime.UpdateData();

            saveParty.party1 = (CharacterId) party1.SelectedIndex - 1;
            saveParty.party2 = (CharacterId) party2.SelectedIndex - 1;
            saveParty.party3 = (CharacterId) party3.SelectedIndex - 1;
            saveParty.UpdateData();

            UpdateCharacterStats();
            foreach (var saveCharacter in saveCharacters) saveCharacter.UpdateData();

            dragoonStats.UpdateData();

            UpdateArmorItem();
            UpdateUsedItem();
            inventory.armorCount = (uint) ClampNumeric(armorCount);
            inventory.itemCount = (uint) ClampNumeric(itemCount);
            inventory.UpdateData();

            UpdateKeyItems();
            keyItems.UpdateData();

            warp.saveLocation = 4;
            warp.UpdateData();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            UpdateData();

            confirmedFlag = true;
            Close();
        }

        private void mainWindow_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(80, 80, 80)), 0, 0, Width, 30);
        }

        private void addition_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAddition();
            selectedAddition = addition.SelectedIndex;
            LoadAddition();
        }

        private void character_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCharacterStats();
            selectedCharacter = (CharacterId) character.SelectedIndex;
            LoadCharacterStats();
        }

        private void dragoonSpirits_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checkedSpirit = dragoonStats.GetFromIndex(e.Index);
            if (e.NewValue == CheckState.Checked)
                dragoonStats.AddDragoonSpirit(checkedSpirit);
            else
                dragoonStats.RemoveDragoonSpirit(checkedSpirit);
        }

        private void armorSlot_ValueChanged(object sender, EventArgs e)
        {
            UpdateArmorItem();
            LoadArmorItem();
        }

        private void itemSlot_ValueChanged(object sender, EventArgs e)
        {
            UpdateUsedItem();
            LoadUsedItem();
        }

        private void goodSlot_ValueChanged(object sender, EventArgs e)
        {
            UpdateKeyItems();
            LoadKeyItems();
        }

        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            var advancedWindow = new AdvancedWindow();
            advancedWindow.Show();
        }
    }
}