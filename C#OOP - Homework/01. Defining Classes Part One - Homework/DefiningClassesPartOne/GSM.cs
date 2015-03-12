namespace DefiningClassesPartOne
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;

    public class GSM
    {
        // Problem 6
        private static GSM IPhone4s = new GSM("4S", "Iphone", 400M, "Ivancho",
                                      new Battery("iBattery", 100, 48, BatteryType.LiIon),
                                      new Display(4.0f, 16000000));
        
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Calls> callHistory;

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 150, "Ivan", new Battery(), new Display())
        {

        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Calls>();
        }

        public static GSM IPhone4S
        {
            get
            {
                return IPhone4s;
            }
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        // Problem 10
        public void AddCall(string dialedNumber, int duration)
        {
            Calls call = new Calls(dialedNumber, duration);
            this.callHistory.Add(call);
        }

        public void DeleteCall(string dialedNumber)
        {
            callHistory.Remove(callHistory.Find(x => x.DialedPhoneNumber.Contains(dialedNumber)));
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void ShowHistory()
        {
            if (callHistory.Count > 0)
            {
                foreach (var call in callHistory)
                {
                    Console.WriteLine(call.ToString());
                }
            }
            else
            {
                Console.WriteLine("History is empty!");
            }
        }

        // Problem 11
        public decimal CalculateTotalPrice(decimal price)
        {
            decimal sum = 0;
            decimal pricePerSecond = price / 60;
            foreach (var call in this.callHistory)
            {
                decimal callPrice = pricePerSecond * call.Duration;
                sum += callPrice;
            }
            return sum;
        }

        // Problem 4
        public override string ToString()
        {
            var sbInfo = new StringBuilder();
            sbInfo.AppendFormat("Model: {0}", this.model);
            sbInfo.AppendLine();
            sbInfo.AppendFormat("Manufacturer: {0}", this.manufacturer);
            sbInfo.AppendLine();
            sbInfo.AppendFormat("Price: {0}{1}", this.price, RegionInfo.CurrentRegion.CurrencySymbol);
            sbInfo.AppendLine();
            sbInfo.AppendFormat("Owner: {0}", this.owner);
            sbInfo.AppendLine();
            sbInfo.Append("Battery:");
            sbInfo.AppendLine();
            sbInfo.AppendFormat(" Model: {0}", this.Battery.Model);
            sbInfo.AppendLine();
            sbInfo.AppendFormat(" Hours Idle: {0}h", this.Battery.HoursIdle);
            sbInfo.AppendLine();
            sbInfo.AppendFormat(" Hours Talk: {0}h", this.Battery.HoursTalk);
            sbInfo.AppendLine();
            sbInfo.AppendFormat(" Battery type: {0}", this.Battery.BatteryType);
            sbInfo.AppendLine();
            sbInfo.Append("Display: ");
            sbInfo.AppendLine();
            sbInfo.AppendFormat(" Size: {0}\"", this.Display.Size);
            sbInfo.AppendLine();
            sbInfo.AppendFormat(" Number of colors: {0}", this.Display.NumberOfColors);
            sbInfo.AppendLine();
            string info = sbInfo.ToString();
            return info;
        }
    }
}
