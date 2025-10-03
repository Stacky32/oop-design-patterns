# C# Bridge design pattern

The `Bridge` design pattern decouples an abstraction from its implementation so that the two can vary independently.

The actors in the bridge pattern are:

- Abstraction
  - Defines the abstraction's interface
  - Maintains a reference to an object of type Implementor
- RefinedAbstraction
  - Extends the interface defined by Abstraction
- Implementor
  - Defines the interface for Implementation classes. Does not need to match the Abstraction interface.
- ConcreteImplementor
  - Implements the Implementor interface.