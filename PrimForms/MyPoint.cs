namespace PrimForms
{
    public class MyPoint
    {
        public int X;
        public int Y;
        public int Number;
        public bool white = true;

        public MyPoint(int X, int Y, int Number)
        {
            this.X = X;
            this.Y = Y;
            this.Number = Number;
            white = true;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }
}