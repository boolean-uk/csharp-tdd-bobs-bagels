# Domain Models

| Classes  | Methods                                        | User Story | Scenario              | Outputs |
|----------|------------------------------------------------|------------|-----------------------|---------|
| `Basket` | `add(string bagel)`                            | #1, #3     | if basket is full     | false   |
|          |                                                | #1, #3     | if basket is not full | true    |
| `Basket` | `remove(string bagel)`                         | #2, #5     | if item in basket     | true    |
|          |                                                | #2, #5     | if item not in basket | false   |
| `Basket` | `changeCapacity(int capacity, bool isManager)` | #4         | if isManager is true  | true    |
|          |                                                | #4         | if isManager is false | false   |
