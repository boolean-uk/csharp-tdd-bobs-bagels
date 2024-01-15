# Core

| Classes | Fields | 
| - | - |
| `Basket`| `List<string> _basket` `int _maxBasketSize` |

| Classes | Methods | Scenario (user_story_#) | Outputs |
|-|-|-|-|
| `Basket` | `AddBagelToBasket(string bagelType)` | Add a specific bagel to basket (1) | true |
| | | Failed to add bagel to basket | false |
| | `RemoveBagelFromBasket(string bagelType)` | Remove bagel of provided type from basket (2) | true |
| | | Could not remove, as no bagel of that type was in the basket (5) | false |
| | `BasketHasRoom()` | Check that there is room for more bagels (3) | true |
| | | Basket is overflowing and cant hold anymore (3) | false |
| | `SetBasketSize(int newSize)` | Change the maximum bagel capacity of the basket (4) | int |