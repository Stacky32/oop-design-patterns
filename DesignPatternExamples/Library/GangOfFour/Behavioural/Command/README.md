# C# Command Design Pattern

The `Command` design pattern encapsulates a request as an object.

The actors in the Command pattern are:

- Command
  - Declares an interface for executing an operation

- ConcreteCommand
  - Defines a binding between a Receiver object and an action.
  - Implements Execute by invoking the corresponding operations on Receiver.

- Client
  - Creates a ConcreteCommand object and sets its receiver

- Invoker
  - Asks the command to carry out the request

- Receiver
  - Knows how to perform the actions associated with the request.

