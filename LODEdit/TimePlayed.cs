using System;
using System.Collections.Generic;
using System.Text;

namespace LODEdit
{
    class TimePlayed
    {
        private SaveData saveData;
        private Int32 saveInfoIndex = 0x0220;
        private Int32 gameIndex = 0x0320;

        public int hours;
        public int minutes;
        public int seconds;

        public TimePlayed(SaveData saveData)
        {
            this.saveData = saveData;

            loadData();
        }

        private void loadData()
        {
            int frames = saveData.load32bitInt(gameIndex);
            TimeSpan gameTimeSpan = TimeSpan.FromSeconds(frames / 60);
            hours = Convert.ToInt32(Math.Floor(gameTimeSpan.TotalHours));
            minutes = gameTimeSpan.Minutes;
            seconds = gameTimeSpan.Seconds;
        }

        public void updateData()
        {
            int frames = hours * 60; // hours to minutes
            frames += minutes;
            frames *= 60; // minutes to seconds
            frames += seconds;
            frames *= 60; // seconds to frames
            saveData.save32bitInt(gameIndex, frames);
            saveData.save32bitInt(saveInfoIndex, frames);
        }
    }
}
