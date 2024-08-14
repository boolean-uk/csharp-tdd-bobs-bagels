# DOMAIN MODEL
==================================================================================================
1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.

Classes        Methods                 Scenario                   Outputs
Basket   add(string bagel)   Add a specific bagel to basket	      string

# add(string bagel) receives a bagel-name and it gets added to a bagel List with a confirmation

==================================================================================================
2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.

Classes               Methods                           Scenario                     Outputs
Basket          remove(string bagel)       Remove a specific bagel from basket       string

# remove(string bagel) receives a bagel-name and it gets removed from the bagel List

==================================================================================================
3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.

Classes          Methods                                        Scenario                                             Outputs
Basket      add(string bagel)       Output a message if the basket is full when trying to add a bagel the basket     string

# Re-use the basket.add() method, check if the basket is full before adding the bagel

==================================================================================================
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.

Classes      Methods              Scenario                   Outputs
Basket        Bagel      Set/Change capacity of basket        void

# Uses the Bagel get/set to set the capacity of the basket

==================================================================================================
5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.

Classes           Methods                    Scenario              Outputs
Basket      remove(string bagel)      Check if bagel exists        string

# Re-use the basket.remove() method. If the bagel doesn't exist, output a string