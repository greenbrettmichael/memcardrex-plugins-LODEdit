namespace LODEdit
{
    public class SaveData
    {
        private readonly int saveSlotOffset;
        private readonly byte[] saveData;

        public SaveData(byte[] saveData, int currentSaveSlot)
        {
            this.saveData = saveData;
            saveSlotOffset = currentSaveSlot * 0x600;
        }
        public byte[] GetData()
        {
            return saveData;
        }

        public int Load8BitInt(int index)
        {
            return saveData[index + saveSlotOffset];
        }

        public int Load16BitInt(int index)
        {
            return Load8BitInt(index) | saveData[index + saveSlotOffset + 1] << 8;
        }

        public int Load24BitInt(int index)
        {
            return Load16BitInt(index) | saveData[index + saveSlotOffset + 2] << 16;
        }

        public int Load32BitInt(int index)
        {
            return Load24BitInt(index) | saveData[index + saveSlotOffset + 3] << 24;
        }

        public uint Load8BitUint(int index)
        {
            return (uint)Load8BitInt(index);
        }

        public uint Load16BitUint(int index)
        {
            return (uint)Load16BitInt(index);
        }

        public void Save8BitInt(int index, int value)
        {
            saveData[index + saveSlotOffset] = (byte)(value & 0xFF);
        }

        public void Save16BitInt(int index, int value)
        {
            Save8BitInt(index, value);
            saveData[index + saveSlotOffset + 1] = (byte)((value & 0xFF00) >> 8);
        }

        public void Save8BitUint(int index, uint value)
        {
            saveData[index + saveSlotOffset] = (byte)(value & 0xFF);
        }

        public void Save16BitUint(int index, uint value)
        {
            Save8BitUint(index, value);
            saveData[index + saveSlotOffset + 1] = (byte)((value & 0xFF00) >> 8);
        }

        public void Save32BitInt(int index, int value)
        {
            Save16BitInt(index, value);
            saveData[index + saveSlotOffset + 2] = (byte)((value & 0xFF0000) >> 16);
            saveData[index + saveSlotOffset + 3] = (byte)((value & 0xFF000000) >> 24);
        }
    }
}
