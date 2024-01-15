# Bob's Bagels - Domain Model
```
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

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
```
<table>
	<thead>
		<td>Class</td>
		<td>Method</td>
		<td>Scenario</td>
		<td>Output</td>
	</thead>
	<tbody>
		<td><code>Basket</code></td>
		<td><code>Order(string bagel)</code></td>
		<td>Add a specific type of bagel to the basket</td>
		<td>void</td>
	</tbody>
	<tbody>
		<td></td>
		<td><code>Order(string bagel)</code></td>
		<td>Throw an exception when about to overfill the basket</td>
		<td>Exception</td>
	</tbody>
	<tbody>
		<td></td>
		<td><code>Remove(string bagel)</code></td>
		<td>Remove a bagel from the basket</td>
		<td>string</td>
	</tbody>
	<tbody>
		<td></td>
		<td><code>Remove(string bagel)</code></td>
		<td>Throw an exception when about to remove a non-existing bagel</td>
		<td>Exception</td>
	</tbody>
</table>


```
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.
```
<table>
	<thead>
		<td>Class</td>
		<td>Method</td>
		<td>Scenario</td>
		<td>Output</td>
	</thead>
	<tbody>
		<td><code>Basket</code></td>
		<td><code>Capacity</code></td>
		<td>Set the capacity of the basket</td>
		<td>void</td>
	</tbody>
</table>
