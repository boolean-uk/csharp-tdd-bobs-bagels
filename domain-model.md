# Domain Models In here

# User story 1
1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`        |		addBagel(String name)                   | bagel exists            | true 
|                 |                                             | bagel not exists        | false   |

# User story 2
2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`        |		removeBagel(String name)                | bagel removed          | true 
|                 |                                             | bagel not removed      | false   |

# User story 3
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.


| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`        |		addBagel(String name)                   | Basket is full          | String message, can not add |
|                 |                                             | basket is not full      | string message, can add   |

# User story 4
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`        |		changeCapacity(int size)                | Capacity is changed    | String message, capacity is changed|
|                 |                                             | Capacity not changed   | string message, not changed |


# User story 5
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

| Classes         | Methods                                     | Scenario               | Outputs |
|-----------------|---------------------------------------------|------------------------|---------|
| `Basket`        |		removeBagel(String name)                | Bagel exist          | String message, bagel removed |
|                 |                                             | basket not exist      | string message, bagel can not be removed |


