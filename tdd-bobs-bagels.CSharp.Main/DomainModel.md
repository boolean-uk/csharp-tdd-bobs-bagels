Class Basket

 -- Properties --
 List<string> bagels;
 int capacity {set}

 -- Methods -- 
 bool AddBagel(string bagel)
	true when item succesfully added
	false when basket is full

bool RemoveBagel(string bagel)
	true when item succesfully removed
	false when item isn't in basket