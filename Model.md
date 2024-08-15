
1. and 3.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.


As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.



| Classes         | Methods                                          | Scenario                                                         | Outputs                             |
|-----------------|--------------------------------------------------|------------------------------------------------------------------|-------------------------------------|
| `Basket`        | `Add(string bagelName)`                          | if capacity is not overfilled                                    | put bagelName in a capacity list    |
|                 |                                                  |                                                                  |                                     |


2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.


| Classes         | Methods                                          | Scenario                                                         | Outputs                             |
|-----------------|--------------------------------------------------|------------------------------------------------------------------|-------------------------------------|
| `Basket`        | `Remove(string bagelName)`                       | if bagelName is in Basket                                        | remove Bagel from the list          |
|                 |                                                  | if bagelName is not in Basket                                    | dont remove to the list             |
|                 |                                                  |                                                                  |                                     |
|                 |                                                  |                                                                  |                                     |


4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.


| Classes         | Methods                                          | Scenario                                                         | Outputs                             |
|-----------------|--------------------------------------------------|------------------------------------------------------------------|-------------------------------------|
| `Basket`        | `ExpandBasket(int expandWith)`                 |                                                                  | change basket capasity              |
|                 |                                                  |                                                                  |                                     |
|                 |                                                  |                                                                  |                                     |

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

| Classes         | Methods                                          | Scenario                                                         | Outputs                                                                             |
|-----------------|--------------------------------------------------|------------------------------------------------------------------|-------------------------------------------------------------------------------------|
| `Basket`        | `Remove(string bagelName)`                       | Item is not present in basket                                    | prints `the item you are trying to remove is not present in the basket`             |
|                 |                                                  |                                                                  |                                                                                     |
|                 |                                                  |                                                                  |                                                                                     |
