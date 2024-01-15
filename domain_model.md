
### Domain Model Bagel

| Classes | Members                                                                                          | Methods                             | Returns                                                                               |   |
|---------|--------------------------------------------------------------------------------------------------|-------------------------------------|---------------------------------------------------------------------------------------|---|
| Basket  | Dictionary<string, int> _basket - The string is the BagelType, the int is the count of that type | AddBagel(string type) : bool        | Returns true if Bagel exists and _basket value is incremented by one, otherwise false |   |
|         | int Capacity - The total capacity of the basket                                                  | RemoveBagel(string name) : bool     | Returns true if removed from the list otherwise false                                 |   |
|         |                                                                                                  | IsBasketFull() : bool               | Returns true if basket is full                                                        |   |
|         |                                                                                                  | ChangeCapacity(int capacity) : bool | Returns true if BasketCapacity has changed, otherwise false                           |   |