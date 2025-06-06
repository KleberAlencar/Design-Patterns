# STATE Design Pattern

## Overview
Allows an object to alter its behavior when its internal state changes. This pattern is particularly useful when an object's behavior depends on its state, and the state can change during the object's lifecycle.

## Key Components of the Strategy Pattern:
1. **Context**: This is the class that contains the object whose behavior changes based on its internal state. It maintains a reference to the current state object and delegates state-specific behavior to this object;
2. **State Interface or Base Class**: This defines a common interface for all concrete state classes. It typically declares methods that represent the state-specific behavior that the Context can exhibit;
3. **Concrete States**: These classes implement the State interface or extend the base class. Each concrete state class encapsulates the behavior associated with a specific state of the Context.

## Benefits of the Strategy Pattern:
1. Single Responsibility Principle (SRP). Organize the code related to particular states into separate classes;
2. Open/Closed Principle (OCP). Introduce new states without changing existing state classes or the context;
3. Simplify the code of the context by eliminating bulky state machine conditionals.

## When not to use:
1.  Applying the pattern can be overkill if a state machine has only a few states or rarely changes.

## Relations with Other Patterns:
- **Bridge**, **State**, **Strategy** (and to some degree **Adapter**) have very similar structures. Indeed, all of these patterns are based on composition, which is delegating work to other objects. However, they all solve different problems. A pattern isn’t just a recipe for structuring your code in a specific way. It can also communicate to other developers the problem the pattern solves.
- **State** can be considered as an extension of **Strategy**. Both patterns are based on composition: they change the behavior of the context by delegating some work to helper objects. Strategy makes these objects completely independent and unaware of each other. However, State doesn’t restrict dependencies between concrete states, letting them alter the state of the context at will.