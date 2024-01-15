1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

| Classes    | Members             | Methods                               | Scenario                                               | Outputs |
|------------|---------------------|---------------------------------------|--------------------------------------------------------|---------|
| `Core`     | List<string> bagels | `add(string bagel)`                   | The basket is not full                                 | true    |
|            |                     |                                       | The basket is full                                     | false   |
|            |                     | `remove(string bagel)`                | The basket contained a bagel of specified type         | true    |
|            |                     |                                       | The basket did not contained a bagel of specified type | false   |
|            | int capasity        | `setCapacity(int capasity)`           |													    |         |