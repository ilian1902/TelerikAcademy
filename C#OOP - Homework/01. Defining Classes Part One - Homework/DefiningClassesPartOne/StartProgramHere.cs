namespace DefiningClassesPartOne
{
    using System;

    class StartProgramHere
    {
        static void Main()
        {
            var tester = new GSMTest();
            tester.GSMArrayTest();
            tester.GSMStaticTest();
            var chTester = new GSMCallHistoryTest();
            chTester.CallHistoryTest();
        }
    }
}
