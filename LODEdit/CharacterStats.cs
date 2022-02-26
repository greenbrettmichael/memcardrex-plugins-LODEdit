using System;
using System.Collections.Generic;

namespace LODEdit
{
    public enum CharacterId
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

    internal enum DartAdditions
    {
        Double_Slash = 0x05CE,
        Volcano,
        Burning_Rush,
        Crush_Dance,
        Madness_Hero,
        Moon_Strike,
        Blazing_Dynamo
    }

    internal enum LavitzAdditions
    {
        Harpoon = 0x05FA,
        Spinning_Cane,
        Rod_Typhoon,
        Gust_Of_Wind_Dance,
        Flower_Storm
    }

    internal enum ShanaAdditions
    {
    }

    internal enum RoseAdditions
    {
        Whip_Smack = 0x0652,
        More_And_More,
        Hard_Blade,
        Demons_Dance
    }

    internal enum HaschelAdditions
    {
        Double_Punch = 0x067E,
        Flurry_Of_Styx,
        Summon_Four_Gods,
        Five_Ring_Shattering,
        Hex_Hammer,
        Omni_Sweep
    }

    internal enum AlbertAdditions
    {
        Harpoon = 0x06AA,
        Spinning_Cane,
        Rod_Typhoon,
        Gust_Of_Wind_Dance,
        Flower_Storm
    }

    internal enum MeruAdditions
    {
        Double_Smack = 0x06D6,
        Hammer_Spin,
        Cool_Boogie,
        Cats_Cradle,
        Perky_Step
    }

    internal enum KongolAdditions
    {
        Pursuit = 0x0702,
        Inferno,
        Bone_Crush
    }

    internal enum MirandaAdditions
    {
    }

    public class Addition
    {
        public int index;
        public string name;
        public int hits;
    }

    public class CharacterStats
    {
        private readonly CharacterId characterId;
        private readonly SaveData saveData;
        private readonly int[] characterIndexes = { 0x05AC, 0x05D8, 0x0604, 0x0630, 0x065C, 0x0688, 0x06B4, 0x06E0, 0x070C };
        private const int HpOffset = 8;
        private const int MpOffset = 10;
        private const int SpOffset = 12;
        private const int DexpOffset = 14;
        private const int LvlOffset = 18;
        private const int DlvlOffset = 19;
        private const int WeaponOffset = 20;
        private const int HelmetOffset = 21;
        private const int ChestOffset = 22;
        private const int BootsOffset = 23;
        private const int AccessoryOffset = 24;
        private const int DartSaveInfoIndex = 0x0214;
        private const int DartSaveInfoDLvlOffset = 1;
        private const int DartSaveInfoHpOffset = 2;
        private const int DartSaveInfoMaxHpOffset = 4;

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

        public CharacterStats(CharacterId characterId, SaveData saveData)
        {
            this.characterId = characterId;
            this.saveData = saveData;

            LoadData();
        }

        private void PopulateAdditions<TAdditionType>()
        {
            additions.Clear();
            foreach (TAdditionType addition in Enum.GetValues(typeof(TAdditionType)))
            {
                var newAddition = new Addition
                {
                    index = Convert.ToInt32(addition),
                    name = addition.ToString()
                };
                newAddition.hits = saveData.Load8BitInt(newAddition.index);
                additions.Add(newAddition);
            }
        }

        private void LoadData()
        {
            var baseIndex = characterIndexes[(int)characterId];
            exp = saveData.Load32BitInt(baseIndex);
            hp = saveData.Load16BitInt(baseIndex + HpOffset);
            mp = saveData.Load16BitInt(baseIndex + MpOffset);
            sp = saveData.Load16BitInt(baseIndex + SpOffset);
            dexp = saveData.Load16BitInt(baseIndex + DexpOffset);
            lvl = saveData.Load8BitInt(baseIndex + LvlOffset);
            dlvl = saveData.Load8BitInt(baseIndex + DlvlOffset);
            weapon = (InventoryItem)saveData.Load8BitUint(baseIndex + WeaponOffset);
            helmet = (InventoryItem)saveData.Load8BitUint(baseIndex + HelmetOffset);
            chest = (InventoryItem)saveData.Load8BitUint(baseIndex + ChestOffset);
            boots = (InventoryItem)saveData.Load8BitUint(baseIndex + BootsOffset);
            accessory = (InventoryItem)saveData.Load8BitUint(baseIndex + AccessoryOffset);
            switch (characterId)
            {
                case CharacterId.Dart:
                    PopulateAdditions<DartAdditions>();
                    break;
                case CharacterId.Lavitz:
                    PopulateAdditions<LavitzAdditions>();
                    break;
                case CharacterId.Rose:
                    PopulateAdditions<RoseAdditions>();
                    break;
                case CharacterId.Haschel:
                    PopulateAdditions<HaschelAdditions>();
                    break;
                case CharacterId.Albert:
                    PopulateAdditions<AlbertAdditions>();
                    break;
                case CharacterId.Meru:
                    PopulateAdditions<MeruAdditions>();
                    break;
                case CharacterId.Kongol:
                    PopulateAdditions<KongolAdditions>();
                    break;
                case CharacterId.None:
                    break;
                case CharacterId.Shana:
                    break;
                case CharacterId.Miranda:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            if(characterId == CharacterId.Dart)
            {
                dartMaxHp = saveData.Load16BitInt(DartSaveInfoIndex + DartSaveInfoMaxHpOffset);
            }
        }

        public void UpdateData()
        {
            var baseIndex = characterIndexes[(int)characterId];
            saveData.Save32BitInt(baseIndex, exp);
            saveData.Save16BitInt(baseIndex + HpOffset, hp);
            saveData.Save16BitInt(baseIndex + MpOffset, mp);
            saveData.Save16BitInt(baseIndex + SpOffset, sp);
            saveData.Save16BitInt(baseIndex + DexpOffset, dexp);
            saveData.Save8BitInt(baseIndex + LvlOffset, lvl);
            saveData.Save8BitInt(baseIndex + DlvlOffset, dlvl);
            saveData.Save8BitUint(baseIndex + WeaponOffset, (uint)weapon);
            saveData.Save8BitUint(baseIndex + HelmetOffset, (uint)helmet);
            saveData.Save8BitUint(baseIndex + ChestOffset, (uint)chest);
            saveData.Save8BitUint(baseIndex + BootsOffset, (uint)boots);
            saveData.Save8BitUint(baseIndex + AccessoryOffset, (uint)accessory);
            foreach (var addition in additions)
            {
                saveData.Save8BitInt(addition.index, addition.hits);
            }
            if (characterId == CharacterId.Dart)
            {
                saveData.Save8BitInt(DartSaveInfoIndex, lvl);
                saveData.Save8BitInt(DartSaveInfoIndex + DartSaveInfoDLvlOffset, dlvl);
                saveData.Save16BitInt(DartSaveInfoIndex + DartSaveInfoHpOffset, hp);
                saveData.Save16BitInt(DartSaveInfoIndex + DartSaveInfoMaxHpOffset, dartMaxHp);
            }
        }
    }
}
