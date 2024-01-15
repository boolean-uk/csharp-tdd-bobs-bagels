namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        public List<string> Items { get; set; }
        public Basket()
        {
            Items = new List<string>();
        }
        public void AddBagel(string bagel)
        {
            Items.Add(bagel);
        }

        public List<string> GetBagels()
        {
            return Items;
        }
    }
}
