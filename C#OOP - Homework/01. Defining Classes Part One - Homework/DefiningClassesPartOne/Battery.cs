namespace DefiningClassesPartOne
{
    // Problem 1, 2, 3, 4, 5
    public class Battery
    {
        private const string MODEL = "Super - HI";
        private const double DEFAULT_HOURS_IDLE = 80;
        private const double DEFAULT_HOURS_TALK = 50;
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;
        public Battery()
            : this(MODEL, DEFAULT_HOURS_IDLE, DEFAULT_HOURS_TALK, new BatteryType()) { }
        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = type;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
            }
        }
        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
    }
}
