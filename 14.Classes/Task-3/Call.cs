namespace Task_3
{
    public class Call
    {
        private string date;
        private string time;
        private int duration;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public Call(string date, string time, int duration)
        {
            this.date = date;
            this.time = time;
            this.duration = duration;
        }
    }
}