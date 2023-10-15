# What is SOLID , why we need these principles and S explained ?
It is combination of 5 design principles such as
S - Single Responsibility Principle (SRP)
O - Open/Closed Principle (ORP)
L - Liskov Substitution Principle (LSP)
I - Interface Segregation Principle (ISP)
D - Dependency Inversion Principle (DIP)

# Why we need SOLID or its benefits
- Better Testability
- Reduces coupling
- Removes Duplication
- Increases Readability
- Increases Extensibility

## SRP says:
- A class/method should have one reason to change
- A class/method should have only one responsibility
- A class/method should be related to a single purpose

## 1.With SRP we achieve:
- Class/method becomes smaller and cleaner
- Now in future updating the code becomes easier

### Example
- Bad: Single class responsible for Signup, Login , Logging Error and Sending the Email.

- Good: Different classes for different purpose
- User Account related (Signup and Login)
- Sending Email related (SendEmail)
- Logging related (LogInformation)

- Now in future we can add LogError,LogWarning in our logging class and ForgotPasword in User Account.
- Suppose if we had kept a single class and we add new methods in that class then its impact would have been everywhere
where class has dependencies.
- In current example I have used just class for demo one can use interface example as well

## 2.OCP is second principle of SOLID , most important one and it is linked with SRP.

### Open/Close Principle says:
1) Classes/methods/modules should open for extension but closed for modification

2) New functionality should be implemented by adding new class and methods instead of changing the existing class and its methods

### What if I don't follow OCP:
- We break SRP
- Effects other part of code
- Difficult to maintain code
- More testing , more headache
- Costly in time/cost and resource.

### Multiple ways to implement OCP:
- Using abstract class
- Using interfaces

### Example 
- Bad: A single method of class responsible for calculating basic salary , when new requirement comes we add a new if condition and solve it
- Good: A base abstract class with abstract method and children class override it according their needs


## 3.LSP is third principle of SOLID , it is extension of open/close principle.

### LSP says:
- Derived class must be correctly substitutable for base class
- Subtypes must be substitutable for their base type (interface, class)
- Sub class should be able to replace objects of base class without affecting
- LSP tell us how to use inheritance properly , if you see somewhere in your code NotImplementedException
then it is most probably violation of LSP.

### Benefits of LSP:
- Code reusability
- More maintainable code
- Better use of inheritance
### Example
- Bad: A base class with some methods and sub classes throwing NotImplementedException for those methods it don't need
- Good: A base class with some methods and sub classes implement those methods and those are needed as well.

## 4.ISP is fourth and second last principle from SOLID principles. At some point ISP and SRP resemble.

### ISP says:
- Class should not be forced to depend on methods it doesn't use
- Split a lengthy interface to small relevant interfaces

### Benefits of ISP:
- Modularity
- Reusability
- Maintainability
- Low coupled code
- Reduces the chances of defects
- Makes code easy to test and deploy independently

### Example
- Bad: Single interface that is responsible card and bank payment processing even if someone would be interested in only one
- Good: Divide single interface to three different interfaces one to process payment and other two for bank and card

## 5.Dependency Inversion Principles is last one in SOLID principles and most important one it says, "High level module should not depend on low level module , instead both should depend on abstractions"

### Benefits
- Decoupling
- Testability
- Reusability

### Multiple ways to implement DIP
- Constructor injection
- Property injection
- Method injection

### Example
- Bad: Instead of using abstraction one using direct instantiation using new keyword everywhere.
- Good: Relying on abstraction , registering dependency and using it via constructor injection (Method and Property injection as well)

### We can achieve dependency injection using default DI container of .NET but we have some third party DI Container as well
- Autofac
- Ninject
- Castle Windsor
# ----------------------------------------------------------------------------------------------------------------

# 𝐃𝐨𝐧’𝐭 𝐑𝐞𝐩𝐞𝐚𝐭 𝐘𝐨𝐮𝐫𝐬𝐞𝐥𝐟 (𝐃𝐑𝐘) 𝐏𝐫𝐢𝐧𝐜𝐢𝐩𝐥𝐞
## It states that don’t repeat yourself what it means it is saying don’t duplicate code , avoid duplication. Purpose is to reduce the redundant code in your application.

## Following the DRY Principle can give us following benefits
1. Improved maintainability of code
2. Reduces the risks of bugs
3. Code becomes easier to understand

## If you are not applying DRY Principle you need to test/debug all process separately for similar code. We can fulfil DRY Principle using Inheritance and Polymorphism.

## Scenario, if you find yourself in a situation where multiple classes are using same properties then you can create a base class that will contain those repeated properties and you can inherit your class from it.

## DRY is not just limited to properties you have to apply at every point to avoid any kind of repetition methods/classes/properties etc.