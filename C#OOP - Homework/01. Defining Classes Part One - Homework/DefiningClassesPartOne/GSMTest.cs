namespace DefiningClassesPartOne
{
    using System;

    // Problem 7
    public class GSMTest
    {
        public void GSMArrayTest()
        {
            GSM[] tests = new GSM[4];
            tests[0] = new GSM("3310", "Nokia");
            tests[1] = new GSM("Desire", "HTC", 200M, "Gencho",
            new Battery(),
            new Display(5f, 1400000));
            tests[2] = new GSM("3310", "Nokia", 30M, "Pesho",
            new Battery("CC23", 100000, 100000, BatteryType.NiMH),
            new Display());
            tests[3] = new GSM("5115", "Nokia", 25M, "Gosho",
            new Battery("1234", 313, 233, BatteryType.NiCd),
            new Display(4f, 3131321));
            foreach (var GSM in tests)
            {
                Console.WriteLine(GSM);
            }
        }
        public void GSMStaticTest()
        {
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
