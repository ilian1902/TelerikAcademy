namespace DefiningClassesPartOne
{
    using System;
    using System.Globalization;

    class GSMCallHistoryTest // Problem 12
    {
        public void CallHistoryTest()
        {
            var peshoPhone = new GSM("HD2", "HTC", 100000M, "Pesho",
            new Battery("PeshoBattery", 31231, 31312, BatteryType.LiIon),
            new Display(10f, 20000000));
            peshoPhone.AddCall("739172937193", 105);
            peshoPhone.AddCall("0854646466464", 2000);
            peshoPhone.AddCall("0864646464", 15);
            peshoPhone.AddCall("0888556464", 62);
            peshoPhone.ShowHistory();
            decimal peshoBill = peshoPhone.CalculateTotalPrice(0.37M);
            Console.WriteLine("{0} has to pay {1:F2}{2}", peshoPhone.Owner, peshoBill,
            RegionInfo.CurrentRegion.CurrencySymbol);
            peshoPhone.DeleteCall("0854646466464");
            peshoPhone.ShowHistory();
            peshoBill = peshoPhone.CalculateTotalPrice(0.37M);
            Console.WriteLine("{0} has to pay {1:F2}{2}", peshoPhone.Owner, peshoBill,
            RegionInfo.CurrentRegion.CurrencySymbol);
            peshoPhone.ClearCallHistory();
            peshoPhone.ShowHistory();
        }
    }
}
