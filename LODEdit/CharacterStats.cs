using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    public enum CharacterID
    {
        None = -1,
        Dart,
        Lavitz,
        Shana,
        Rose,
        Haschel,
        Albert,
        Meru,
        Kongol,
        Miranda
    }

    enum Dart_Additions
    {
        Double_Slash = 0x05CE,
        Volcano,
        Burning_Rush,
        Crush_Dance,
        Madness_Hero,
        Moon_Strike,
        Blazing_Dynamo
    }

    enum Lavitz_Additions
    {
        Harpoon = 0x05FA,
        Spinning_Cane,
        Rod_Typhoon,
        Gust_of_Wind_Dance,
        Flower_Storm
    }

    enum Shana_Additions
    {
    }

    enum Rose_Additions
    {
        Whip_Smack = 0x0652,
        More_and_More,
        Hard_Blade,
        Demons_Dance
    }

    enum Haschel_Additions
    {
        Double_Punch = 0x067E,
        Flurry_of_Styx,
        Summon_Four_Gods,
        Five_Ring_Shattering,
        Hex_Hammer,
        Omni_Sweep
    }

    enum Albert_Additions
    {
        Harpoon = 0x06AA,
        Spinning_Cane,
        Rod_Typhoon,
        Gust_of_Wind_Dance,
        Flower_Storm
    }

    enum Meru_Additions
    {
        Double_Smack = 0x06D6,
        Hammer_Spin,
        Cool_Boogie,
        Cats_Cradle,
        Perky_Step
    }

    enum Kongol_Additions
    {
        Pursuit = 0x0702,
        Inferno,
        Bone_Crush
    }

    enum Miranda_Additions
    {
    }

    public class Addition
    {
        public Int32 index;
        public String name;
        public int hits;
    }

    public class CharacterStats
    {
        private CharacterID characterID;
        private SaveData saveData;
        private Int32[] characterIndexes = { 0x05AC, 0x05D8, 0x0604, 0x0630, 0x065C, 0x0688, 0x06B4, 0x06E0, 0x070C };
        private Int32 hpOffset = 8;
        private Int32 mpOffset = 10;
        private Int32 spOffset = 12;
        private Int32 dexpOffset = 14;
        private Int32 lvlOffset = 18;
        private Int32 dlvlOffset = 19;
        private Int32 weaponOffset = 20;
        private Int32 helmetOffset = 21;
        private Int32 chestOffset = 22;
        private Int32 bootsOffset = 23;
        private Int32 accessoryOffset = 24;
        private Int32 dartSaveInfoIndex = 0x0214;
        private Int32 dartSaveInfoDLvlOffset = 1;
        private Int32 dartSaveInfoHPOffset = 2;
        private Int32 dartSaveInfoMaxHPOffset = 4;

        public int lvl;
        public int exp;
        public int dlvl;
        public int dexp;
        public int hp;
        public int mp;
        public int sp;
        public InventoryItem weapon;
        public InventoryItem helmet;
        public InventoryItem chest;
        public InventoryItem boots;
        public InventoryItem accessory;

        public int dartMaxHp;

        public List<Addition> additions = new List<Addition>();

        public CharacterStats(CharacterID characterID, SaveData saveData)
        {
            this.characterID = characterID;
            this.saveData = saveData;

            loadData();
        }

        private void populateAdditions<AdditionType>()
        {
            additions.Clear();
            foreach (AdditionType addition in Enum.GetValues(typeof(AdditionType)))
            {
                Addition newAddition = new Addition();
                newAddition.index = Convert.ToInt32(addition);
                newAddition.name = addition.ToString();
                newAddition.hits = saveData.load8bitInt(newAddition.index);
                additions.Add(newAddition);
            }
        }

        private void loadData()
        {
            Int32 baseIndex = characterIndexes[(int)characterID];
            exp = saveData.load32bitInt(baseIndex);
            hp = saveData.load16bitInt(baseIndex + hpOffset);
            mp = saveData.load16bitInt(baseIndex + mpOffset);
            sp = saveData.load16bitInt(baseIndex + spOffset);
            dexp = saveData.load16bitInt(baseIndex + dexpOffset);
            lvl = saveData.load8bitInt(baseIndex + lvlOffset);
            dlvl = saveData.load8bitInt(baseIndex + dlvlOffset);
            weapon = (InventoryItem)saveData.load8bitUint(baseIndex + weaponOffset);
            helmet = (InventoryItem)saveData.load8bitUint(baseIndex + helmetOffset);
            chest = (InventoryItem)saveData.load8bitUint(baseIndex + chestOffset);
            boots = (InventoryItem)saveData.load8bitUint(baseIndex + bootsOffset);
            accessory = (InventoryItem)saveData.load8bitUint(baseIndex + accessoryOffset);
            switch (characterID)
            {
                case CharacterID.Dart:
                    populateAdditions<Dart_Additions>();
                    break;
                case CharacterID.Lavitz:
                    populateAdditions<Lavitz_Additions>();
                    break;
                case CharacterID.Rose:
                    populateAdditions<Rose_Additions>();
                    break;
                case CharacterID.Haschel:
                    populateAdditions<Haschel_Additions>();
                    break;
                case CharacterID.Albert:
                    populateAdditions<Albert_Additions>();
                    break;
                case CharacterID.Meru:
                    populateAdditions<Meru_Additions>();
                    break;
                case CharacterID.Kongol:
                    populateAdditions<Kongol_Additions>();
                    break;
                default:
                    break;
            }
            if(characterID == CharacterID.Dart)
            {
                dartMaxHp = saveData.load16bitInt(dartSaveInfoIndex + dartSaveInfoMaxHPOffset);
            }
        }

        public void updateData()
        {
            Int32 baseIndex = characterIndexes[(int)characterID];
            saveData.save32bitInt(baseIndex, exp);
            saveData.save16bitInt(baseIndex + hpOffset, hp);
            saveData.save16bitInt(baseIndex + mpOffset, mp);
            saveData.save16bitInt(baseIndex + spOffset, sp);
            saveData.save16bitInt(baseIndex + dexpOffset, dexp);
            saveData.save8bitInt(baseIndex + lvlOffset, lvl);
            saveData.save8bitInt(baseIndex + dlvlOffset, dlvl);
            saveData.save8bitUint(baseIndex + weaponOffset, (uint)weapon);
            saveData.save8bitUint(baseIndex + helmetOffset, (uint)helmet);
            saveData.save8bitUint(baseIndex + chestOffset, (uint)chest);
            saveData.save8bitUint(baseIndex + bootsOffset, (uint)boots);
            saveData.save8bitUint(baseIndex + accessoryOffset, (uint)accessory);
            foreach (Addition addition in additions)
            {
                saveData.save8bitInt(addition.index, addition.hits);
            }
            if (characterID == CharacterID.Dart)
            {
                saveData.save8bitInt(dartSaveInfoIndex, lvl);
                saveData.save8bitInt(dartSaveInfoIndex + dartSaveInfoDLvlOffset, dlvl);
                saveData.save16bitInt(dartSaveInfoIndex + dartSaveInfoHPOffset, hp);
                saveData.save16bitInt(dartSaveInfoIndex + dartSaveInfoMaxHPOffset, dartMaxHp);
            }
        }
    }
}
