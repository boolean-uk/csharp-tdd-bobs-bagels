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




---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
Class:		|	Methods:																| Scenario:										| Output:											|
			|																			|1. I want to add bagel to basket				|1.`Product added`									|
`Basket()`	|	`AddBagel(string, int), needs exception to alert when basket is full`	|2. I want to remove bagel from basket			|2.`Product removed`								|
			|	`RemoveBagel(string), check if item exists in basket`					|3. I want to change basketsize					|3.`Basket size changed`							|
			|	`ChangeBasketSize(int)`													|4. I want to be alerted when basket is full	|4.`Basket is full`									|
			|																			|5. I attempt to remove a bagel from basket		|5.`Your basket does not contain this bagel`		|
			|																			|	that is not in the basket					|													|			
			|																			|												|													|
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------