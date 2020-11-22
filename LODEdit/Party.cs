using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    class Party
    {
        private SaveData saveData;
        private Int32 party1saveInfoIndex = 0x0208;
        private Int32 party1gameIndex = 0x0308;
        private Int32 party2saveInfoIndex = 0x020C;
        private Int32 party2gameIndex = 0x030C;
        private Int32 party3saveInfoIndex = 0x0210;
        private Int32 party3gameIndex = 0x0310;

        public CharacterID party1;
        public CharacterID party2;
        public CharacterID party3;

        public Party(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        private void loadData()
        {
            party1 = (CharacterID)saveData.load32bitInt(party1gameIndex);
            party2 = (CharacterID)saveData.load32bitInt(party2gameIndex);
            party3 = (CharacterID)saveData.load32bitInt(party3gameIndex);
        }

        public void updateData()
        {
            saveData.save32bitInt(party1saveInfoIndex, (int)party1);
            saveData.save32bitInt(party1gameIndex, (int)party1);
            saveData.save32bitInt(party2saveInfoIndex, (int)party2);
            saveData.save32bitInt(party2gameIndex, (int)party2);
            saveData.save32bitInt(party3saveInfoIndex, (int)party3);
            saveData.save32bitInt(party3gameIndex, (int)party3);
        }
    }
}
