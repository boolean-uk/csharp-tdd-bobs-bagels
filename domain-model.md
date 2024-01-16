#Domain Models In Here
```
User Stories
1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.


| Classes            |                            Methods								    | Scenario                                       | Outputs     |
|--------------------|----------------------------------------------------------------------|------------------------------------------------|------------ |
| `Basket`           |             `AddBagel(string bagelType, int price)`                  |If bagel is added successfully to the basket    |    True     |                   
|                    |                                                                      |If the basket is already full                   |    False    |



2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.


| Classes            |                            Methods                                   | Scenario                                       | Outputs    |
|--------------------|----------------------------------------------------------------------|------------------------------------------------|------------|
| `Basket`           | `RemoveBagel(string bagelType)`                                      | If bagel is successfully removed from basket   | True       |
|                    |                                                                      | If the basket is empty                         | False      |
|                    |                                                                      | If the specified bagel is not in the basket    | False      |




3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

| Classes  | Methods                                      | Scenario                                    |  Outputs       |
| -------- | -------------------------------- ------------| --------------------------------------------|----------------|
| `Basket` | `IsBasketFull(Dictionary<string,int> items)` | If the basket is full                       | True           |
|          |                                              | If the basket is not full                   | False          |


4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Classes  | Methods                                | Scenario                                             | Outputs           |
| -------- | -------------------------------------- | -----------------------------------------------------|-------------------|
| `Basket` | `ChangeBasketCapacity(int newCapacity)`| If the capacity is changed successfully              | True              |
|          |                                        | If the new capacity is invalid or the same as before | False             |




5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

| Classes  | Methods                                             | Scenario                                                | Outputs           |
| -------- | ----------------------------------------------------|---------------------------------------------------------| ------------------|
| `Basket` | `RemoveItemThatDoesntExist(string bagelType)`       | If the specified bagel type doesn't exist in the basket | True              |
|          |                                                     | If the specified bagel type exists in the basket        | False             |
|          |                                                     | If the new capacity is invalid or the same as before    | False             |



```


```

