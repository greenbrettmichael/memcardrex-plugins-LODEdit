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
        Heschel,
        Albert,
        Meru,
        Kongol,
        Miranda
    }

    enum Dart_Additions
    {
        Double_Slash,
        Volcano,
        Burning_Rush,
        Crush_Dance,
        Madness_Hero,
        Moon_Strike,
        Blazing_Dynamo
    }

    enum Lavitz_Additions
    {
        Harpoon,
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
        Whip_Smack,
        More_and_More,
        Hard_Blade,
        Demons_Dance
    }

    enum Haschel_Additions
    {
        Double_Punch,
        Flurry_of_Styx,
        Summon_Four_Gods,
        Five_Ring_Shattering,
        Hex_Hammer,
        Omni_Sweep
    }

    enum Albert_Additions
    {
        Harpoon,
        Spinning_Cane,
        Rod_Typhoon,
        Gust_of_Wind_Dance,
        Flower_Storm
    }

    enum Meru_Additions
    {
        Double_Smack,
        Hammer_Spin,
        Cool_Boogie,
        Cats_Cradle,
        Perky_Step
    }

    enum Kongol_Additions
    {
        Pursuit,
        Inferno,
        Bone_Crush
    }

    enum Miranda_Additions
    {
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

        public int lvl;
        public int exp;
        public int dlvl;
        public int dexp;
        public int hp;
        public int mp;
        public int sp;

        public CharacterStats(CharacterID characterID, SaveData saveData)
        {
            this.characterID = characterID;
            this.saveData = saveData;

            loadData();
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
        }
    }
}
