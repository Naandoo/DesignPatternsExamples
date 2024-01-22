## [Strategy](https://refactoring.guru/pt-br/design-patterns/strategy)

- The strategy pattern provides a solution for algorithms that may expand with the increasing number of systems they handle. It allows the selection of a strategy based on the current needs, isolating each strategy in its own class to eliminate nested code effectively.

- I developed a system to manage character information by employing the Character Strategy. By passing the Character Strategy to the handler, all the necessary information is encapsulated within the class through the interface. This approach ensures the implementation of new characters is straightforward, avoiding the creation of nested code and maintaining code clarity.

<img src="[https://your-image-url.type](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/e6dad123-ff40-4472-9ab0-6d511af1ef8f)" width="100" height="100">

![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/f0876bbe-e0e8-463d-a0e0-620d13c5a43f)
![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/c5784d96-74b2-49c2-bed4-f43bf1c04d4f)

## [Chain of Responsibility](https://refactoring.guru/pt-br/design-patterns/chain-of-responsibility)

- The Chain of Responsibility is an effective system for managing requests, as it operates on the principle of assigning responsibility to different parts of the system. It evaluates each request and forwards it or denies it based on the current rules applied.

- I developed an interactive chat for the English Language, designed to filter sentences containing numbers or accents and with the incorrect amount of words. The existing filter incorporates two rules but can be easily scaled to accommodate more than ten, making it a robust solution for handling various scenarios such as password filtering and other similar tasks.

![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/ecdfd350-2370-4427-8ca9-9ea19c0020b0)
![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/9460d389-e87b-426c-b8e0-93d08c6c2c2f)
![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/052741de-039f-4ba2-942f-fc781b3a66da)


## [Singleton](https://refactoring.guru/pt-br/design-patterns/singleton)

- The Singleton pattern is an incredible solution to ensure a single instance that allows access to any other object by being created as a static class. Its applications are limitless, as long as the code maintains a clear responsibility and adheres to this pattern. This prevents code nesting and provides a wide range of applications.

- I created an audio mixer that manages sounds to prevent them from playing simultaneously, avoiding volume increases, and adds a variation in pitch to create pleasant auditory feedback.

![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/6c308811-5fd5-49b7-b052-6942564cadbb)

## [Factory](https://refactoring.guru/pt-br/design-patterns/factory-method)

- The Abstract Factory facilitates the creation of different variations of the same object in a performant manner, without specifying a concrete class. It allows clients to create objects without knowing the exact class, achieving this by separating each factory into its own class and follow the same interface. This separation enables exclusive interaction between the factory and the object created by it, preventing different classes from returning unrelated objects.

- I implemented an Abstract Factory for sushi, where each type of sushi has its own factory. Clients placing orders don't need to be aware of the specific factory, as the abstract class is passed for interaction. This design choice enhances scalability, enabling the addition of new sushi types to the system without significant effort. 

![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/9a736b80-d1f2-44b9-985e-fbc153926949)

## [Abstract Factory](https://refactoring.guru/pt-br/design-patterns/abstract-factory)

- The Abstract Factory facilitates the creation of different variations of the same object in a performant manner, without specifying a concrete class. It allows clients to create objects without knowing the exact class, achieving this by separating each factory into its own class and follow the same interface. This separation enables exclusive interaction between the factory and the object created by it, preventing different classes from returning unrelated objects.

- I implemented an Abstract Factory for sushi, where each type of sushi has its own factory. Clients placing orders don't need to be aware of the specific factory, as the abstract class is passed for interaction. This design choice enhances scalability, enabling the addition of new sushi types to the system without significant effort. 

![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/5fd53e2e-a4c6-4d8e-b18c-ec554c5bf3d9)

## [Builder](https://refactoring.guru/pt-br/design-patterns/builder)

- The builder pattern addresses the challenge of creating complex objects by enabling their construction in a structured manner through sequential steps. This can be accomplished either by manually coding each step or by providing a predefined sequence, enhancing readability and expediting the creation process.

- I developed an Airship Builder that systematically integrates the essential components of an airship, allowing the addition of attributes in a step-by-step fashion. The primary objective was to establish a scalable system that operates seamlessly through a graphical user interface (GUI). With this system, creating various airship configurations, including the one mentioned, becomes a straightforward and efficient process.

![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/aec53d75-e9a9-40dc-8ecf-2ba2cce95e3b)
![image](https://github.com/Naandoo/DesignPatternsExamples/assets/97987565/e625c583-b37c-44c7-9e83-a95ac28e8b7c)
 
