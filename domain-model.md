# Domain Model 

# User Stories 

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
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

5.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Classes                | Methods                                              | Scenario                                                                                 | Expected Output                                                              |
|------------------------|------------------------------------------------------|------------------------------------------------------------------------------------------|------------------------------------------------------------------------------|
| `Bagel`                | Constructor(string name)                             | Creating a bagel with a specific name.                                                   | Bagel object is created with the specified name.                             |
| `Basket`               | Constructor(int capacity)                            | Creating a basket with a specific capacity.                                              | Basket object is created with the specified capacity.                        |
                         | IsFull()                                             | Checking if the basket is full.                                                          | IsFull() returns true if the basket is full; otherwise, false.               |
                         | AddBagel(string bagel)                               | Adding a bagel to the basket.                                                            | Bagel is added to the basket, and the bagel count increases.                 |
                         | RemoveBagel(string bagel)                            | Removing a bagel from the basket.                                                        | Bagel is removed from the basket, and the bagel count decreases.             |
                         | GetBagelCount()                                      | Getting the current number of bagels in the basket.                                      | GetBagelCount() returns the current number of bagels in the basket.          |
                         | RemoveNonExistingBagel(string bagel)                 | Removing a bagel that doesn't exist in the basket.                                       | RemoveNonExistingBagel() returns false as the bagel is not in the basket.    |
| `Bob's Bagels Manager` | ChangeBasketCapacity(Basket basket, int newCapacity) | A Bob's Bagels manager wants to change the capacity of a specific basket to a new value. | The capacity of the specified basket is updated to the new value.            |