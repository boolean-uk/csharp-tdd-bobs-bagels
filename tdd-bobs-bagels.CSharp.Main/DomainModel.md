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

Everthing in the same table, starting from task 1. :


| Classes         | Methods                                     | Scenario											 | Outputs |
|-----------------|---------------------------------------------|----------------------------------------------------|---------|
| `Basket`		  | `AddBagel(string bagel)`					| User order bagel and adds to basket                | bool    |
|                 |                                             |								                     |         |
|-----------------|---------------------------------------------|----------------------------------------------------|---------|
|                 | `RemoveBagel(string bagel)`                 | User can remove bagel from basket					 | bool    |
|                 |                                             | No bagel found to remove							 | string  |
|-----------------|---------------------------------------------|----------------------------------------------------|---------|
|                 | `public bool basketIsFull`                  | Property to check if basket is full				 | bool    |
|                 | `public int MaxBasketSize { get; set; } = 3`| Property for holding and setting full basket value | int     |
|                 | Modify AddBagel-method to check if full     | If full let user know								 | string  |
|-----------------|---------------------------------------------|----------------------------------------------------|---------|
|                 | `ChangeBasketCapacity(int capacity)`        | Manager can hange capacity of the baskets		     | void    |
|-----------------|---------------------------------------------|----------------------------------------------------|---------|
|                 | Modify Removebagel-method to give an        |													 | string  |
|                 |	explicit message                            |								                     |         |
|-----------------|---------------------------------------------|----------------------------------------------------|---------|

