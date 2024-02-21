> [!IMPORTANT]
> This project still in development, feel free to add suggestions and feedbacks.

## [Strategy](https://refactoring.guru/pt-br/design-patterns/strategy)

- The strategy pattern provides a solution for algorithms that may expand with the increasing number of systems they handle. It allows the selection of a strategy based on the current needs, isolating each strategy in its own class to eliminate nested code effectively.

- I developed a system to manage character information by employing the Character Strategy. By passing the Character Strategy to the handler, all the necessary information is encapsulated within the class through the interface. This approach ensures the implementation of new characters is straightforward, avoiding the creation of nested code and maintaining code clarity.
#
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/484b2628-6f07-4960-a15a-39de47896f7f" width="700" height="392"/>
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/9d4573aa-1f03-4c36-a1f9-79aa7e2f1338" width="700" height="392"/>
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/7adafcea-a4d8-47e5-98b6-3a2064efbdc1" align="center" width="700" height="392"/> 

## [Chain of Responsibility](https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility)

- The Chain of Responsibility is an effective system for managing requests, as it operates on the principle of assigning responsibility to different parts of the system. It evaluates each request and forwards it or denies it based on the current rules applied.

- I developed an interactive chat for the English Language, designed to filter sentences containing numbers or accents and with the incorrect amount of words. The existing filter incorporates two rules but can be easily scaled to accommodate more than ten, making it a robust solution for handling various scenarios such as password filtering and other similar tasks.
#

<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/5df5884b-9023-45d5-851d-49a361c156dd" width="700" height="392"/>
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/b13cb1c1-4dbd-47f9-bdc6-7321dae62dad" width="700" height="392"/>
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/0d47177e-688e-434c-b3c8-6fba45d7f344" align="center" width="700" height="392"/> 

## [Singleton](https://refactoring.guru/pt-br/design-patterns/singleton)

- The Singleton pattern is an incredible solution to ensure a single instance that allows access to any other object by being created as a static class. Its applications are limitless, as long as the code maintains a clear responsibility and adheres to this pattern. This prevents code nesting and provides a wide range of applications.

- I created an audio mixer that manages sounds to prevent them from playing simultaneously, avoiding volume increases, and adds a variation in pitch to create pleasant auditory feedback.
#
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/a0fa9b0b-2ccb-4f9d-9c60-441a96f66d5b" align="center" width="700" height="392"/> 

## [Factory](https://refactoring.guru/pt-br/design-patterns/factory-method)

- The factory pattern is an incredible solution for managing the creation of various entities that share a common purpose but may exhibit different behaviors. It eliminates the potential for creating nested code, enhancing readability by implementing a system that facilitates the creation of diverse objects adhering to the same interface.

- I implemented the Factory Pattern by establishing several distinct factories that produce objects adhering to a shared interface. This enables these objects to execute optimal actions based on their properties.
#
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/ff201fff-04b7-4fee-a980-eb37d846d11a" align="center" width="700" height="392"/> 

## [Abstract Factory](https://refactoring.guru/pt-br/design-patterns/abstract-factory)

- The Abstract Factory facilitates the creation of different variations of the same object in a performant manner, without specifying a concrete class. It allows clients to create objects without knowing the exact class, achieving this by separating each factory into its own class and follow the same interface. This separation enables exclusive interaction between the factory and the object created by it, preventing different classes from returning unrelated objects.

- I implemented an Abstract Factory for sushi, where each type of sushi has its own factory. Clients placing orders don't need to be aware of the specific factory, as the abstract class is passed for interaction. This design choice enhances scalability, enabling the addition of new sushi types to the system without significant effort. 
#
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/fcfd0608-0e82-4a35-b094-93dcd8731185" align="center" width="700" height="392"/> 

## [Builder](https://refactoring.guru/pt-br/design-patterns/builder)

- The builder pattern addresses the challenge of creating complex objects by enabling their construction in a structured manner through sequential steps. This can be accomplished either by manually coding each step or by providing a predefined sequence, enhancing readability and expediting the creation process.

- I developed an Airship Builder that systematically integrates the essential components of an airship, allowing the addition of attributes in a step-by-step fashion. The primary objective was to establish a scalable system that operates seamlessly through a graphical user interface (GUI). With this system, creating various airship configurations, including the one mentioned, becomes a straightforward and efficient process.
 #
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/1a2524e4-3448-4ccb-ba0f-858715c33c85" align="center" width="700" height="392"/> 
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/66f3a711-1576-49b2-abb4-f7ded9003c9c" align="center" width="700" height="392"/> 

