## User story 1
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

| Class | Method     | Output |
|-------|------------|--------|
| Basket| add( item )| -      |

## User story 2
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

| Class | Method        | Output |
|-------|---------------|--------|
| Basket| remove( item )| item   |

## User story 3

As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.


| Class | Method     | Scenario                                  | Output |
|-------|------------|-------------------------------------------|--------|
| Basket| add( item )| nr of items is less than  baskets capacity| true   |
| Basket|            | nr of items is at baskets capacity        | false  |


## User story 4

As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Class | Property        | Output   |
|-------|-----------------|----------|
| Basket| capacity {set;} |          |


## User story 5
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

| Class | Method        | Scenario              | Output |
|-------|---------------|-----------------------|--------|
| Basket| remove( item )| item is in basket     | true   |
| Basket|               | item is not in basket | false  |

