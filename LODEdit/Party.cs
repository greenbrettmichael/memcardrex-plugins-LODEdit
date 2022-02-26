namespace LODEdit
{
    internal class Party
    {
        private readonly SaveData saveData;
        private const int Party1SaveInfoIndex = 0x0208;
        private const int Party1GameIndex = 0x0308;
        private const int Party2SaveInfoIndex = 0x020C;
        private const int Party2GameIndex = 0x030C;
        private const int Party3SaveInfoIndex = 0x0210;
        private const int Party3GameIndex = 0x0310;

        public CharacterId party1;
        public CharacterId party2;
        public CharacterId party3;

        public Party(SaveData saveData)
        {
            this.saveData = saveData;

            LoadData();
        }

        private void LoadData()
        {
            party1 = (CharacterId) saveData.Load32BitInt(Party1GameIndex);
            party2 = (CharacterId) saveData.Load32BitInt(Party2GameIndex);
            party3 = (CharacterId) saveData.Load32BitInt(Party3GameIndex);
        }

        public void UpdateData()
        {
            saveData.Save32BitInt(Party1SaveInfoIndex, (int) party1);
            saveData.Save32BitInt(Party1GameIndex, (int) party1);
            saveData.Save32BitInt(Party2SaveInfoIndex, (int) party2);
            saveData.Save32BitInt(Party2GameIndex, (int) party2);
            saveData.Save32BitInt(Party3SaveInfoIndex, (int) party3);
            saveData.Save32BitInt(Party3GameIndex, (int) party3);
        }
    }
}