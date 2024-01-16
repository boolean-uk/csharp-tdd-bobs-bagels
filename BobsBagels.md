| Classes           | Members                                                             | Methods                                               | Scenario                       | Outputs      |
|-------------------|---------------------------------------------------------------------|-------------------------------------------------------|--------------------------------|--------------|
| `Basket`          | `Dictionary<string, int> bagels (key is type and value is price)`   | `AddBagel(string type)`                               |                                | Console.Out  | 
|                   |                                                                     | `RemoveBagel(string type)`                            | Bagel *is* in basket           | true         |
|                   |                                                                     |                                                       | Bagel *is not* in basket       | false        |
|                   |                                                                     | `IsBasketFull()`                                      | Basket *is* full               | true         |
|                   |                                                                     |                                                       | Basket *is not* full           | false        |
|                   |                                                                     | `ChangeBasketCapacity(int capacity)`                  |                                |              | 
