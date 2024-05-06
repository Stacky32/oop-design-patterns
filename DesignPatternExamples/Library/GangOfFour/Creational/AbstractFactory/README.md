# C# Abstract Factory design pattern

The `Abstract Factory` pattern provides a uniform interface for constructing objects of a derived type without specifiying the concrete types.

The actors in the Abstract Factory pattern are:

- AbstractFactory
  - Provides an interface for contstructing objects of various AbstractModel types.

- ConcreteFactory
  - Implements the AbstractFactory interface
  - Exposes methods to return instances of ConcreteModel types downcast to the abstract type

- AbstractClient
  - Provides an interface for the ConcreteClient to implement.
  - The client uses the abstract factory to create and use instances.

- ConcreteClient
  - Implements the AbstractClient interface
  - Is responsbile for creating instances using the factory

- AbstractModel
  - Provides an interface for the types of object the factory can construct
- ConcreteModel
  - Implements the AbstractModel interface.
