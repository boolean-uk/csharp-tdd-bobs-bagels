1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.


```
class Basket
	PROPERTIES:
	public readonly string[] bagelTypes {plain, blueberry, sesameSeed , jalapeno} // array of bagel types
	public readonly List<string> _basketList
	private int _maxCapacity = 4
	

	METHODS:
	public string Add(string bagelType)	
		// If bagle is added to basket: return "{bagelType} was added to basket"
		// If bagle type dosen't exist: return "{bagelType} is not a valid bagle type"
		// If basket is full: return "Basket is full"

	public bool Remove(string bagelType)
		// Return true and remove a specific bagle if it exists in basketList
		// Return false if the specific bagle dosen't exists in basketList

	public bool ChangeCapacity(int newCapacity)
		// return true if capacity is increased
		// return false if newCapacity < 1 or newCapacity < nr of basketLists items

```