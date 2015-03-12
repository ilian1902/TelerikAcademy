namespace DefiningClassesPartOne
{
    using System;
    using System.Text;

    public class Calls //Problem 8 
    {
        private DateTime dateAndime;
        private string dialedPhoneNumber;
        private int duration;
        public Calls(string diledNumber, int duration)
        {
            this.DateAndTime = DateTime.Now;
            this.DialedPhoneNumber = diledNumber;
            this.Duration = duration;
        }
        public DateTime DateAndTime
        {
            get
            {
                return this.dateAndime;
            }
            private set
            {
                this.dateAndime = value;
            }
        }
        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            private set
            {
                this.dialedPhoneNumber = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.duration;
            }
            private set
            {
                this.duration = value;
            }
        }
        public override string ToString()
        {
            var sbCallInfo = new StringBuilder();
            sbCallInfo.AppendFormat("Number: {0} - Duration: {1} seconds", this.DialedPhoneNumber, this.Duration);
            return sbCallInfo.ToString();
        }
    }   
}
