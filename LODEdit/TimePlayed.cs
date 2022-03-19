using System;

namespace LODEdit
{
    internal class TimePlayed
    {
        private readonly SaveData saveData;
        private const int SaveInfoIndex = 0x0220;
        private const int GameIndex = 0x0320;

        public int hours;
        public int minutes;
        public int seconds;

        public TimePlayed(SaveData saveData)
        {
            this.saveData = saveData;

            LoadData();
        }

        private void LoadData()
        {
            var frames = saveData.Load32BitInt(GameIndex);
            var gameTimeSpan = TimeSpan.FromSeconds((double)frames / 60);
            hours = Convert.ToInt32(Math.Floor(gameTimeSpan.TotalHours));
            minutes = gameTimeSpan.Minutes;
            seconds = gameTimeSpan.Seconds;
        }

        public void UpdateData()
        {
            var frames = hours * 60; // hours to minutes
            frames += minutes;
            frames *= 60; // minutes to seconds
            frames += seconds;
            frames *= 60; // seconds to frames
            saveData.Save32BitInt(GameIndex, frames);
            saveData.Save32BitInt(SaveInfoIndex, frames);
        }
    }
}
