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

> A client should not be forced to implement interaces they do not use. 

This means that instead of having a single large interface, we should prefer having several smaller
interfaces containing the properties and methods relating a an atomic unit of functionality.

For instance, a tech lead is both a programmer and a manager, so the TeamLead class could implement 
the IProgrammer and IManager interfaces rather than a single large ITeamLead which includes all 
responsibilities.

## Dependency Inversion Principle

High levels modules should not depend on low levels modules directly, instead both should rely on 
abstractions such as an abstract class or interface.

For instance, a logging class should depend on an ILogWriter interface, rather than say a 
TextLogWriter class - the logging class does not need to know or care about how the logs are persisted; 
whether they are written to a text file, standard out or a database, instead they only need to know
the interface for persisting logs.

Another way to phrase this is that a class should not be responsible for resolving its own concrete
dependencies. Instead the dependencies should be passed to the class, for example through a constructor.
One way to achieve this is through using a dependency injection framework.


## Design Patterns

Some common OOP design patterns are:

Creational Patterns:
- Abstract Factory Pattern
- Decorator Pattern
- Visitor Pattern

## Factory Pattern

## Decorator Pattern

## Visitor Pattern


