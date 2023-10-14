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

##SRP says
- A class/method should have one reason to change
- A class/method should have only one responsibility
- A class/method should be related to a single purpose

###With SRP we achieve
- Class/method becomes smaller and cleaner
- Now in future updating the code becomes easier


##OCP is second principle of SOLID , most important one and it is linked with SRP.

###Open/Close Principle says
1) Classes/methods/modules should open for extension but closed for modification

2) New functionality should be implemented by adding new class and methods instead of changing the existing class and its methods

###What if I don't follow OCP
- We break SRP
- Effects other part of code
- Difficult to maintain code
- More testing , more headache
- Costly in time/cost and resource.

###Multiple ways to implement OCP
- Using abstract class
- Using interfaces