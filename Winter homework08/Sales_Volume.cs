namespace Winter_homework08
{
    internal class Sales_Volume
    {
        public string Product { get; set; }
        public int Price { get; set; }
        public int Totals { get; set; }
        public int Sum
        {
            get { return Price * Totals; }
        }
    }
}