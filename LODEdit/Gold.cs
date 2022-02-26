namespace LODEdit
{
    internal class Gold
    {
        private readonly SaveData saveData;
        private const int SaveInfoIndex = 0x021C;
        private const int GameIndex = 0x0314;

        public uint gold;

        public Gold(SaveData saveData)
        {
            this.saveData = saveData;

            LoadData();
        }

        private void LoadData()
        {
            gold = saveData.Load16BitUint(GameIndex);
        }

        public void UpdateData()
        {
            saveData.Save16BitUint(SaveInfoIndex, gold);
            saveData.Save16BitUint(GameIndex, gold);
        }
    }
}
