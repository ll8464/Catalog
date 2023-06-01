Notes
To view the default application, attach /swagger to the endpoint.
For example: https://localhost:7067/swagger in the url.

The swagger API allows for test routes and provides different schemas as well for the default weather app.

Dependency Injection

A dependency is an object that another object depends on.

One way to think of dependencies are whenever class1 uses class2 to function. In this case, class2 is a dependency
to class1.

class1 ---> class2

A parameter in a method, such as in the case of a controller, is a dependency. In order to make your code more modular
and flexible, it is best to utilize Dependency Inversion Principle or Inversion of Control (IoC).

Dependency Inversion is when your classes depend on an interface while the dependency implements the interface.

class1 ---> Interface <--- Dependency

By using different Inversion of Control, you can change the data implementation from memory, file, database, etc. as needed. This is achieved by switching the interfaces instead of needing to recode classes and their dependencies, also known as decoupling.

https://learn.microsoft.com/en-us/dotnet/core/extensions/dependency-injection

DTO
Data Transfer Object can be thought of as the contract between the client and our service. It is an object that carries data between processes. DTOs have no behavior beyond storage, retrieval and serialization of its own data. It contains no business logic.
