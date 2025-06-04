# ITERATOR Design Pattern

## Overview
Provides a way to access the elements of a collection (such as a list or set) sequentially without exposing its underlying representation. This pattern is particularly useful when you need to traverse different types of collections in an uniform manner.

## Key Components of the Iterator Pattern:
1. **Iterator Interface**: Defines the methods for accessing and traversing elements in the collection;
2. **Concrete Iterator**: Implements the Iterator interface and maintains the current position in the traversal of the collection;
3. **Aggregate Interface**: Defines the method for creating an Iterator object;
4. **Concrete Aggregate**: Implements the Aggregate interface and represents the collection of objects. It provides the implementation for creating an Iterator object that can traverse its element.

## Benefits of the Iterator Pattern:
1. Access elements of a collection sequentially without exposing its underlying representation;
2. Decouple the iteration logic from the collection;
3. Support multiple iterators over the same collection;
4. Simplify client code that iterates over a collection.

## When not to use:
1. When the collection is not accessed sequentially;
2. When the collection structure is fixed and unlikely to change;
3. In performance-critical applications where the overhead of using iterators may be significant;
4. When the language provides better alternatives for iteration.
