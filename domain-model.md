1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

| Classes         | Methods                                     | Scenario                  | Outputs                               |
|-----------------|---------------------------------------------|---------------------------|---------------------------------------|
| `Basket`	        | `addBagel(string type)`                   | any			            | void			            |

2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

| Classes         | Methods                                     | Scenario                  | Outputs                               |
|-----------------|---------------------------------------------|---------------------------|---------------------------------------|
| `Basket`	        | `removeBagel(string type)`                | bagel exist			    | true			            |
|                 |                                             | no such bagel			    | false			            |

3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

| Classes         | Methods                                     | Scenario                  | Outputs                               |
|-----------------|---------------------------------------------|---------------------------|---------------------------------------|
| `Basket`	        | `isFull()`                                | basket full			    | true			            |
|                 |                                             | basket not full		    | false			            |

4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Classes         | Methods                                     | Scenario                  | Outputs                               |
|-----------------|---------------------------------------------|---------------------------|---------------------------------------|
| `Basket`	        | `changeBasketCapacity()`                  | any			            | void			                        |

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
| Classes         | Methods                                     | Scenario                  | Outputs                               |
|-----------------|---------------------------------------------|---------------------------|---------------------------------------|
| `Basket`	        | `removeBagel(string type)`                | bagel removed             | true                                  |
|                 |                                             | no such bagel			    | false, print "No such bagel"		    |