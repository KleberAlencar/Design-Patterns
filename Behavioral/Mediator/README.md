# MEDIATOR Design Pattern

## Overview
Enables the decoupling of objects, simplifies communication between multiple objects in a system by centralizing their interactions through a mediator. Instead of objects interacting directly, they communicate via a mediator, reducing dependencies and making the system easier to manage.

## Key Components of the Mediator Pattern:
1. **Mediator**: The Mediator interface defines the communication contract, specifying methods that concrete mediators should implement to facilitate interactions among colleagues.. It encapsulates the logic for coordinating and managing the interactions between these objects, promoting loose coupling and centralizing control over their communication;
2. **Colleague**: Colleague classes are the components or objects that interact with each other. They communicate through the Mediator, and each colleague class is only aware of the mediator, not the other colleagues. This isolation ensures that changes in one colleague do not directly affect others;
3. **Concrete Mediator**: Concrete Mediator is a specific implementation of the Mediator interface. It coordinates the communication between concrete colleague objects, handling their interactions and ensuring a well-organized collaboration while keeping them decoupled;
4. **Concrete Colleague**: Concrete Colleague classes are the specific implementations of the Colleague interface. They rely on the Mediator to communicate with other colleagues, avoiding direct dependencies and promoting a more flexible and maintainable system architecture.

## Benefits of the Mediator Pattern:
1. Complex Communication: Your system involves a set of objects that need to communicate with each other in a complex manner, and you want to avoid direct dependencies between them;
2. Loose Coupling: You want to promote loose coupling between objects, allowing them to interact without knowing the details of each other's implementations;
3. Centralized Control: You need a centralized mechanism to coordinate and control the interactions between objects, ensuring a more organized and maintainable system;
4. Changes in Behavior: You anticipate changes in the behavior of components, and you want to encapsulate these changes within the mediator, preventing widespread modifications;
5. Enhanced Reusability: You want to reuse individual components in different contexts without altering their internal logic or communication patterns.

## When not to use:
1. Simple Interactions: The interactions between components are straightforward, and introducing a mediator would add unnecessary complexity;
2. Single Responsibility Principle (SRP): The Single Responsibility Principle states that each component has a single responsibility; adding a mediator could go against this principle and result in less maintainable code;
3. Performance Concerns: Introducing a mediator could introduce a performance overhead, especially in situations where direct communication between components is more efficient;
4. Small Scale Applications: In small-scale applications with a limited number of components, the overhead of implementing a mediator might outweigh its benefits;
5. Over-Engineering: If the Mediator pattern appears like an over-engineered answer for your system's particular requirements, don't use it. Always take into account the particular requirements of your application as well as the trade-offs.