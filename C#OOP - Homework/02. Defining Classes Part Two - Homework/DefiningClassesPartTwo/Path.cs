namespace DefiningClassesPartTwoProblem1234
{
    using System.Collections.Generic;

    // Problem 4 
    // Create a class Path to hold a sequence of points in the 3D space.
    // Create a static class PathStorage with static methods to save and load paths from a text file.
    // Use a file format of your choice.

    public class Path
    {
        private List<Point3D> pathList;

        public List<Point3D> PathList
        {
            get { return this.pathList; }
            set { this.pathList = value; }
        }

        public Path()
        {
            this.PathList = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.PathList.Add(point);
        }

        public void Remove(Point3D point)
        {
            this.PathList.Remove(point);
        }
    }
}
