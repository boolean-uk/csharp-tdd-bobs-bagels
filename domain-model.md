# Domain model

### User Stories
```
As a member of the public,
- So I can order a bagel before work,
    I'd like to add a specific type of bagel to my basket.
- So I can change my order,
    I'd like to remove a bagel from my basket.
- So that I can not overfill my small bagel basket,
    I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
- So that I can maintain my sanity
    I'd like to know if I try to remove an item that doesn't exist in my basket.


As a Bob's Bagels manager,
- So that I can expand my business,
    I’d like to change the capacity of baskets.
```

| Classes             | Methods                                                      | Scenario               | Outputs |
|---------------------|--------------------------------------------------------------|------------------------|---------|
| `abstract Object`  |                                                    |                        | `` |
|                     |                                                      |                        | `` |
| `abstract Person : Object` |                                            |                        | `` |
|                     |                                                      |                        | `` |
| `Customer : Person` |                                                      |                        | `` |
| `Manager : Person`  | `public bool AlterSize(Basket basket, int newSize)` | Update the size of the basket | `true` |
|                     |                                                      | Cannot update basket size due to newSize variable is invalid, or basket doesn't exist | `false` |
|                     |                                                      |                        | `` |
| `abstract Product : Object`  | `public double GetPrice()`                                         |                        | `value` |
| `Bagel : Product`   |                                                      |                        |   |
| `Basket : Object`   | `public bool AddProduct(Product product)`           | Add product to basket    | `true` |
|                     |                                                      | Cannot add product to basket due to basket size limit     | `false` |
|                     |                                                      | Cannot add product to basket due to product being invalid | `false` |
|                     | `public bool RemoveProduct(Product product)`        | Remove product from basket | `true` |
|                     |                                                      | Cannot remove product from basket due to product not existing in basket, or is invalid | `false` |
|                     | `protected internal bool AlterSize(int newSize)` | Update the size of the basket to newSize if newSize is valid | `true` |
|                     |                                            | Cannot update the size of the basket to newSize because newSize is invalid (negative number or past max limit) | `false` |
