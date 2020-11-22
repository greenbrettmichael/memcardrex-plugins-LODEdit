using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    public class SaveData
    {
        private Int32 saveSlotOffset = 0;
        private byte[] saveData = null;

        public SaveData(byte[] saveData, int currentSaveSlot)
        {
            this.saveData = saveData;
            this.saveSlotOffset = currentSaveSlot * 0x600;
        }
        public byte[] getData()
        {
            return saveData;
        }

        public int load8bitInt(Int32 index)
        {
            return saveData[index + saveSlotOffset];
        }

        public int load16bitInt(Int32 index)
        {
            return load8bitInt(index) | saveData[index + saveSlotOffset + 1] << 8;
        }

        public uint load16bitUint(Int32 index)
        {
            return (uint)load16bitInt(index);
        }

        public void save16bitUint(Int32 index, uint value)
        {
            saveData[index + saveSlotOffset] = (byte)(value & 0xFF);
            saveData[index + saveSlotOffset + 1] = (byte)((value & 0xFF00) >> 8);
        }
    }
}
