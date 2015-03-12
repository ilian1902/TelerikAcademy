namespace DefiningClassesPartOne
{
    public class Display // Problem 1, 2, 3, 4, 5
    {
        private float size;
        private int numberOfColors;
        public Display()
        {
        }
        public Display(float size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
        public float Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }
    }
}
