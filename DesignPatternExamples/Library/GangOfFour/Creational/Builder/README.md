# C# Builder design pattern

The `Builder` design pattern separates the construction of an object from its representation, so the same construction process can create different representations.

The actors in the `Builder` pattern are:

- Builder
  - Defines an abstract interface for creating parts of a Product object

- ConcreteBuilder
  - Implements the Builder interface
  - Defines and keeps track of the object being constructed internally
  - Exposes a method to retrieve the constructed object

- Director
  - Contructs Product objects using the Builder interface

- Product
  - Represents the object under construction
  - Includes classes that define the constituent parts into the final result


For example,

``` csharp
var builder = new CarBuilder();
var car = builder
    .WithColor("blue")
    .WithTyres(new CarTyre(...))
    .WithDrive(DriveTrain.FWD)
    .Build();
```