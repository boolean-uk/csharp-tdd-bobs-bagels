


namespace csharp_tdd_bobs_bagels.Main
{
    public class Basket
    {
        private List<string> _basket = [];
        public bool Add(string bagel)
        {
            if (basket.Capacity == basket.Count()) return false;
            _basket.Add(bagel);
            return true;
        }

        public bool Remove(string bagel)
        {
            return _basket.Remove(bagel);
        }

        public List<string> basket { get { return _basket; } }
    }
}
