namespace tdd_bobs_bagels.CSharp.Main;

public class Core
{
    List<string> bagels;
    int capacity;

    public Core()
    {
        bagels = new List<string>();
        capacity = 3;
    }

    public bool add(string bagel)
    {
        if (bagels.Count < capacity)
        {
            bagels.Add(bagel);
            return true;
        }
        return false;
    }

    public bool remove(string bagel)
    {
        if (bagels.Contains(bagel))
        {
            bagels.Remove(bagel);
            return true;
        }
        return false;
    }

    public void setCapacity(int newCapacity)
    {
        capacity = newCapacity;
    }
}
