# C# Adapter Pattern

The `Adapter` pattern converts the interface of a class into another interface the client can interact with.

The actors in this pattern are:
- Target
  - Defines the domain specific interface used by the client.
- Adaptee
  - Defines an existing interface that needs adapting
- Adapter
  Adaptes the Adaptee interface to the Target interface
- Client
  - Interacts with objects conforming to the Target interface.