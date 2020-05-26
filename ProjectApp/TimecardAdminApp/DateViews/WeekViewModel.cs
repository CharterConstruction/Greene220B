using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimecardRepository.DateViews;

namespace TimecardAdminApp.DateViews
{
    public class WeekViewModel : BindableBase
    {
        private DateViewRepository dateRepo = new DateViewRepository();

        internal DateTime Today;
        internal int weekDayToday;
        public int weekEndDateKey;                       

        internal bool isLastWeek;
        internal List<DateView> lastWeek;

        internal bool isThisWeek;
        internal List<DateView> thisWeek;

        internal bool isNextWeek;
        internal List<DateView> nextWeek;

        public List<DateView> selectedWeek;


        public string SundayLabel       { get; private set; }
        public string MondayLabel       { get; private set; }
        public string TuesdayLabel      { get; private set; }
        public string WednesdayLabel    { get; private set; }
        public string ThursdayLabel     { get; private set; }
        public string FridayLabel       { get; private set; }
        public string SaturdayLabel     { get; private set; }


        public WeekViewModel()
        {
            LoadDates();
        }

        public void LoadDates()
        {
            var today = dateRepo.GetAll().Where(d => d.IsToday == true).FirstOrDefault();
            var weekEndDateQuery = dateRepo.Query().Where(t => t.IsToday == true);

            if (today != null)
            {
                int thisWeekEndDateKey = int.Parse(today.CurrentWeekEndDateKey.ToString());
                thisWeek = dateRepo.Query().Where(d => d.CurrentWeekEndDateKey == thisWeekEndDateKey).Select(t => t.ToUIModel()).ToList();
                lastWeek = dateRepo.Query().Where(d => d.CurrentWeekEndDateKey == (thisWeekEndDateKey - 7)).Select(t => t.ToUIModel()).ToList();
                nextWeek = dateRepo.Query().Where(d => d.CurrentWeekEndDateKey == (thisWeekEndDateKey + 7)).Select(t => t.ToUIModel()).ToList();

                weekDayToday = (int)DateTime.Now.DayOfWeek;
                if (weekDayToday <= 1)
                    UpdateWeek("LastWeek");
                else
                    UpdateWeek("ThisWeek");
            }
        }


        internal void UpdateWeek(string relativeWeek)
        {
            isLastWeek = false;
            isThisWeek = false;
            isNextWeek = false;


            switch (relativeWeek)
            {
                case "LastWeek":
                    selectedWeek = lastWeek;
                    isLastWeek = true;
                    break;

                case "ThisWeek":
                    selectedWeek = thisWeek;
                    isThisWeek = true;
                    break;

                case "NextWeek":
                    selectedWeek = nextWeek;
                    isNextWeek = true;
                    break;
            }
            SetWeekEndDateKey();
        }


        internal void SetWeekEndDateKey()
        {
            weekEndDateKey = int.Parse(selectedWeek.Where(d => d.IsWeekEndDate == true).FirstOrDefault().CurrentWeekEndDateKey.ToString());

            SundayLabel     = selectedWeek.Where(t => t.Weekday == 1).FirstOrDefault().ShortDateLabel;  
            MondayLabel     = selectedWeek.Where(t => t.Weekday == 2).FirstOrDefault().ShortDateLabel;  
            TuesdayLabel    = selectedWeek.Where(t => t.Weekday == 3).FirstOrDefault().ShortDateLabel;  
            WednesdayLabel  = selectedWeek.Where(t => t.Weekday == 4).FirstOrDefault().ShortDateLabel;  
            ThursdayLabel   = selectedWeek.Where(t => t.Weekday == 5).FirstOrDefault().ShortDateLabel;  
            FridayLabel     = selectedWeek.Where(t => t.Weekday == 6).FirstOrDefault().ShortDateLabel;  
            SaturdayLabel   = selectedWeek.Where(t => t.Weekday == 7).FirstOrDefault().ShortDateLabel;

        }



    }
}
