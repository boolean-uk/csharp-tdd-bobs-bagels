
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

### Class Basket
- string bagelType

PROPERTIES
- public List<string> ordersInBasket;
- int basketSize

METHODS

`I'd like to add a specific type of bagel to my basket.`
- public bool addBagel(string bagelType), adds bagel to List<string> ordersInBasket; when order does not excist in List

`I'd like to remove a bagel from my basket.`
- public bool changeOrder(), return true when bagel is removed from order, message of changed order, return false message with order not found

`I'd like to know when my basket is full when I try adding an item beyond my basket capacity.`
- public bool fullBasket(), return false, message when bakset is full 

`I'd like to know when my basket is full when I try adding an item beyond my basket capacity.`
- public void setBasketSize(int newSize), 

`I'd like to know if I try to remove an item that doesn't exist in my basket.`
- public bool removeOrder(), return true when order is removed, message with removed order.