## [Prototype](https://refactoring.guru/pt-br/design-patterns/prototype)

- The prototype pattern is responsible for creating a copy of objects that adhere to their interfaces. This copy includes all the changes that have occurred since the class was originally created. In addition, it provides the opportunity to avoid the need for creating a new class using the 'new' keyword, making it an excellent option for iterating through objects and creating copies when necessary.
  
- Thinking about these games where we have the opportunity to control hordes with many attributes, I was able to create a sample where the monsters follow the prototype that the player can interact with by changing their strength. This could be scalable to any other attributes, reflecting the properties of the core prototype throughout the entire horde.

<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/102834fd-f0ac-4a96-a0c8-9380ec498a7a" align="center" width="700" height="392"/> 

## [Adapter](https://refactoring.guru/pt-br/design-patterns/adapter)

- The Adapter pattern provides a solution to integrate systems with different interfaces that were unable to communicate properly by introducing an Adapter. This Adapter covers one of the systems without revealing its existence to the requesting system. This enables working with different systems that need to interact but face communication barriers.

- The Color Switcher is a system designed to handle RGB values and Hex values for color manipulation within a game. The Adapter comes into play when it creates the capability to convert RGB into Hex code and subsequently into color. This feature proves useful in scenarios where direct manipulation with RGB values is not feasible.

<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/3d8d7a7d-6c91-41fa-a030-378c98cb4134" align="center" width="700" height="392"/> 

## [Bridge](https://refactoring.guru/pt-br/design-patterns/bridge)

- The Bridge pattern is a solution that intends to connect the abstract part of the code with the implementation without coupling them. All the changes needed after the pattern settles are related to the low level, allowing the code to be very sustaintable. Beside of this, it's possible to create a bunch of objects that has the same interface and controll them with the same remote.

- I applied the pattern in the context of character controll, being able to controll all the characters that follow the initial interface and implement them, by doing this,  it's possible to create a bunch of new characters with different properties and action that can be controlled by the player, a solution who's alligned with the Single Responsibility Principe and the Open Closed Principle.

<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/fec599dd-ad79-424f-97b7-bccbe8c8676f" align="center" width="700" height="392"/> 

## [Composite](https://refactoring.guru/pt-br/design-patterns/composite)

- The composite pattern provides a solution to systems that are similar to trees, composed by objects which may lead to other ones having different executions or none at all. That being said, the pattern provides a solution based on a recursive method that will traverse all the objects in this hierarchy, executing their methods. It is used to combine values, imagine a box that has other items inside, including other boxes with more items. It's possible to work with all of them if they're all using the same interface. 

- I created a loot box system, that are composed of chests who may have coins and other chests inside, so when the player opens the chest, we're able to quickly iterate through all the rewards and return the result of the coins earned. Besides this, I used a scriptable system, aiming to create an accessible system creation to non developers. That being said, the coins can be used to upgrade attributes, so try your luck! 

<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/9c4489f3-e1a6-4ebf-8922-f505f0382cf4" align="center" width="700" height="392"/> 
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/3bec0764-237c-4694-9e95-d7a0270bfa2f" align="center" width="700" height="392"/> 

# [Decorator](https://refactoring.guru/pt-br/design-patterns/decorator)

- The Decorator pattern solves the problem of scalability in code in an elegant way. By avoiding the creation of subclasses that would quickly result in nested code, this is achievable because the core system maintains the protection of its logic and only scales the system. This allows for the creation of new objects with the same characteristics without requiring changes to the less abstract parts of the code. We are able to dynamically assign new responsibilities to a family of objects without changing the core system.

- Thinking about this description, I created a system that enables the purchase of items in the shop and stores them in the inventory. The family of items that can be stored has different properties that enable purchasing and increase their costs when selling, thus scaling the initial system that only provided basic properties. I also utilized a Scriptable Object system aiming to preserve the OCP principle as requested by the pattern and to keep the option to create new objects and scale the functionalities open to other developers and product owners.

<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/a22f8439-c4a9-45f4-9eae-120165d5eb52" align="center" width="700" height="392"/> 
<img src="https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/53549f80-2cd2-4da6-a768-1058c786db92" align="center" width="700" height="392"/> 
