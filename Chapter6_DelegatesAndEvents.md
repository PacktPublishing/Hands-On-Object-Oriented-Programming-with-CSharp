# Chapter 6

## Introduction

Events and Delegates! Ok! These words are heavy. Specially if your not a native english speaker, you might think these are some rocket science words! But actually not. Before we will learn what these are meant in programming, lets first try to understand what they are meant in English. Lets first start with Delegate.

## What is Delegate

Delegate in English is like a proxy, an alternative or representative. For example: sometimes we see delegates are coming from different countries to meet someone in a country. Have you ever tried to understand who are they. They are actually representing the country they are coming from. They could be a replacement of the president, prime minister or any other high official of that country. Just for easy to understand, lets think its a delegate of a President. May be the president couldn't make it, so he/she has sent a delegate. The delegate will do the same work that the president was suppose to do on that trip. In software we also have this kind of functionality. We can write a method, which will not be used when the method gets called, but another method will get executed for that original method. So a delegate will actually hold a reference of a method. When the delegate will be called, that method called actually. Now you may ask, why should i call a delegate if that is going to call another method?, why don't i call the method directly? Because if you directly call a method than it becomes fixed. Only that method will be executed when its called, you have no power to decide on runtime.But with delegate the method that will be called by the delegate is decided on runtime, instead of compile time. So upon the situation, in runtime you can decide which method should be called. Let me give you an example to make it clear.

Lets say you have created a calculator and your calculator program has addition and subtraction functionality. Now suppose if you want to

Suppose I have 3 programmers in my group. Every one is an expert in different programming languages. 1 is an expert in C#, another is in Java and another is is Python. Now when my client has asked to send me a person to discuss about the application they are going to develop in the upcoming year, which programmer should i send! I can send any of them, but if the customer wants to develop windows based application or wants to use Microsoft tools, then the C# expert would be the appropriate! but before doing a first meeting with the client i can't determine it. So the first thing i will do is, i will send a delegate of the programmer. He will go and discuss with the client and analyze what would be the best programming language for the project! After the meeting, lets say, the delegate found out that C# would be the appropriate language. So he will assign the C# expert programmer in the project. By sending the delegate first thing is i didn't engage a wrong match and secondly i was able to assign the perfect match on the fly. So thats why we need delegates.

## How to create and use delegate

To create a delegate we need to use the keyword "delegate". Let me show you how to declare a delegate in a general form:

```csharp
delegate return-type name(parameters)
```

now let me show you a real example code:

```csharp
using System;

namespace Delegate1
{
    delegate int MathFunc(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MathFunc mf = new MathFunc(add);

            Console.WriteLine("add");
            Console.WriteLine(mf(4, 5));

            mf = new MathFunc(sub);

            Console.WriteLine("sub");
            Console.WriteLine(mf(4, 5));
            Console.ReadKey();
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return (a > b) ? (a - b) : (b -a);
        }
    }
}

```

Output:

```bash
add
9
sub
1
```

Now lets discuss about this code. At the very top inside the namespace we can see the declaration of the delegate.

```csharp
delegate int MathFunc(int a, int b);
```

We used the keyword "delegate" to let the compiler know that we are declaring a delegate. Then we are setting the return type to "int" and name the delegate "MathFunc". We have also set two parameters for this delegate and those are int type.

Then the program class gets started and in that class we have two methods except main, 1 is "add" another is "sub". If you pay close attention you will see these methods has the same signature as the delegate. This is actually a requirement, delegates can be used for all those methods that has the same signature.

Now if we see the main method, we will find some interesting code. The first line

```csharp
    MathFunc mf = new MathFunc(add);
```

we are creating an object of the delegate. And while doing that we are passing the add method in the constructor. Its actually required. You need to pass a method for which you want to use the delegate. Then we can see when we call the delegate mf(4,5) it returns 9. Which means it is actually calling the add method. After that we are assigning "sub" to the delegate. And upon calling the mf(4,5) this time we are getting 1. Which means "sub" method was called. Like this way, a delegate can be used for many methods which has the same signature.

## Method group conversion

Last example we say, how we are creating an object of delegate and passing the method name in the constructor. Now we will see another way of achieving this thing. Its called Method Group conversion. Here you don't need to initialize the delegate object, you can directly assign the method into it. Let me show you an example:

```csharp
using System;

namespace Delegate1
{
    delegate int MathFunc(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MathFunc mf = add;

            Console.WriteLine("add");
            Console.WriteLine(mf(4, 5));

            mf = sub;

            Console.WriteLine("sub");
            Console.WriteLine(mf(4, 5));
            Console.ReadKey();
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return (a > b) ? (a - b) : (b -a);
        }
        }
    }

```

Here we can see instead of passing the method name in the constructor, we are directly assigning the method into it. This is a shortcut way to assign delegate you can say. Remember in C# programming this is called "Method Group Conversion".

## Using static and instance method as delegates

In the previous examples we have used static methods in delegate. But you can also use Instance methods in delegate. Lets see an example:

```csharp
using System;

namespace Delegate1
{
    delegate int MathFunc(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            MyMath mc = new MyMath();
            MathFunc mf = mc.add;

            Console.WriteLine("add");
            Console.WriteLine(mf(4, 5));

            mf = mc.sub;

            Console.WriteLine("sub");
            Console.WriteLine(mf(4, 5));
            Console.ReadKey();
        }
    }

	class MyMath
	{
		public int add(int a, int b)
		{
			return a + b;
		}

		public int sub(int a, int b)
		{
			return (a > b) ? (a - b) : (b - a);
		}
	}
}

```

So in the above example we can see that we have instance methods under **MyMath** class and to use those methods in delegate, we have to first create an object of that class and simply assign the methods to a delegate using the object instance.

## Multicasting

## Covariance and Contravariance

## Why delegates?