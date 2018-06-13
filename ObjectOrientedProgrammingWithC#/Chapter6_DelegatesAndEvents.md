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

Multicasting is an excellent feature of Delegate. In multicasting you can assign more then 1 method to a delegate and when that delegate gets executed, it runs those methods one after another. Using + or += operator you can add methods to a delegate. There is also a way to remove the added methods from the delegate. And to do that you have to use the - or -= operator. Lets see an example to understand clearly what is Multicasting.

```csharp
using System;

namespace MyDelegate
{
	delegate void MathFunc(ref int a);

	class Program
	{
		static void Main(string[] args)
		{
			MathFunc mf;
			MathFunc myAdd = MyMath.add5;
			MathFunc mySub = MyMath.sub3;

			mf = myAdd;
			mf += mySub;
			int number = 10;

			mf(ref number);

			Console.WriteLine($"Final number: {number}");
			
			Console.ReadKey();
		}
	}

	class MyMath
	{
		public static void add5(ref int a)
		{
			a = a + 5;
			Console.WriteLine($"After adding 5 the answer is {a}");
		}

		public static void sub3(ref int a)
		{
			a = a -3;
			Console.WriteLine($"After subtracting 3 the answer is {a}");
		}
	}
}
```

Output:

```shell
After adding 5 the answer is 15
After subtracting 3 the answer is 12
Final number: 12
```

Here we can see how our delegate executed 2 methods one after another. Here we have to keep in mind that, it works like queue, so the first method you will add, will the first method to get executed. Now lets see how we can remove a method from a delegate.

```csharp
using System;

namespace MyDelegate
{
	delegate void MathFunc(ref int a);

	class Program
	{
		static void Main(string[] args)
		{
			MathFunc mf;
			MathFunc myAdd = MyMath.add5;
			MathFunc mySub = MyMath.sub3;
			MathFunc myMul = MyMath.mul10;

			mf = myAdd;
			mf += mySub;
		
			int number = 10;

			mf(ref number);

			mf -= mySub;
			mf += myMul;

			number = 10;

			mf(ref number);


			Console.WriteLine($"Final number: {number}");
			
			Console.ReadKey();
		}
	}

	class MyMath
	{
		public static void add5(ref int a)
		{
			a = a + 5;
			Console.WriteLine($"After adding 5 the answer is {a}");
		}

		public static void sub3(ref int a)
		{
			a = a -3;
			Console.WriteLine($"After subtracting 3 the answer is {a}");
		}

		public static void mul10(ref int a)
		{
			a = a * 10;
			Console.WriteLine($"After multiplying 10 the answer is {a}");
		}
	}
}
```

Output:

```shell
After adding 5 the answer is 15
After subtracting 3 the answer is 12
After adding 5 the answer is 15
After multiplying 10 the answer is 150
Final number: 150
```

So here we can see that first we added two methods in the delegate. Then we removed the sub3 method and added mul10 method. After all these when we executed the delegate, we saw that 5 was added with the number then 10 was multiplied with the number. No subtraction took place.

## Covariance and Contravariance

There are two important features of delegate. Normally what we have learnt so far is, a method to pass in a delegate the method has to match the return type and the parameters. But with converiance and contraveriance you can actually pass methods to a delegate which don't have same return types or parameters and the delegate will be able to execute it. Isn't it interesting. Coveriance is when you assign a method to a delegate which's return type is a derived type of the return type of the delegate. For example if class A is derived from class B and if a delegate returns class B, then a method can be assinged to the delegate even if it returns class A. This is called Coveriance.

On the other hand Contravariance is when a method is passed to a delegate and the parameters of a method doesn't match parameters of the delegate. Here we have to keep in mind that the parameter type of the method has to be atleast derieved from parameter type of the delegate. Now lets see an example of Coveriance & Contravariance:


```csharp

```

## Why delegates?

Delegates are needed mainly for events. When an even triggers, a delegate normally gets activated and do some work.

## Events

Events are something like methods which gets executed on some circumstances and notifies some handlers or delegates about that incident. If i give you a real life example: when you sign in for an email newsletter, you get emails from the website about the latest articles, blog posts or news that are posted recently. It could be daily, weekly, monthly, yearly doesn't matter, the point is, when you opt in, they will notify you by email. And yes its not sent my a human being to manually but its automatic by implementing events in the application. Now you might think, why i need an event for it, can't i send email to the subscriber by a method? Yes, you can but, suppose in the near future you want to also introduce a feature where you will notify on the mobile app, then you have to change the code and add the functionality. And after few days, if you want to send sms to certain subsribers, you have to add it again. And the code will be very much coupled if you do it using normal methods. To solve this kind of problems events are introduced actually. You can create different event handlers and assign to the event, so that when ever the event gets fire, it will notify all the registered handlers. Lets now see an example to make our understanding super clear:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	public delegate void GetResult();

	public class ResultPublishEvent
	{
		public event GetResult PublishResult;

		public void PublishResultNow()
		{

			if (PublishResult != null)
			{
				Console.WriteLine("We are publishing the results now!");
				Console.WriteLine("");
				PublishResult();
			}
		}
	}

	public class EmailEventHandler
	{
		public void SendEmail()
		{
			Console.WriteLine("Results have been emailed successfully!");
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			ResultPublishEvent e = new ResultPublishEvent();

			//Handlers
			EmailEventHandler email = new EmailEventHandler();

			e.PublishResult += email.SendEmail;

			e.PublishResultNow();

			Console.ReadLine();
		}
	}
}

