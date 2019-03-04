# Design Patterns project

In this repo will be described the TMPS' project which will include different patterns such as Creational, Structural and Behavioral.

First of all, below are ilustrated all initial requirements of the project. The project is called Games.

![Application UML](Modeling\Application_ver1_1.png)

As it can be seen from this image the application has different set of Forms, but at each Form in the concrete moment could be initialized only one game. Moreover, each name_of_game class inherits the abstract class Game and implements the IGame interface. It gives the possibility to use the Game abstract class as a protecter in that scence that besides Form1 (default window class of application) could be opened only one Form for one game class. The backend of the corresponding Form will depend on implementation of respective class.

![BatleShip UML](Modeling\UML_ver2_3.png)

Here is presented the content of BattleShip folder, and in it there are implemented several Creational design patterns. All these patterns make the process of Runtime initializations of the objects as easy as it is possible. It's userful, because the user doesn't need to know what and how exactly is implemented in code - all he/she needs is a friendly multifunctional GUI.

The refference to my Github project: _https://github.com/VladGanuscheak/TMPS_

The Singleton pattern in my application: [Singleton](Modeling/Singleton.md)

The Abstract Factory pattern in my application: [Abstract Facory](Modeling/Abstract_Factory.md)

The Factory Method pattern in my application: [Factory Method](Modeling/Factory_Method.md)

The Builder pattern in my application: [Builder](Modeling/Builder.md)

The Prototype pattern in my application: [Prototype](Modeling/Prototype.md)
