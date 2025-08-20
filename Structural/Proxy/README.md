# PROXY Design Pattern

## Overview
The **Proxy** is a structural design pattern that provides a substitute or placeholder for another object. It controls access to the original object, enabling additional functionality such as lazy initialization, access control, logging, or caching without altering the original object's code.

## Key Components:
1. **Subject**: Defines the common interface shared by the real object and the proxy. This ensures the proxy can be used interchangeably with the real object.
2. **RealSubject**: The actual object containing the core business logic or resource that the client wants to access.
3. **Proxy**: Acts as a surrogate for the RealSubject. It implements the same interface and manages access to the RealSubject, adding extra functionality like caching or security checks.

## Use Cases:
1. **Lazy Initialization**: Delays the creation of resource-intensive objects until they are needed.
2. **Access Control**: Restricts access to the real object based on permissions or conditions.
3. **Caching**: Stores results of expensive operations to avoid redundant computations.
4. **Logging and Monitoring**: Tracks method calls or usage without modifying the real object.
5. **Remote Proxy**: Handles communication with objects located on remote servers.

## When not to use:
1. **Complex Implementation**: Adds complexity by introducing additional classes.
2. **Performance Overhead**: May delay responses due to the proxy's processing overhead.

