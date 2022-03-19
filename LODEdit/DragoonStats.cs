using System;

namespace LODEdit
{
    public enum DragoonSpirit
    {
        Red_Eyed = 1,
        Blue_Sea = 2,
        Jade = 4,
        Golden = 8,
        Violet = 16,
        Silver = 32,
        Darkness = 64,
        Divine = 128
    }

    internal class DragoonStats
    {
        private readonly SaveData saveData;
        private const int SaveInfoIndex = 0x0224;
        private const int GameIndex = 0x041C;

        private uint dragoonState;

        public DragoonStats(SaveData saveData)
        {
            this.saveData = saveData;

            LoadData();
        }

        public void AddDragoonSpirit(DragoonSpirit dragoonSpirit)
        {
            dragoonState |= (uint)dragoonSpirit;
        }

        public void RemoveDragoonSpirit(DragoonSpirit dragoonSpirit)
        {
            dragoonState &= ~(uint)dragoonSpirit;
        }

        public bool HasDragoonSpirit(DragoonSpirit dragoonSpirit)
        {
            return (dragoonState & (uint)dragoonSpirit) == (uint)dragoonSpirit;
        }

        public DragoonSpirit GetFromIndex(int index)
        {
            var dsArr = (DragoonSpirit[])Enum.GetValues(typeof(DragoonSpirit));
            return dsArr[index];
        }

        private void LoadData()
        {
            dragoonState = saveData.Load8BitUint(GameIndex);
        }

        public void UpdateData()
        {
            saveData.Save8BitUint(SaveInfoIndex, dragoonState);
            saveData.Save8BitUint(GameIndex, dragoonState);
        }
    }
}
