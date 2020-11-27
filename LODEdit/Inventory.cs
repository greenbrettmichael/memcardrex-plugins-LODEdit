using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    public enum InventoryItem : uint
    {
        Broad_Sword = 0,
        Bastard_Sword = 1,
        Heat_Blade = 2,
        Falchion = 3,
        Mind_Crush = 4,
        Fairy_Sword = 5,
        Claymore = 6,
        Soul_Eater = 7,
        Axe = 8,
        Tomahawk = 9,
        Battle_Axe = 10,
        Great_Axe = 11,
        Indoras_Axe = 12,
        Rapier = 13,
        Shadow_Cutter = 14,
        Dancing_Dagger = 15,
        Flamberge = 16,
        Gladius = 17,
        Dragon_Buster = 18,
        Demon_Stiletto = 19,
        Spear = 20,
        Lance = 21,
        Glaive = 22,
        Spear_of_Terror = 23,
        Partisan = 24,
        Halberd = 25,
        Twister_Glaive = 26,
        Short_Bow = 27,
        Sparkle_Arrow = 28,
        Long_Bow = 29,
        Bemusing_Arrow = 30,
        Virulent_Arrow = 31,
        Detonate_Arrow = 32,
        Arrow_of_Force = 33,
        Mace = 34,
        Morning_Star = 35,
        War_Hammer = 36,
        Heavy_Mace = 37,
        Basher = 38,
        Pretty_Hammer = 39,
        Iron_Knuckle = 40,
        Beast_Fang = 41,
        Diamond_Claw = 42,
        Thunder_Fist = 43,
        Destroyer_Mace = 44,
        Brass_Knuckle = 45,
        Leather_Armor = 46,
        Scale_Armor = 47,
        Chain_Mail = 48,
        Plate_Mail = 49,
        Saint_Armor = 50,
        Red_DG_Armor = 51,
        Jade_DG_Armor = 52,
        Lion_Fur = 53,
        Breast_Plate = 54,
        Giganto_Armor = 55,
        Gold_DG_Armor = 56,
        Disciple_Vest = 57,
        Warrior_Dress = 58,
        Masters_Vest = 59,
        Energy_Girdle = 60,
        Violet_DG_Armor = 61,
        Clothes = 62,
        Leather_Jacket = 63,
        Silver_Vest = 64,
        Sparkle_Dress = 65,
        Robe = 66,
        Silver_DG_Armor = 67,
        Dark_DG_Armor = 68,
        Blue_DG_Armor = 69,
        Armor_of_Yore = 70,
        Sator_Vest = 71,
        Rainbow_Dress = 72,
        Angel_Robe = 73,
        Armor_of_Legend = 74,
        Bandana = 76,
        Sallet = 77,
        Armet = 78,
        Knight_Helm = 79,
        Giganto_Helm = 80,
        Soul_Headband = 81,
        Felt_Hat = 82,
        Cape = 83,
        Tiara = 84,
        Jeweled_Crown = 85,
        Roses_Hair_Band = 86,
        Phoenix_Plume = 88,
        Legend_Casque = 89,
        Dragon_Helm = 90,
        Magical_Hat = 91,
        Leather_Boots = 93,
        Iron_Kneepiece = 94,
        Combat_Shoes = 95,
        Leather_Shoes = 96,
        Soft_Boots = 97,
        Stardust_Boots = 98,
        Magical_Greaves = 99,
        Dancers_Shoes = 100,
        Bandits_Shoes = 101,
        Poison_Guard = 103,
        Active_Ring = 104,
        Protector = 105,
        Panic_Guard = 106,
        Stun_Guard = 107,
        Bravery_Amulet = 108,
        Magic_Ego_Bell = 109,
        Destone_Amulet = 110,
        Power_Wrist = 111,
        Knight_Shield = 112,
        Magical_Ring = 113,
        Spiritual_Ring = 114,
        Attack_Badge = 115,
        Guard_Badge = 116,
        Giganto_Ring = 117,
        Elude_Cloak = 118,
        Spirit_Cloak = 119,
        Sages_Cloak = 120,
        Physical_Ring = 121,
        Amulet = 122,
        Wargods_Sash = 123,
        Spirit_Ring = 124,
        Therapy_Ring = 125,
        Mage_Ring = 126,
        Wargods_Amulet = 127,
        Talisman = 128,
        Holy_Ankh = 130,
        Dancers_Ring = 131,
        Bandits_Ring = 133,
        Red_Eye_Stone = 134,
        Jade_Stone = 135,
        Silver_Stone = 136,
        Darkness_Stone = 137,
        Blue_Sea_Stone = 138,
        Violet_Stone = 139,
        Golden_Stone = 140,
        Ruby_Ring = 142,
        Sapphire_Pin = 143,
        Rainbow_Earring = 144,
        Emerald_Earring = 146,
        Platinum_Collar = 148,
        Phantom_Shield = 149,
        Dragon_Shield = 150,
        Angel_Scarf = 151,
        Bracelet = 152,
        Fake_Power_Wrist = 153,
        Fake_Shield = 154,
        Wargod_Calling = 156,
        Ultimate_Wargod = 157,
        Detonate_Rock = 193,
        Spark_Net = 194,
        Burn_Out = 195,
        Pellet = 197,
        Spear_Frost = 198,
        Spinning_Gale = 199,
        Attack_Ball = 200,
        Trans_Light = 201,
        Dark_Mist = 202,
        Healing_Potion = 203,
        Depetrifier = 204,
        Mind_Purifier = 205,
        Body_Purifier = 206,
        Thunderbolt = 207,
        Meteor_Fall = 208,
        Gushing_Magma = 209,
        Dancing_Ray = 210,
        Spirit_Potion = 211,
        Panic_Bell = 212,
        Fatal_Blizzard = 214,
        Stunning_Hammer = 215,
        Black_Rain = 216,
        Poison_Needle = 217,
        Midnight_Terror = 218,
        Rave_Twister = 220,
        Total_Vanishing = 221,
        Angels_Prayer = 222,
        Charm_Potion = 223,
        Pandemonium = 224,
        Recovery_Ball = 225,
        Magic_Shield = 227,
        Material_Shield = 228,
        Sun_Rhapsody = 229,
        Smoke_Ball = 230,
        Healing_Fog = 231,
        Magic_Sig_Stone = 232,
        Healing_Rain = 233,
        Moon_Serenade = 234,
        Power_Up = 235,
        Power_Down = 236,
        Speed_Up = 237,
        Speed_Down = 238,
        Sachet = 240,
        Psyche_Bomb = 241,
        Burning_Wave = 242,
        Frozen_Jet = 243,
        Down_Burst = 244,
        Gravity_Grabber = 245,
        Spectral_Flash = 246,
        Night_Raid = 247,
        Flash_Hall = 248,
        Healing_Breeze = 249,
        Psyche_Bomb_X = 250,
        Invalid = 254,
        None = 255,
    }
    class Inventory
    {
        private SaveData saveData;
        private Int32 armorCountIndex = 0x0464;
        private Int32 itemCountIndex = 0x0466;
        private Int32 armorIndex = 0x0468;
        private Int32 itemIndex = 0x0569;
        private int armorSlots = 255;
        private int itemSlots = 32;
        private int armorStart = 0;
        private int armorEnd = 157;
        private int itemsStart = 193;
        private int itemsEnd = 250;

        public List<InventoryItem> armors = new List<InventoryItem>();
        public List<InventoryItem> usedItems = new List<InventoryItem>();

        public uint armorCount;
        public uint itemCount;

        public Inventory(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        public List<InventoryItem> getItemList()
        {
            List<InventoryItem> output = new List<InventoryItem>();
            output.Add(InventoryItem.None);
            List<InventoryItem> allItemCodes = new List<InventoryItem>((InventoryItem[])Enum.GetValues(typeof(InventoryItem)));
            List<InventoryItem> usedItemCodes = allItemCodes.FindAll(
                delegate(InventoryItem itemCodes)
                {
                    return (uint)itemCodes >= itemsStart && (uint)itemCodes <= itemsEnd;
                }
                );
            List<InventoryItem> armorItemCodes = allItemCodes.FindAll(
                delegate (InventoryItem itemCodes)
                {
                    return (uint)itemCodes >= armorStart && (uint)itemCodes <= armorEnd;
                }
                );
            output.AddRange(usedItemCodes);
            output.AddRange(armorItemCodes);
            output.Add(InventoryItem.Invalid);
            return output;
        }

        public List<InventoryItem> getArmorList()
        {
            List<InventoryItem> output = new List<InventoryItem>();
            output.Add(InventoryItem.None);
            List<InventoryItem> allItemCodes = new List<InventoryItem>((InventoryItem[])Enum.GetValues(typeof(InventoryItem)));
            List<InventoryItem> usedItemCodes = allItemCodes.FindAll(
                delegate (InventoryItem itemCodes)
                {
                    return (uint)itemCodes >= itemsStart && (uint)itemCodes <= itemsEnd;
                }
                );
            List<InventoryItem> armorItemCodes = allItemCodes.FindAll(
                delegate (InventoryItem itemCodes)
                {
                    return (uint)itemCodes >= armorStart && (uint)itemCodes <= armorEnd;
                }
                );
            output.AddRange(armorItemCodes);
            output.AddRange(usedItemCodes);
            output.Add(InventoryItem.Invalid);
            return output;
        }

        public InventoryItem getItemFromCode(uint itemCode)
        {
            if(Enum.IsDefined(typeof(InventoryItem), itemCode))
            {
                return (InventoryItem)itemCode;
            }
            return InventoryItem.Invalid;
        }

        private void loadData()
        {
            for(int armorIter = armorIndex; armorIter < (armorIndex + armorSlots); ++armorIter)
            {
                uint itemCode = saveData.load8bitUint(armorIter);
                armors.Add(getItemFromCode(itemCode));
            }

            for (int itemIter = itemIndex; itemIter < (itemIndex + itemSlots); ++itemIter)
            {
                uint itemCode = saveData.load8bitUint(itemIter);
                usedItems.Add(getItemFromCode(itemCode));
            }

            armorCount = saveData.load8bitUint(armorCountIndex);
            itemCount = saveData.load8bitUint(itemCountIndex);
        }

        public void updateData()
        {
            for (int armorSlot = 0; armorSlot < armorSlots; ++armorSlot)
            {
                saveData.save8bitUint(armorIndex + armorSlot, (uint)armors[armorSlot]);
            }
            for (int itemSlot = 0; itemSlot < itemSlots; ++itemSlot)
            {
                saveData.save8bitUint(itemIndex + itemSlot, (uint)usedItems[itemSlot]);
            }

            saveData.save8bitUint(armorCountIndex, armorCount);
            saveData.save8bitUint(itemCountIndex, itemCount);
        }
    }
}
