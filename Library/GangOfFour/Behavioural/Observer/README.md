# C# Observer design pattern

The `Observer` design pattern defines a one-to-many relationship between objects so that when the state of one object changes, its dependents are notified and updated automatically.

The actors in the `Observer` pattern are:

- Subject
  - Knows its observers.
  - Provides an interface for attaching and detaching observers.

- ConcreteSubject
  - Stores state of interest to ConcreteObserver.
  - Sends a notification to observers when internal state changes.

- Observer
  - Defines an interface for updating objects in response to changes in the Subject.

- ConcreteObserver
  - Maintains a reference to a ConcreteSubject object
  - Stores state that should stay consistent with the ConcreteSubject
  - Implements the observer interface to keep its state consistent with the subject.

In practice, the Subject exposes a public `Change` event and registers and deregisters observers as listeners on the event. The setters of properties that must be tracked with raise the change event, which observers respond to by updating their internal state.