#Domain Models In Here

| Classes         | Methods                                     | Scenario                 | Outputs |
|-----------------|---------------------------------------------|--------------------------|---------|
| `Basket`		  | `addBagel(String bagel)`					| Adds Bagal to basket	   | true	 |
|				  |												|						   |		 |
|				  |												| Basket is full		   | false	 |
|-----------------|---------------------------------------------|--------------------------|---------|
| `Basket`        | `removeBagel(String bagel)`                 | removes the bagel		   | true    |
|				  |												|						   |		 |
|				  |												| Unable to remove bagel   | false   |
|-----------------|---------------------------------------------|--------------------------|---------|
| `Basket`        | `changeCapasity(int cpaacity)`				|Changes capasity of basket| true    |
|				  |												|						   |		 |
|				  |												|Unable to change capacity | false	 |
|-----------------|---------------------------------------------|--------------------------|---------|