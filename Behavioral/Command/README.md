# COMMAND Design Pattern

## Overview
A powerful way to encapsulate actions as objects, promoting flexible and decoupled code. This allows commands to be parameterized, queued, logged, or undone/redone, promoting a decoupled design where the sender of a request knows nothing about how it will be executed.

## Key Components of the Command Pattern:
1. **Command**: An interface that defines the operations that can be executed;
2. **ConcreteCommand**: A class that implements the Command interface and encapsulates the request;
3. **Receiver**: Responsible for executing the command;
4. **Invoker**: Holds a list of commands and calls the execute method on the Receiver;
5. **Client**: Creates ConcreteCommand objects and associates them with the invoker.

## Benefits of the Command Pattern:
1. **Separation of Concerns (SRP)**: The invoker and receiver are decoupled, making the system more flexible;
2. **Undo/Redo**: Easily implement undo/redo functionality;
3. **Command Queueing**: Commands can be queued or logged for later execution;
4. **Extension (OCP)**: New commands can be added without changing existing code.

## When not to use:
1. **Increase Complexity**: The code may become more complicated since you’re introducing a whole new layer between senders and receivers.
