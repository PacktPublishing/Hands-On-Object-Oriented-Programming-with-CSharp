# Chapter 2: Hello OOPs: Classes and Objects

[What is OOP?](##What-is-OOP)

[Class in OOP](##Class-in-OOP)

[General Form of a Class](###General-Form-of-a-Class)

[Let's Write A Simple Class](###Let-Us-Write-A-Simple-Class)

[What is an Object](##What-is-an-Object)

[How to create Objects](##How-to-create-Objects)

[Variables in C#](##Variables-in-CSharp)

[Methods in a Class](##Methods-in-a-Class)

[How to create a method](###How-to-create-a-method)

[Components of a method](###Components-of-a-method)

[Constructor of a class](###Constructor-of-a-class)

[Pillars of OOP](##Pillars-of-OOP)

[Inheritance](###Inheritance)

[Encapsulation](###Encapsulation)

[Polymorphism](###Polimorphism)

[Abstraction](###Abstraction)

## What is OOP

"Object Oriented Programming" - this is something special. Our book title has this 3 words in it. If you search in the internet for books on Object Oriented Programming, you might get hundreds of books on this topic. Why is that? What is this actually? Is it a programming language? Is it a technology? A tool? What is it? In this chapter, we will try to understand what is Object Oriented Programming.

As always before proceeding, lets try to analyze the meaning of these words in English. So "Object Oriented Programming" has 3 different words in it. The first word is "Object", according to dictionary an Object is something material which can be seen or touched. So in easy words we can say, something which exists in real world physically is an object. Something which is virtual is not categorized as object.

The second word in the list is "Oriented", which means something that has influence on some event, or something like a guideline. For example, in English we can say "We are oriented towards the building", which means that we are keeping the building in our centre and standing somewhere near to it.

The third word is "Programming", i think i don't need to give any explanation for this word as you are reading this book, you surly have some exposure to programming.

Now if we think about the whole sentence "Object Oriented Programming", i am sure we can feel the sentence. We understand what does it mean. It means that we will do programming keeping objects in the center of our thinking. While we will design a software or just write a piece of code, we will organize our thought or code in objects.

Yes, as objects is the centre or key feature of object oriented programming. We will discuss about objects in a great detail in this chapter.

No lets go back to our first question, what is this "Object Oriented Programming"? Its not a tool, its not a programming language. Its just a concept! It's concept or an idea or a way of work. You can also say, its kind of a rule-set for programming.

In object oriented programming, you try to think your software components into small objects and create relationship with them to connect the application and solve problem. Except object oriented programming there are also other concepts in the programming world, such as Procedural programming. If you have ever written code in C programming language, then you have followed the procedural way. But languages like C#, Java, C++ are developed keeping Object Oriented Programming in mind. So these languages are also called, Object oriented programming language.

Object oriented programming is such a common term now a days in the software industry that we made of short form for it, which is OOP. OOP stands for Object Oriented Programming.

Now let's see how this concept or OOP works. What are the building blocks of this practice.

## Class in OOP

Classes are one of the most important concepts of OOP. Classes are the basis of objects. A class is a blueprint of an object. In OOP you derive objects from classes. Now lets analyze what is a class actually.

A class is a template, its a skeleton which tells what properties it has and what things it can do. In normal circumstances A class itself can't do anything, it just helps creating objects from it.

For example, Human can be catogorized as a class. As when we say Human, we don't mean any particular person, but we mean a kind of creature which has hands, feet, mouth etc and it can walk, talk, eat, think and so many other things. So by te properties and behaviour we are cetogizing or classinfying sometihng. And this classsificaion is named as class in programming.

So we know human is a class and for simplycity lets just say, it has 3 properties.

1. Hight
2. Weight
3. Age

And also it can do 3 things:

1. Walk
2. Talk
3. Eat

### General Form of a Class

To create a class in C#, you have to follow a particular syntax. The general form is:

``` csharp
class class-name {
    // this is class body
}
```

"class" is a reserved keyword in C# and its used to tell the compiler that we want to create a class. To create a class place the keyword "class" and then the name of the class after giving one space. The name of the class can be anything which starts with a character or underscore. Numbers also can be inside a class name.

### Let Us Write A Simple Class

Now lets create our first class of this chapter. Let us imagine that we are developing a software an banking application. As we will be using C# and OOP for development, let's think about few of the classes that we need. Firstly, as its a bank, we can think that there will be a Customer class and a BankAccount class for minimum. Now lets create the Customer class.

``` csharp
class Customer {
    string firstName;
    string lastName;
    string phoneNumber;
    string emailAddress;

    public string GetFullName() {
        return firstName + " " + lastName;
    }
}
```

So now if we analyze the code, we will see that we started with the keyword class and then the name of the class Customer. After that we started the class body by putting curly braces {}. Inside the {}, we placed the variables and methods which are part of the class. According to the above code, firstName, lastName, phoneNumber and emailAddress are local variables to the class and GetFullName is a method which returns a string.

So this is the way, how you can write a class in C#. Its pretty simple.

## What is an Object

We now know what is a class. Now lets understand what is an object. An object is an instance of a class. What i mean by instance is, an implementation of the class. For example: In our bank application we have a Customer class, but that doesn't mean that we actually have a customer in our application. To create an customer, you have to create an object of the customer.

For example, Mr. Jack Jones is a customer of the bank, so we can say, Mr. Jack Jones is an object of Customer class in programming perspective.

### How to create Objects

To create and object of a class you have to use a keyword called "new". Lets see an example of an object:

``` csharp
Customer customer1 = new Customer();
```

here firstly we have put "Customer", which is the name of the class. And this represents the type of the object. After that we have the name of the object. So here we can see that customer1 is the name of the object which is a Customer class type. After that we have an equals sign (=) and then the keyword "new" and after that agian the class name "Customer" with () next to it. So at the right hand side, by the keyword new, we are telling the compiler that we want to create an object of the type Customer. Why we have put () next to Customer? We will talk about that later in this chapter. Now lets focus on the object creation.

So on the right hand side we are telling the compiler to create an object of type Customer and then using the = sign we are assigning that object to customer1 which is a variable of a Customer type.

This is how we can create an object. Lets create another customer object.

``` csharp
Customer customer2 = new Customer();
```

Here we have created another object of the customer class and placed it in a variable named customer2 which is a type of Customer.

## Variables in CSharp

Now in the above code you have seen, when we created the Customer class, we created few variables. You might be thinking what is this variable thing? Variable is something that varies, means its not constant. And in programming when we create a variable, the computer actually allocates a space in memory for it, so that a value of the variable can be stored there.

Let us assign values to the variables of the objects we created above. Lets first work with customer1 object.

``` csharp
Customer customer1 = new Customer();

customer1.firstName = "Jack";
customer1.lastName = "Jones";
customer1.phoneNumber = "98745632"
customer1.emailAddress = "jackjones@email.com"
```

So here we are assigning values to the customer1 object. So in the backend the computer has created space for each variable and kept the values in the momory. So later when ever you access the variable, you will get the value from the memory. Let's see how we can print the firstName.

``` csharp
Console.WriteLine("First name is " + customer1.firstName);
```

the output of this code will be

``` shell
First name is Jack
```

## Methods in a Class

Now lets talk about another important topic of classes and objects and that is Method. Method is a kind a like variable, but instead of storing a value, it stores an action. Means a method can hold a bunch of code, which will be executed when it is called. Lets see the general form of method

``` csharp
access-modifier return-type method-name(parameter-list) {
    // method body
}
```

In the general form we can see, that the first thing in the method declaration is an access-modifier. This will set the access permission of the method. Then we have return-type of the method, it should hold the type that the method will return. For example, string, int, double. Then we have the method-name. After the method name we have () which indicates that it is a method. And in the (), we have parameter-list. The parameter list can be empty or can have 1 or more parameters. Then we have {} which holds the method body. The code that the method will execute will go inside {}.

Any code following this structure will be considered as method to the C# compiler.

### Disection of a method

We know what is a mehtod and the general form of it, now lets create a method example.

``` csharp
public string GetFullName(string firstName, string lastName){
    return firstName + lastName;
}
```

The above code will create a method name GetFullName. This method takes two parameters, one is "firstName" another is "lastName", these are placed inside the (). And we can also see that we had to specify the type of those parameters. In this particular example both the parameter types are "string".

If we see the method body, which is the section between {}. We will see that the code is returning "firstName + lastName", which means, concat the two parameters firstName and lastName and return the string. As we are planning to return a string from this method, we set the return type of the method to string.

Another thing to notice is that the access type is set as public for this method, which means that any other class can access this method.

### Constructor of a class

In every class there is a special type of method. That method is called "Constructor". You can personally create constructor in a class and program it. And if you don't create by yourself the compiler will create a very simple constructor and use it. So if you really don't need a constructor you don't have to create one.

Now lets see what is this constructor and what is its funcationality.

A constructor is a method which gets triggered when an object of a class is created. A constructor is mainly used to set the pre-requisits of the class. For example, if you are creating an object of the class "Human", then that human object must have a date of birth. Withouth date of birth no human can exisits. So you can set this requirement in the constructor. So when ever an object of human class is created the date of birth needs to be given to the object. Yes, you can also program in such a way, if no date of birth is given, set the date of birth as today. But it depends on your applicaions need.

Another example could be, a bank account. When you are creatig a bank account object, you have to provide the bank account holder owner. No bank account can exist witout an owner. So you can set this requirement in constructor.

Now lets see the general form of a constructor.

``` csharp
access-modifier classs-name(parameter-list) {
    // constructor body
}
```

here we can see a diffirence between a constructor and a normal method and that is, a constructor doesn't have a return type. The reason is a constructor can't return anything. Its for initialization, not for any other type of action. And normally the type of access is "public" for constructors. Because if you don't set the constructor as public, no object can be instantiated. If you specifically want to set up this setting that no object can be instantiated of a class, you can set the constructor as "private". This will block instantiating objects of that class. Lets see an example of a constructor:

``` csharp
class BankAccount {

    public string owner;

    public BankAccount(){
        owner = "Some person";
    }
}
```

So in the above example we can see, we have a class called "BankAccount" and it has a variable named "owner". As we know no bank account can exists without an "Owner", we should assign value to owner when an object is created. And to create an constructor we just put public as the access type of the constructor as we want objects to get initiated. We could have asked for the owner value using a parameter.

``` csharp
class BankAccount {

    public string owner;

    public BankAccount(string theOwner){
        owner = theOwner;
    }
}
```

If you put parameters in the constructor, then when initializing the object the parameter needs to be passed.

``` csharp
BankAccount account = new BankAccount("Some Person");
```

Another interesting this is that, you can have multiple constructors in a class. For example, you can have one constructor that takes one argument, where as another doesn't take any argument. Now depending the way you are initializing the object, the respected constructor will be called. For example:

``` csharp
class BankAccount {

    public string owner;

    public BankAccount(){
        owner = "Some person";
    }

    public BankAccount(string theOwner){
        owner = theOwner;
    }
}
```

In the above example, we see two constructors for the class BankAccount. Now when you create an object of BankAccount, if you pass the parameter, it will call the second constructor which will set the value and create the object. If you don't pass a parameter while creating the object, the first constructor will be called. Now if you didn't have one of the constructor, that way of object creation won't be available.

Like if you only have the second constructor which has a one parameter, you won't be able to create an object without passing an argument when creating an object.

Like this, you can have multiple constructors created for a class. If you don't create a class what the compailar does is, it creates an empty constructor for that class.

``` csharp
class BankAccount {

    public string owner;

    public BankAccount(){

    }
}
```

## Pillars of OOP

Object oriented programming is one of the most important programming methodology now a days. The whole concept depends on few ideas. And among those ideas, the top 4 ideas that are essential for the Object Oriented Programming are called "The Pillars of OOP". The 4 pillars are:

1. Inheritance
2. Encapsulation
3. Polymorphism
4. Abstraction

### Inheritance

The word "Inheritance" means inheriting/receiving/deriving something from another thing. A real life example could be, a son has inherited a house of his father. Means the house was owned by father but now the son owns the house. The son has the same power over the house as the father had. This concept of inheritence is one pillar of OOP.

In programming, when one class is derived from another class, then the its called inheritance. Means the derived class will have all the same properties that the parent class had. In programming terminology, the class from which another classes are derived are called parent class and the classes which are derived called child classes.

Lets see an example:

``` csharp
public class Fruit {
    public string Name { get; set; }
    public string Color { get; set; }
}

public class Apple : Fruit {
    public int NumberOfSeeds { get; set; }
}
```

So in the above example, we have used inheritance. We have a parent class called Fruit. This class holds the common property that every fruit has. For example: every fruit has name and color. So we can use this fruit class for all the fruits. Now if we create a class for Apple, that Apple class can inherit the Fruit class, right? Because we know an apple is a fruit. And also the properties of the fruit class are also available in Apple. So the Apple class can inherit Fruit class. By applie inheriting fruit class, we don't need to write the same properties in Apple, which fruit class already has, because when Apple class is inheriting fruit class, its actually inheriting all the properties and methods of fruit class.

### Encapsulation

Encapsulation means encapsulating/hiding/covering. In C# encapsulation is achieved by the access modifiers. The access modifiers that are available in C# are:

1. Public
2. private
3. protected
4. internal
5. internal protected.

Encapsulation is when you want to control the access to a certain class by other classes. For example, you have a bank account class. For security reason, it won't be good if we keep that class accessible by all the classes. May be its better to make Private or any other access specifiers.

This is not only applicable over a class, but you can limit the access over a method or variable in a class. For example, you might need to keep the BankAccount class public, for some reason, but you can make the AccountBalance property private so that no other class can access to this property except the BankAccount class.

``` csharp
public class BankAccount {
    private double AccountBalance { get; set; }
}

```

Like variables and properties you can also use access specifiers to methods. You may write private methods which are not needed by other classes or you don't want to expose to other classes.

``` csharp
public class BankAccount{
    private double AccountBalance { get; set; }
    private double TaxRate { get; set; }

    public double GetAccountBalance() {
        double balanceAfterTax = GetBalanceAfterTax();
        return balanceAfterTax;
    }

    private double GetBalanceAfterTax(){
        return AccountBalance * TaxRate;
    }
}
```

In the above example, the method GetBalanceAfterTax is a method which will not be needed by other classes as in this particular example we only want to provide AccountBalance after tax. So we can make this method private.

Encapsulation is a very important part of OOP. It gives a nice control of the code.

### Abstraction

Abstraction means something which doesn't has an instance in reality but is present as an idea or concept. In programming we use this technique to organize our thoughts. And this is one of the pillar of Object Oriented Programming. In C# we have abstract classes, which implements this concept of Abstraction. Abstract classes are classes which can't have any instance, the classes which implements the abstract class will implement the properties and methods of that abstract class. Lets see an example of Abstract class:

``` csharp
public abstract class Vehicle {
    public abstract int GetNumberOfTyres();
}

public class Bicycle : Vehicle {
    public string Company { get; set; }
    public string Model { get; set; }
    public int NumberOfTyres { get; set; }

    public override int GetNumberOfTyres() {
        return NumberOfTyres;
    }
}

public class Car : Vehicle {
    public string Company { get; set; }
    public string Model { get; set; }
    public int FrontTyres { get; set; }
    public int BackTyres { get; set; }

    public override int GetNumberOfTyres() {
        return FrontTyres + BackTyres;
    }
}
```

In the above example, we have an abstract class called Vehicle. It has one abstract method GetNumberOfTyres(). As its abstract method, this has to overridden by the classes which implements the abstract class. Our class Bicycle and Car implements Vehicle abstract class, so they also overrides the abstract method GetNumberOfTyres(). And if we see the implementation of those methods in those 2 classes, we will see that the implementation is different, and that is the implementation of Abstraction..

### Polymorphism

The word polymorphism means many forms. To understand the concept properly, lets work with an example. Let's think about a person, for example bill gates. We all know bill gates is a great software developer, a businessman, a social worker, a great father, a great husband and also a great human being. One individual but different roles and different tasks. This is polymorphism. When bill gates was developing the software, he was playing a role of a software developer. He was thinking about the code he was writing. Later when he became the CEO of Microsoft, he started managing people and doing business. Its the same Bill Gates, but different role, different responsibilities. One person playing different role in different circumstances can be said as polymorphism.

In C# there are two kinds of polymorphism. Static Polymorphism and Dynamic polymorphism. Static polymorphism is when the role of a method is determined in compile time and Dynamic is when the role of a method is determined in run time.

Method overloading and Operator overloading are static polymorphism examples. Lets see an example of Method overloading

``` csharp
public class Calculator {

    public int AddNumbers(int firstNum, int secondNum){
        return firstNum + secondNum;
    }

    public double AddNumbers(double firstNum, double secondNum){
        return firstNum + secondNum;
    }
}
```

Here we can see we have two methods with the same name AddNumbers. Normally its not allowed to have the same name for a method if the signature is not different. As the parameters are different its allowed by the compiler. And writing a method with same name as another but with different parameters is called method overloading. Its a kind of Polymorphism.

Dynamic polymorphism is the use of Abstract class. When you write an abstract class, no instance can be created from that abstract class. When any other class uses or implements that abstract class, the class also has to implement the abstract methods of that abstract class. And as different classes can implement the abstract class and can have different implementation of the abstract methods, a polymorphic behavior is achieved. Same named methods but different implementation.