
namespace PrimForms
{
    public class Edge
    {
        public int v1, v2;

        public double weight;

        public Edge(int v1, int v2, double weight)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.weight = weight;
        }

        public override string ToString()
        {
            return v1 + "," + v2 + "; weight=" + weight;
        }
    }


}
