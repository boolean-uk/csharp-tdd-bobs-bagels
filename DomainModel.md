
# Bobs Bagels Domain model

## User Stories

As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket

As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket

As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

## Domain Model

Class Basket:
    Properties:
        Public Dictionary <string bagelId, string bagelName> BagelsMenu
        private List <string bagelId> BagelsInBasket
        private int BasketCapacity
    Methods:
        string Add(string bagelId)
            returns "{bagelname} added to your basket" if bagelId exists in BagelsMenu
            returns "{bagelId} is not a bagel type on our menu" if bagelId does not exist in BagelsMenu
            returns "Your basket is full" if bagelsInBasket.Count == basketCapacity
        string Remove(string bagelId)
            returns "{bagelname} removed from your basket" if bagelname exists in bagelsInBasket
            returns "Cannot remove from basket since that bagel was not in your basket" if bagelname does not exist in bagelsInBasket
        string UpdateCapacity(int newCapacity)
            basketCapacity = newCapacity; Returns "New basket capacity is {newCapacity}"
                if newCapacity < 1 return "basket capacity cannot be smaller than 1"