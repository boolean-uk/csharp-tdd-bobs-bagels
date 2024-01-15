| Classes         | Methods                         |  Returns  | Scenario               | Outputs					   | 
|-----------------|---------------------------------|-----------|-------------------------|----------------------------|
| `Basket`	| `Add(Bagel bagel, int count)`			| string	| Basket isn't full					| Bagel is added to basket list and retuns empty string | 
|			| 										| 			| Basket is full					| Returns error that basket is full  | 
|			| `Remove(Bagel bagel, int count)`		| string	| Basket contains given bagel		| Bagel is removed from basket list  | 
|			|										|			| Basket doesn't contain given bagel| Nothing happens | 
|			| `SetCapacity(int newCapacity)`		| void		| Every time						| Basket capacity has been changed for everyone|