# OOP Design Patterns and principals
## SOLID Principals

The SOLID principles are:
- Single Responsibility Principle
- Open/Closed Principle
- Liskov Substitution Principle
- Interface Segregation Principle
- Dependency Inversion Principle


## Single Responsibility Principle
> A module should be responsible to one and only one actor
An _actor_ is a group that requires a change in the module.

E.g. A class that produces PDF reports should not be responsible for the content or styling of 
the report.


## Open/Closed Principle
> Entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

E.g. Create a new derived class, or a new class implementing the same interface rather than 
modififying the original implementation.


## Liskov Substition Principle
> Let p(x) be a provable property about all objects x of type T. Then p(y) should be true for objects
> of type S where S is a subtype of T.

In practice this means:
- Contravariance of method parameters in the subtype:
  If `S <= T` and I is a type constructor, then `I<S> <= I<T>`.
  E.g. `IEnumerable<out T>`
- Covariance of method return types in the subtype
  If `S <= T` and I is a type constructor, then `I<T> <= I<S>`.
  E.g. `Action<in T>`
- New exceptions cannot be thrown by a method in the subtype unless they are subtypes of exceptions 
  thrown by the base method.

## Interface Segregation Principle


## Dependency Inversion Principle



## Design Patterns

Some common OOP design patterns are:

Creational Patterns:
- Abstract Factory Pattern
- Decorator Pattern
- Visitor Pattern

## Factory Pattern

## Decorator Pattern

## Visitor Pattern


