namespace DefiningClassesPartTwoProblem1234
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class DefiningClassesPartTwoMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Point3D firstTestPoint = new Point3D(1.5, 2.5, 3.5);
            Point3D secondTestPoint = new Point3D(-1, -4, 7);
            Point3D thirdTestPoint = new Point3D(1, 2, 3);
            
            Path testPath = new Path(); 
            testPath.AddPoint(firstTestPoint);
            testPath.AddPoint(secondTestPoint);
            testPath.AddPoint(thirdTestPoint);
            
            PathStorage.SavePath(testPath, "sample"); //saving the test points to the file "pathsample.txt"
            Path loadedPath = PathStorage.LoadPath(@"../../pathsample.txt"); //loading the saved file and printing the points
            for (int i = 0; i < loadedPath.PathList.Count; i++)
            {
                Console.WriteLine(loadedPath.PathList[i]);
            }
        }
    }
}