```

## Multicast Event

You can multicast in an event same like we saw in delegate. It means, you can register multiple event-handlers to an event, and all of those will get executed one by one when the events get fired. To multicast, use the += sign to register event-handlers to the event. You can also remove event-handlers from the event by using the -= operator. When you apply multicast, the first event-handler that is register will get exectued first, then the second and so on. By using multicast you can easily extend or reduce event-handlers in your application without doing much work. Let's see an example of multicast:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	public delegate void GetResult();

	public class ResultPublishEvent
	{
		public event GetResult PublishResult;

		public void PublishResultNow()
		{

			if (PublishResult != null)
			{
				Console.WriteLine("");
				Console.WriteLine("We are publishing the results now!");
				Console.WriteLine("");
				PublishResult();
			}
		}
	}

	public class EmailEventHandler
	{
		public void SendEmail()
		{
			Console.WriteLine("Results have been emailed successfully!");
		}
	}

	public class SmsEventHandler
	{
		public void SmsSender()
		{
			Console.WriteLine("Results have been messaged successfully!");
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			ResultPublishEvent e = new ResultPublishEvent();

			//Handlers
			EmailEventHandler email = new EmailEventHandler();
			SmsEventHandler sms = new SmsEventHandler();
			
			e.PublishResult += email.SendEmail;
			e.PublishResult += sms.SmsSender;

			e.PublishResultNow();

			e.PublishResult -= sms.SmsSender;

			e.PublishResultNow();

			Console.ReadLine();
		}
	}
}
```

Output:

```shell

We are publishing the results now!

Results have been emailed successfully!
Results have been messaged successfully!

We are publishing the results now!

Results have been emailed successfully!
```

Now if we analyze the above code we can see we have created another class **SmsEventHandler** and that class has a method **SmsSender**, which follows the same signature of our delegate **GetResult**.

```csharp
public class SmsEventHandler
{
    public void SmsSender()
    {
        Console.WriteLine("Results have been messaged successfully!");
    }
}
```

Then in the main method we have created an instance of this **SmsEventHandler** class and registered the **SmsSender** method to the event.

```csharp
e.PublishResult += sms.SmsSender;
```

After firing the event one time, we are removing the **SmsSender** event-handler from the event by the use of -= operator.

```csharp
e.PublishResult -= sms.SmsSender;
```

When we fire the event again, we can see in the output that just the email event-handler was executed.

## Event Accessors



## .NET Event Guidelines

## Events case study

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
	public delegate void GetResult();

	public class ResultPublishEvent
	{
		public event GetResult PublishResult;

		public void PublishResultNow()
		{
			if (PublishResult != null)
			{
				Console.WriteLine("We are publishing the results now!");
				Console.WriteLine("");
				PublishResult();
			}
		}
	}

	public class PostEventHandler
	{
		public void SendLetter()
		{
			Console.WriteLine("Results have been posted in the mailbox successfully!!");
		}
	}

	public class EmailEventHandler
	{
		public void SendEmail()
		{
			Console.WriteLine("Results have been emailed successfully!");
		}
	}

	public class SmsEventHandler
	{
		public void SmsSender()
		{
			Console.WriteLine("Results have been messaged successfully!");
		}
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			ResultPublishEvent e = new ResultPublishEvent();

			//Handlers
			EmailEventHandler email = new EmailEventHandler();
			SmsEventHandler sms = new SmsEventHandler();
			PostEventHandler post = new PostEventHandler();

			e.PublishResult += email.SendEmail;
			e.PublishResult += sms.SmsSender;
			e.PublishResult += post.SendLetter;

			e.PublishResultNow();

			Console.ReadLine();
		}
	}
}

```

Output:

```shell
We are publishing the results now!

Results have been emailed successfully!
Results have been messaged successfully!
Results have been posted in the mailbox successfully!!
```

If we analyze the above code, we will see that first we have declared a delegate, which returns void and has no parameter

```csharp
public delegate void GetResult();
```

Then we have created a class named **ResultPublishEvent** and inside it we have created an event.

```csharp
public event GetResult PublishResult;
```

this is how you have to create an event. First access modifier then the keyword **event** to let the compiler know that this is an event we are declaring. Then the delegate name, which type of delegates can be registered as a handler. Then the name of the event.

In the same class we also created a method named **PublishResultNow**. This is just to trigger/fire the event. If you see in the method, we have checked if the event is null or not. And only if not null, then we fire the event. The reason behind doing this is, we don't want an event to get fired before no handlers has registered for it.

Then we have 3 classes which has 1 method each. The 3 of the classes are just simulation of different event handlers. Here the emailHandler is representing emailing to the subscriber, SmsClient is representing messaging the customers and PostHandler is representing sending physical letters to the subscriber.

Then in the main method we can see, we have created an instance of the event class and assigned all 3 handler objects to the event using += sign. Then when the ResultPublishEvent methods is instantiated, it fired the event. And when the event gets fired, it notifies all the handlers which registered for this event.


