namespace tdd_bobs_bagels.CSharp.Main
{
    public class Core
    {
        public class Basket
        {
            public List<string> Bagels { get; set; }
            public int Capacity { get; private set; }

            public Basket() 
            {
                Bagels = new List<string>();
                Capacity = 6;
            }

            public void Add(string bagel)
            {
                if (Bagels.Count < Capacity)
                    Bagels.Add(bagel);
                else
                    Console.WriteLine("Basket is full");
            }

            public void Remove(string bagel)
            {
                if (Bagels.Contains(bagel))
                    Bagels.Remove(bagel);
                else
                    Console.WriteLine($"{bagel} was not found in basket");
            }

            public void ChangeCapacity(int capacity)
            {
                Capacity = capacity;
            }
        }
    }
}
