# Domain Models

| Classes  | Methods                                        | User Story | Scenario              | Outputs |
|----------|------------------------------------------------|------------|-----------------------|---------|
| `Basket` | `Add(string bagel)`                            | #1, #3     | if basket is full     | false   |
|          |                                                | #1, #3     | if basket is not full | true    |
| `Basket` | `Remove(string bagel)`                         | #2, #5     | if item in basket     | true    |
|          |                                                | #2, #5     | if item not in basket | false   |
| `Basket` | `ChangeCapacity(int capacity, bool isManager)` | #4         | if isManager is true  | true    |
|          |                                                | #4         | if isManager is false | false   |
