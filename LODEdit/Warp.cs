using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    enum SaveLocation
    {
        Forest = 1,
        Seles = 3,
        South_Of_Serdio = 256,
        Death_Frontier = 262
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
