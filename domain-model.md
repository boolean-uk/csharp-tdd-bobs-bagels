## Domain Model

## Core Requirements

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

Req.| Classes	 | Methods / Properties				 | Scenario											| Outputs	      |
----|------------|-----------------------------------|--------------------------------------------------|-----------------|
1	|Core.cs	 |List<string> Basket				 |Store bagels										| List			  |
1, 3|Core.cs	 |`AddBagel(string bagel)`			 |Add a bagel to the basket OR return "basket full"	| List			  |
2, 5|Core.cs	 |`RemoveBagel(string bagel)`		 |Remove bagel from basket OR return "doesn't exist"| List			  |
3	|Core.cs	 |`MaxCapacity(int maximum)`		 |Set a max to the basket							|				  |
4   |Core.cs	 |`EditMaximum(identity, int)`		 |Manager (only) can change the maximum				| Int ?			  |
