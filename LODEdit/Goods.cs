using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    public enum Goods2
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    public enum Goods3
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    public enum Goods4
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    public enum Goods5
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    public enum Goods6
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    public enum Goods7
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    public enum Goods8
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    class Goods
    {
        private SaveData saveData;

        private Int32 gameIndex = 0x041D;

        private uint goods2;
        private uint goods3;
        private uint goods4;
        private uint goods5;
        private uint goods6;
        private uint goods7;
        private uint goods8;

        public Goods(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        public void addGood<T>(T good, int slot)
        {
            switch (slot)
            {
                case 2:
                    goods2 |= Convert.ToUInt32(good);
                    break;
                case 3:
                    goods3 |= Convert.ToUInt32(good);
                    break;
                case 4:
                    goods4 |= Convert.ToUInt32(good);
                    break;
                case 5:
                    goods5 |= Convert.ToUInt32(good);
                    break;
                case 6:
                    goods6 |= Convert.ToUInt32(good);
                    break;
                case 7:
                    goods7 |= Convert.ToUInt32(good);
                    break;
                case 8:
                    goods8 |= Convert.ToUInt32(good);
                    break;
                default:
                    break;
            }
        }

        public void removeGood<T>(T good, int slot)
        {
            switch (slot)
            {
                case 2:
                    goods2 &= ~Convert.ToUInt32(good);
                    break;
                case 3:
                    goods3 &= ~Convert.ToUInt32(good);
                    break;
                case 4:
                    goods4 &= ~Convert.ToUInt32(good);
                    break;
                case 5:
                    goods5 &= ~Convert.ToUInt32(good);
                    break;
                case 6:
                    goods6 &= ~Convert.ToUInt32(good);
                    break;
                case 7:
                    goods7 &= ~Convert.ToUInt32(good);
                    break;
                case 8:
                    goods8 &= ~Convert.ToUInt32(good);
                    break;
                default:
                    break;
            }
        }

        public bool hasGood<T>(T good, int slot)
        {
            switch (slot)
            {
                case 2:
                    return (goods2 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                case 3:
                    return (goods3 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                case 4:
                    return (goods4 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                case 5:
                    return (goods5 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                case 6:
                    return (goods6 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                case 7:
                    return (goods7 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                case 8:
                    return (goods8 & Convert.ToUInt32(good)) == Convert.ToUInt32(good);
                default:
                    break;
            }
            return false;
        }

        public void setGoodList<T>(T collection, int slot) where T : System.Windows.Forms.ListBox.ObjectCollection
        {
            collection.Clear();
            switch (slot)
            {
                case 2:
                    foreach(Goods2 value in Enum.GetValues(typeof(Goods2)))
                    {
                        collection.Add(value);
                    }
                    break;
                case 3:
                    foreach (Goods3 value in Enum.GetValues(typeof(Goods3)))
                    {
                        collection.Add(value);
                    }
                    break;
                case 4:
                    foreach (Goods4 value in Enum.GetValues(typeof(Goods4)))
                    {
                        collection.Add(value);
                    }
                    break;
                case 5:
                    foreach (Goods5 value in Enum.GetValues(typeof(Goods5)))
                    {
                        collection.Add(value);
                    }
                    break;
                case 6:
                    foreach (Goods6 value in Enum.GetValues(typeof(Goods6)))
                    {
                        collection.Add(value);
                    }
                    break;
                case 7:
                    foreach (Goods7 value in Enum.GetValues(typeof(Goods7)))
                    {
                        collection.Add(value);
                    }
                    break;
                case 8:
                    foreach (Goods8 value in Enum.GetValues(typeof(Goods8)))
                    {
                        collection.Add(value);
                    }
                    break;
                default:
                    break;
            }
        }

        private void loadData()
        {
            goods2 = saveData.load8bitUint(gameIndex);
            goods3 = saveData.load8bitUint(gameIndex + 1);
            goods4 = saveData.load8bitUint(gameIndex + 2);
            goods5 = saveData.load8bitUint(gameIndex + 3);
            goods6 = saveData.load8bitUint(gameIndex + 4);
            goods7 = saveData.load8bitUint(gameIndex + 5);
            goods8 = saveData.load8bitUint(gameIndex + 6);
        }

        public void updateData()
        {
            saveData.save8bitUint(gameIndex, goods2);
            saveData.save8bitUint(gameIndex, goods3);
            saveData.save8bitUint(gameIndex, goods4);
            saveData.save8bitUint(gameIndex, goods5);
            saveData.save8bitUint(gameIndex, goods6);
            saveData.save8bitUint(gameIndex, goods7);
            saveData.save8bitUint(gameIndex, goods8);
        }
    }
}
