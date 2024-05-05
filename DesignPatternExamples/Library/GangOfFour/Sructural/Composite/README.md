# C# Composite design pattern

The `Composite` design pattern composes objects into tree structures to represent hierarchies.

The actors involved in this pattern are:

- Component
  - Declares the interface for objects in the composition.
  - Impements the default behaviour
  - Declares an interface for accessing and managing child components.

- Leaf
  - Represent leaf objects in the composition; those that have no child components.
  - Defines the behaviour for these primitive elements in the composition.

- Composite
  - Defines behaviour for components with children.
  - Stores child components
  - Implements child related operations in the component interface.
