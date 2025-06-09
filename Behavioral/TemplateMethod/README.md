# TEMPLATE METHOD Design Pattern

## Overview
Defines the skeleton of an algorithm in a superclass but allows subclasses to override specific steps of the algorithm without changing its structure. Promotes code reuse by encapsulating the common algorithmic structure in the superclass while allowing subclasses to provide concrete implementations for certain steps.

## Key Components of the Template Method Pattern:
1. **Abstract Class**: This is the superclass that defines the template method. It provides a skeleton for the algorithm, where certain steps are defined, but others are left abstract or defined as hooks that subclasses can override;
2. **Template Method**: This method within the abstract class defines the overall algorithm structure by calling various steps in a specific order. It’s often declared as final to prevent subclasses from changing the algorithm’s structure;
3. **Abstract (or Hook) Methods**: These methods are declared within the abstract class but not implemented. They serve as placeholders for steps in the algorithm that subclasses should implement;
4. **Concrete Subclasses**: These subclasses extend the abstract class and provide concrete implementations for the abstract methods defined in the superclass.

## Benefits of the Template Method Pattern:
1. You can let clients override only certain parts of a large algorithm, making them less affected by changes that happen to other parts of the algorithm;
2. You can pull the duplicate code into a superclass.

## When not to use:
1. Some clients may be limited by the provided skeleton of an algorithm;
2. You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass;
3. Template methods tend to be harder to maintain the more steps they have.
