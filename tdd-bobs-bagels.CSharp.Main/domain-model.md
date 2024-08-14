
| Classes  | Members                                                            | Methods                          | Scenario                                                       | Outputs |
|----------|--------------------------------------------------------------------|----------------------------------|----------------------------------------------------------------|---------|
| `Basket` | `List<String> items` (key is product name, value is price)         | `add(String product)`            | Item with the provided name *is not* already in the basket     | true    |
|          |                                                                    |                                  | Item with the provided name *is* already in the basket         | false   |
|          |                                                                    | `remove(string product)`         | if item in basket. remove                                      | true    |
|          |                                                                    |                                  | Item not in basket. dont remove ()                             | false   |
|          |                                                                    | `IsFull()`                       | If capacity is full      EDIT! Add this to Add method          | true    |
|          |                                                                    |                                  | If capacity is NOT full                                        | false   |
|          |                                                                    | `ChangeBasketSize()`             | Change the size of the basket                                  |         |
|          |                                                                    | `IsInBasket()`                   | Item is in basket  EDIT: Add to Remove method!!                | true    |
|          |                                                                    |                                  | Item is not i basket                                           | false   |
       