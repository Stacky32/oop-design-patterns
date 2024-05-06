# C# Singleton design pattern

The `Singleton` design pattern is a creational design pattern providing access to a single instance of an object.

The actors in the Singleton pattern are:

- Singleton
  - Maintains a static reference to the single instance, initialised using a private constructor
  - Does *NOT* expose a public constructor
  - Exposes a static Instance property or method which returns the instance

- Consumer
  - Gets access to the instance using the static Instance or Property method.