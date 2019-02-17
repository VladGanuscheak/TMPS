[Microsoft Documentations: interfaces in c#](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/index) [1]:

_An interface contains definitions for a group of related functionalities that a class or a struct can (must) implement._
_By convention, interface names begin with a capital **I**_.


* Interfaces can contain methods, properties, events, indexers, or any combination of those four member types.

* An interface can't contain constants, fields, operators, instance constructors, finalizers, or types. Interface members are automatically public, and they can't include any access modifiers. Members also can't be static. It means that in order to implement an interface member, the corresponding member of the implementing class must be _public_, _non-static_, and have the same name and signature as the interface member.

* When a class or struct implements an interface, the class or struct **must provide an implementation for all of the members that the interface defines**. The interface itself provides no functionality that a class or struct can inherit in the way that it can inherit base class functionality. However, if a base class implements an interface, any class that's derived from the base class inherits that implementation.

* _Interfaces can inherit from other interfaces_. A class might include an interface multiple times through base classes that it inherits or through interfaces that other interfaces inherit. However, the class can provide an implementation of an interface only one time and only if the class declares the interface as part of the definition of the class (class ClassName : InterfaceName).

* If the interface is inherited because you inherited a base class that implements the interface, the base class provides the implementation of the members of the interface. However, **the derived class can reimplement any virtual interface members instead of using the inherited implementation**.

* A base class can also implement interface members by using virtual members. In that case, a derived class can change the interface behavior by overriding the virtual members.

In a nuthell:

* Any class or struct that implements the interface must implement all its members.
* An interface can't be instantiated directly. Its members are implemented by any class or struct that implements the interface.
* Interfaces can contain events, indexers, methods, and properties.
* Interfaces contain no implementation of methods.
* A class or struct can implement multiple interfaces. A class can inherit a base class and also implement one or more interfaces. _**[1]**_

[Microsoft Docs: Abstract and Sealed classes, class members](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members) :[2]

The _**abstract**_ keyword enables you to create classes and class members that are incomplete and must be implemented in a derived class.

* An abstract class cannot be instantiated. (The purpose of an abstract class is to provide a common definition of a base class that multiple derived classes can share.)

* Abstract classes may also define abstract methods. This is accomplished by adding the keyword abstract before the return type of the method

* Derived classes of the abstract class must implement all abstract methods. When an abstract class inherits a virtual method from a base class, the abstract class can override the virtual method with an abstract method. [2]

***

## Abstract class vs Interface:

_**Access Specifier**_:

In C#, Interface cannot have access specifier for functions. It is public by default.

In C#, an abstract class can have access specifier for functions.

_**Implementation**_:

In C#, an interface can only have a signature, not the implementation.

An abstract class can provide complete implementation.

_**Speed**_:

Interface is comparatively slow.

An abstract class is fast.

_**Instantiate**_:

Interface is absolutely abstract and cannot be instantiated.

An abstract class cannot be instantiated.

_**Fields**_:

Interface cannot have fields.

An abstract class can have defined fields and constants.

_**Methods**_:

Interface has only abstract methods.

An abstract class can have non-abstract methods.
