namespace DefiningClassesPartTwoProblem1234
{
    using System;
    using System.Text;

    public struct Point3D //Problem 1 
    {
        private static readonly Point3D o; //Problem 2 
                                           // Add a private static read-only field to hold the start of 
                                           //the coordinate system – the point O{0, 0, 0}.
        private double x;
        private double y;
        private double z;

        public static Point3D O //Problem 2 
        {
            get { return o; }
        }

        static Point3D() // Problem 2
        {
            o = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }

        public double X
        {
            get { return this.x; }
            private set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            private set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            private set { this.z = value; }
        }

        public override string ToString()
        {
            return string.Format("X = {0} Y = {1} Z = {2}", this.X, this.Y, this.Z);
        }

        public static Point3D Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }
                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }
            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
