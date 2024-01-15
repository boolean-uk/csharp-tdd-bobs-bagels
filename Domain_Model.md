
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

Class Basket

enum BagleType
{
	Plain,
	Sourdough,
	gluten-free
}

struct Bagle
{
	BagleType bagleType;

	Bagle(_bagleType)
	{
		bagleType = _bagleType;
	}
}

Properties

public List<Bagle>() basket;
public int basketLimit = 4;



Methods

public string AddBagleToBasket(bagletype) adds a bagle to the basket of type(bagletype).
-returns message if bagle was added
-returns message if basket tries to exede 4 bagels

public string RemoveBagle(bagletype) removes a bagle from the basket.
-returns message if bagle was removerd.
-returns error of bagletype is not in basket.

public string ChangeBasketSize(int newBasketSize) changes the amount of bagles the basket can hold. 
-returns message that the basketsize was changed from old to new size.



