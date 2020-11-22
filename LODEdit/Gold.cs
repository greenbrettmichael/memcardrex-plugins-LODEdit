using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    class Gold
    {
        private SaveData saveData;
        private Int32 saveInfoIndex = 0x021C;
        private Int32 gameIndex = 0x0314;

        public uint gold;

        public Gold(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        private void loadData()
        {
            gold = saveData.load16bitUint(gameIndex);
        }

        public void updateData()
        {
            saveData.save16bitUint(saveInfoIndex, gold);
            saveData.save16bitUint(gameIndex, gold);
        }
    }
}
