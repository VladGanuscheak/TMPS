The main functionalies which Factory Method implements are
* Defines an interface for creating objects, but let subclasses to decide which class to instantiate;
* Refers to the newly created object through a common interface.

Usually there is a situation where it design pattern is closely linked with Singleton one. It could be explaine by the fact that we may have one common interface for several classes, but we need the guarantee that only one instance of this class will be created.

The same logic I have implemented and have described in [Singleton design pattern](Modeling/Singleton.md). But this time I'll say more about Factory method.

When we are using this design pattern, the following aspects should be mentioned:

* Creator class is abstract and generating method does not have any implementation. In this case the ConcreteCreator classes must define their own generation method and this situation usually appears in the cases where the Creator class can't foresee what ConcreteProduct it will instantiate;

* Creator class is a concrete class, the generating method having a default implementation. If this happens, the ConcreteCreator classes will use the generating method for flexibility rather than for generation. The programmer will always be able to modify the class of the objects that the Creator class implicitly creates, redefining the generation method.

The benefits:

* The main reason for which the factory pattern is used is that it introduces a separation between the application and a family of classes;

* It provides a simple way of extending the family of products with minor changes in application code.