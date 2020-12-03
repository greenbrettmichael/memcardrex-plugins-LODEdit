using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    enum SaveLocation
    {
        Forest = 1,
        Forest_2 = 2,
        Seles = 3,
        Hellena_Prison = 4,
        Prairie = 5,
        Cave = 6,
        Bale = 8,
        Indels_Castle = 9,
        Town_Of_Hoax = 10,
        Marshland = 11,
        Volcano_Villude = 12,
        Nest_Of_Dragon = 13,
        Lohan = 14,
        Shirleys_Shrine = 15,
        Kazas = 17,
        Black_Castle = 18,
        Fletz = 19,
        Twin_Castle = 20,
        Barrens = 21,
        Donau = 22,
        Valley = 23,
        Giganto_Home = 24,
        The_Queen_Fury = 26,
        Phantom_Ship = 27,
        Lidiera = 28,
        Undersea_Cavern = 29,
        Feuno = 30,
        Prison_Island = 31,
        Furni = 32,
        Evergreen_Forest = 33,
        Deningrad = 34,
        Crystal_Palace = 35,
        Neet = 36,
        Wingly_Forest = 37,
        Forbidden_Land = 38,
        Mountain_Of_Mortal_Dragon = 40,
        Kashua_Glacier = 42,
        Flanvel_Tower = 43,
        Snowfield = 44,
        Fort_Magrad = 45,
        Vellweb = 46,
        Death_Frontier = 48,
        Ulara = 49,
        Zenebatos = 50,
        Mayfil = 51,
        Rouge = 53,
        Aglis = 54,
        Divine_Tree = 55,
        Moon = 56,
        South_Of_Serdio = 256,
        North_Of_Serdio = 257,
        Tiberoa = 258,
        Illisa_Bay = 259,
        Mille_Seseau = 260,
        Gloriano = 261,
        Death_Frontier_Outside = 262,
        Endiness = 263
    }

    class Warp
    {
        private SaveData saveData;
        private Int32 saveInfoIndex = 0x022C;

        public int saveLocation;

        public Warp(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        private void loadData()
        {
            saveLocation = saveData.load16bitInt(saveInfoIndex);
        }

        public void updateData()
        {
            saveData.save16bitInt(saveInfoIndex, saveLocation);
        }
    }
}
