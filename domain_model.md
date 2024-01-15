
### Domain Model Bagel


**NOTE Forgot to commit after writing tests - Used Red Gren Refactor APPROACH nonetheless**

## User Stories

```
1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.
```

```
2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.
```

```
3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
```

```
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.
```

```
5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
```


### Domain Model
| Classes | Members                                                                                                 | Methods                             | Returns                                                                               |   |
|---------|---------------------------------------------------------------------------------------------------------|-------------------------------------|---------------------------------------------------------------------------------------|---|
| Basket  | public Dictionary<string, int> _basket - The string is the BagelType, the int is the count of that type | AddBagel(string type) : bool        | Returns true if Bagel exists and _basket value is incremented by one, otherwise false |   |
|         | private int _capacity - The total capacity of the basket                                                | RemoveBagel(string name) : bool     | Returns true if removed from the list otherwise false                                 |   |
|         | private int _totalInBasket                                                                              | IsBasketFull() : bool               | Returns true if basket is full                                                        |   |
|         |                                                                                                         | ChangeCapacity(int capacity) : bool | Returns true if BasketCapacity has changed, otherwise false                           |   |

