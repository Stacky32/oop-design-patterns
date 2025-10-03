# C# Strategy Pattern

The `Strategy` design pattern defines a family of algorithms, each encapsulated in a class and defines a common interface, allowing the algorithms to be interchangeable.

The actors in the Strategy pattern are:

- Strategy
  - Declares an interface common to all supported algorithms.

- ConcreteStrategy
  - Implements the algorithm through the strategy interface.

- Context
  - Maintains a reference to a strategy object.
  - May define an interface that lets strategy access its data.