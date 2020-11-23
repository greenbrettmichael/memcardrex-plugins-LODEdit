using System;
using System.Collections.Generic;
using System.Text;

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

    class DragoonStats
    {
        private SaveData saveData;
        private Int32 saveInfoIndex = 0x0224;
        private Int32 gameIndex = 0x041C;

        private uint dragoonState;

        public DragoonStats(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        public void addDragoonSpirit(DragoonSpirit dragoonSpirit)
        {
            dragoonState |= (uint)dragoonSpirit;
        }

        public void removeDragoonSpirit(DragoonSpirit dragoonSpirit)
        {
            dragoonState &= ~(uint)dragoonSpirit;
        }

        public bool hasDragoonSpirit(DragoonSpirit dragoonSpirit)
        {
            return (dragoonState & (uint)dragoonSpirit) == (uint)dragoonSpirit;
        }

        public DragoonSpirit getFromIndex(int index)
        {
            DragoonSpirit[] dsArr = (DragoonSpirit[])Enum.GetValues(typeof(DragoonSpirit));
            return dsArr[index];
        }

        private void loadData()
        {
            dragoonState = saveData.load8bitUint(gameIndex);
        }

        public void updateData()
        {
            saveData.save8bitUint(saveInfoIndex, dragoonState);
            saveData.save8bitUint(gameIndex, dragoonState);
        }
    }
}
