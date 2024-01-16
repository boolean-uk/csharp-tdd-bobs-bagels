1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.
verbs/actions: add bagel type, order(I deem this out of scope of exercise)

2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.
verbs/actions: remove a bagel

3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
verbs/actions: know when basket is full

4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.
verbs/actions: change basket size

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
verbs/actions: know if bagel exists, maintain sanity (jk) 



| Classes         | Methods                                        | Scenario                                      | Outputs   |
|-----------------|------------------------------------------------|-----------------------------------------------|-----------|
| `Basket`	      | `addBagel(string type, int amount)`			   | If bagel was added						       | true      |
|       	      |                                      		   | If bagel wasn't added	                       | false     |
|       	      | `removeBagel(string type, int amount)`		   | Remove bagel and amount, return amnt removed  | int       |
|       	      | `removeAllBagel()`							   | Removes all bagels in basket				   | int       |
|       	      | `checkCurrentBasketCapacity()`		           | return size of current free basket space      | int       |
|       	      | `checkTotalBasketCapacity()`		           | return size of total basket space             | int       |
|       	      | `checkIfBagelinBasket(string type)`		       | If Basket is populated by bagel               | true      |
|                 |                                                | If it is empty		                           | false     |
|       	      | `changeBasketSize(int newSize)`		           | Change to new size, return new size int       | int       |

