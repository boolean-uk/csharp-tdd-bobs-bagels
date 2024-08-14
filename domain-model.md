Domain models for the exercise:

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


`doing all of the tasks in the samle table`

| Classes         | Methods                                                         | Scenario									| Outputs     |
|-----------------|-----------------------------------------------------------------|-------------------------------------------|-------------|
|`Basket`		  |`addBagel(String bagel)`                                         | User ordered bagel based on the type		| bool        |
|                 |                                                                 |											|             |
|-----------------|-----------------------------------------------------------------|-------------------------------------------|-------------|
|`Basket`         |`removeBagels(String bagel)`										| User removed bagel from basket			| string      |
|                 |                                                                 | The bagel didnt exist						| string   	  |
|-----------------|-----------------------------------------------------------------|-------------------------------------------|-------------|
|`Basket`         |`public int basketMaxSize`                                       | Property to holding/setting the basket    | int         |
|                 |Modify addBagel to check if full									|											| bool  	  |
|-----------------|-----------------------------------------------------------------|-------------------------------------------|-------------|
|`Basket`         |`changeCapasity(int capacity)`									| Change the basketMaxSize variable         | void (none) |
|				  |                                                                 |                                           |             |
|-----------------|-----------------------------------------------------------------|-------------------------------------------|-------------|
