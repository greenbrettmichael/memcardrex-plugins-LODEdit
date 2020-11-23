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

        public int load24bitInt(Int32 index)
        {
            return load16bitInt(index) | saveData[index + saveSlotOffset + 2] << 16;
        }

        public int load32bitInt(Int32 index)
        {
            return load24bitInt(index) | saveData[index + saveSlotOffset + 3] << 24;
        }

        public uint load8bitUint(Int32 index)
        {
            return (uint)load8bitInt(index);
        }

        public uint load16bitUint(Int32 index)
        {
            return (uint)load16bitInt(index);
        }

        public void save8bitInt(Int32 index, int value)
        {
            saveData[index + saveSlotOffset] = (byte)(value & 0xFF);
        }

        public void save16bitInt(Int32 index, int value)
        {
            save8bitInt(index, value);
            saveData[index + saveSlotOffset + 1] = (byte)((value & 0xFF00) >> 8);
        }

        public void save8bitUint(Int32 index, uint value)
        {
            saveData[index + saveSlotOffset] = (byte)(value & 0xFF);
        }

        public void save16bitUint(Int32 index, uint value)
        {
            save8bitUint(index, value);
            saveData[index + saveSlotOffset + 1] = (byte)((value & 0xFF00) >> 8);
        }

        public void save32bitInt(Int32 index, int value)
        {
            save16bitInt(index, value);
            saveData[index + saveSlotOffset + 2] = (byte)((value & 0xFF0000) >> 16);
            saveData[index + saveSlotOffset + 3] = (byte)((value & 0xFF000000) >> 24);
        }
    }
}
