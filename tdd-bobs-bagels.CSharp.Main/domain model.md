# Core
Use only the Basket class and BasketTest class provided. Later, you'll be building another version of this project using multiple classes together as we learn object-oriented programming.

1. I'd like to add a specific type of bagel to my basket.
2. I'd like to remove a bagel from my basket.
3. I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
4. I’d like to change the capacity of baskets.
5. I'd like to know if I try to remove an item that doesn't exist in my basket.

| Class | properties |
|---|---|
| Basket | `List<string bagel> Bagels`, `int Capacity` |


| User story | Method | Scenario | Output |
|---|---|---|---|
| 1 | `Add(string bagel)` | Basket is not full | Adds `bagel` to `Basket.Bagels`|
| 3 |                    | Basket is full     | Displays `"Basket is full"`|
| 2 | `Remove(string bagel)` | `bagel` exists in `Basket.Bagels`         | Removes `bagel` from `Basket.Bagels`|
| 5 |                       | `bagel` does not exist in `Basket.Bagels` | Displays `$"{bagel} was not found in basket"`|
| 4 | `ChangeCapacity(int capacity)` |  | Sets `Basket.Capacity` to `capacity`|