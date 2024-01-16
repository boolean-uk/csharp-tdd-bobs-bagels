

| Classes  | Members	 | Methods						|	Scenario				 | Output |
| ---------|-------------|------------------------------|----------------------------|--------|
| Customer | List<Bagel> | addBagel(string type)        | Bagel is added to list     | true   |
|		   |             |						        | List (basket) is full      | false  |
|		   |			 | removeBagel(string type)     | Bagel is in the basket     | true   | 
|		   |		     |							    | Bagel is NOT in the basket | false  |
| Manager  |			 | changeBasketLimit(int limit) | Change basket size		 | true   |

