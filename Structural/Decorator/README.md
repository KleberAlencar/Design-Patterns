# DECORATOR Design Pattern

## Overview
Allows behavior to be added to individual objects, dynamically, without affecting the behavior of other objects from the same class. It’s particularly useful when you want to adhere to the Open/Closed Principle—allowing classes to be open for extension but closed for modification.

## Key Components of the Decorator Pattern:
1. **Target Interface**: Defines the interface expected by the client. It represents the set of operations that the client code can use;
2. **Adaptee**: The existing class or system with an incompatible interface that needs to be integrated into the new system;
3. **Adapter**: A class that implements the target interface and internally uses an instance of the adaptee to make it compatible with the target interface;
4. **Client**: The code that uses the target interface to interact with objects. It remains unaware of the specific implementation details of the adaptee and the adapter.

## How It Works:
1. **Component**: The base interface or abstract class that defines the common behavior;
2. **Concrete Component**: The primary object whose behavior can be dynamically extended;
3. **Decorator**: An abstract class or interface that wraps the component and provides additional behavior;
4. **Concrete Decorators**: Specific implementations of the decorator that add new functionality.

## Benefits of the Decorator Pattern:
1. **Flexibility**: You can add or remove responsibilities dynamically;
2. **Adherence to SOLID principles**: Promotes the Open/Closed Principle;
3. **Reusability**: Decorators can be combined in various ways.

## When Not to Use:
1. **Complexity**: Can lead to a system with many small classes;
2. **Debugging**: Tracing through multiple layers of decorators can be challenging.