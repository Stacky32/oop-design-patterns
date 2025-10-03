# C# Iterator Design Pattern

The `Iterator` design pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.

The actors in this pattern are:
- Iterator
  - Defines an interface for accessing and traversing elements.
- ConcreteIterator
  - Implements the Iterator interface
  - Keeps track of the current position in the aggregate.
- Aggregate
  - Defines an interface for creating an interator object.
- ConcreteAggregate
  Implements the interator creation interface to return a ConcreteIterator.