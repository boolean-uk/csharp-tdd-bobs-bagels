# Domain Model
## Entities
### Basket

| Fields              | Methods                                        |
|----------------------|------------------------------------------------|
| - CustomerID         | - hasAvailableSpace() -> bool                  |
| - Items              | - AddItem(item) -> void                        |
| - ItemCapacityLimit  | - RemoveItem(index) -> void                    |
|                      | - SetItemCapacityLimit(int) -> void          |

#### Fields
- CustomerID: Integer for identifying the customer.
- Items: List of items that a customer has ordered with limited space.
- ItemCapacityLimit: Integer that limits the amount of items in a customer's basket.
#### Methods
- hasAvailableSpace: Checks if there is aviable space in items.
- AddItem: Adds specified item to basket if there is space for it.
- RemoveItem: Removes specified item in basket (gives error if specified item is not found).
- SetItemCapacityLimit: Changes the capacity of user's basket to the new specified limit.