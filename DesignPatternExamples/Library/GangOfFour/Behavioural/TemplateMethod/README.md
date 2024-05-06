# C# Template Method design pattern

The `Template Method` design patten defines the skeleton of an algorithm in an Operation, deferring the implementation of some steps to subclasses. This pattern lets subclasses redefine certain steps of the algorithm without changing its structure.

The actors in the `Template Method` design pattern are:

- AbstractClass
  - Defines abstract primitive operations that derived class will implement.
  - Defines a template method using the primitive operations (whose implementation is deferred to the subclass) as well as methods implemented in the base class

- ConcreteClass
  - Implements the primitive operations to carry out the subclass specific steps of the algorithm.


For example, an algorithm may `Read` some data, `Process` it and `Write` the results in sequence in a `Run` method. The `Run` method is implemented in the base class while the Read, Process and Write steps are deffered to the concrete class.