Class Basket

 -- Properties --
private List<string> _bagels;
private int _capacity 
public int Capacity {set _capacity}

 -- Methods -- 
bool AddBagel(string bagel)
	true when item succesfully added
	false when basket is full

bool RemoveBagel(string bagel)
	true when item succesfully removed
	false when item isn't in basket