# C# Memento Design Pattern

The `Memento` design pattern captures an object's internal state enabling the state to be restored later without violating encapsultation.

The actors in this pattern are:
- Memento
  - Stores internal state of the originator
  - Protects against acess by objects other than the originator

- Originator
  - Creates a memento containing a snapshot of the internal state
  - Uses the memento to restore its internal state

- Caretaker
  - Is responsible for maintaining a reference to the memento
  - Does not operate on or examine the contents of the memento