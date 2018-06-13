# Chapter 7 - Working with Generics and .NET Collections

## Introduction

Generics is very important topic in C# programming language. To my understanding, it would hard to find any software written in C# which has not used Generics. Before we learn detail about Generics, lets first try to analyze what it means. The English word meaning of Generic is something general, which doesn't have any fixed name or brand. In C# it is kinda similar concept. Generics in C# is used to create a Class, Method, Struct etc general, so that we can use it for different reasons. For example, suppose if you have a general purpose soap, then you can use that soap for any washing task. You can use it to wash your hands, to wash your cloths or even to wash your dirty dishes. But if you have a specific category of soap, like Laundry Detergent, than it can only be used for washing cloths and not for any other use. So Generics can give us some extra power of reusing some code for different purpose. Generics is not something very newly developed feature, but it is available from C# 2. So, for all these years of usage of Generics, it has become more common to programmers. Let see an example of a Generic Class.

``` csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLessions
{
	class Price<T>
	{
		T ob;

		public Price(T o)
		{
			ob = o;
		}

		public void PrintType()
		{
			Console.WriteLine("The type is " + typeof(T));
		}

		public T GetPrice()
		{
			return ob;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Price<int> price = new Price<int>(55);

			price.PrintType();

			int a = price.GetPrice();

			Console.WriteLine("the price is " + a);

			Console.ReadKey();
		}
	}
}

```

Output:

``` shell
The type is System.Int32
the price is 55
```

If you are totally new with the syntex of Generics, you might be very surprise to see the angle brackets <> next to the Price class. And also you might be wondering what is this "T" inside the <>. This is the syntex of Generics in C#. By putting the <> next to the class name we are telling the compiler that this is a generic class. And the T inside the <> is a type parameter. Yes, i know you are asking, now what is a type parameter? A type parameter is like any other parameter in C# programming except it passes a type instead of a value or reference. Now lets analyze the code we have written above.

We created a generic class "Price" and to make it generic we placed <T> next to the class name. Here the T is a type parameter and its not something fixed that you have to use T to reperest the type parameter. You can use anything to represent it. But the normal convention or tradition is to use "T" for type parameter. And if there are more type parameters than V and E are used. There is another popular convention when using 2 or more parameter is to name the parameter like TValue and TKey instead just naming V and E to give a better readability. But as you see we prefixed T even before the word Value and Key, this is done to distinguish between type parameter and general parameter.

Now in the class we first created a variable named "ob" which is a type of T:

``` csharp
T ob;
```

When we will run the program, the type that we will pass in the class, will be the type of this object. So we can say, T is just like a placeholder, which will be replaced with some other concrete C# types (ex. int, double, string or any other complex type) in the runtime.

Then on the next lines we created a constructor:

``` csharp
public Price(T o)
{
    ob = o;
}
```

In the constructor we passed a parameter of type T and then assign the value of passed parameter "o" to local variable "ob". We can do this assignment as the parameter passed in the constructor is also type T.

Then we created a 2 methods:

``` csharp
public void PrintType()
{
    Console.WriteLine("The type is " + typeof(T));
}

public T GetPrice()
{
    return ob;
}
```

Here the first method prints the type of "T". This will be helpful to identify the type when we will run the program. And another method is returning the local variable "ob". And here is we notice that we are returning "T" from the method "GetPrice".

Now if we focus on our main method, we will see the first line we are instantiating our generic class Price with a type parameter as int and passing an integer value 55 to the constructor.

``` csharp
Price<int> price = new Price<int>(55);
```

When we do this, the compiler treats every T in the price class as Int. So the local parameter "ob" will be of int type, when we run the PrintType method it should print "System.Int32" in the screen and when we run the GetPrice method, it should return an Int type value.

Now we can use this Price method for string type as well as its a generic class. And to do that, we just have to set the type parameter as string. Lets add some more code in the above example, which will create a Price object that deals with strings.

``` csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLessions
{
	class Price<T>
	{
		T ob;

		public Price(T o)
		{
			ob = o;
		}

		public void PrintType()
		{
			Console.WriteLine("The type is " + typeof(T));
		}

		public T GetPrice()
		{
			return ob;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Price<int> price = new Price<int>(55);

			price.PrintType();

			int a = price.GetPrice();

			Console.WriteLine("the price is " + a);

			Price<string> priceStr = new Price<string>("Hello People");

			priceStr.PrintType();

			string b = priceStr.GetPrice();

			Console.WriteLine("the priceStr is " + b);

			Console.ReadKey();
		}
	}
}
```

Output:

``` shell
The type is System.Int32
the price is 55
The type is System.String
the priceStr is Hello People

```

## Why do we need Generic

After seeing this example, you might think, why do we need Generic where we can use the type "object". "Object" type can be used for any type in C# and the above example can be fully achieved by the use of object type. Yes, you are right, the above example can be achieved by the use of object type, but there won't be any type safety. Where as what generics is making sure that the type safety is there when executed.

Now if you are like me, you would definitely want to know What is "type safety"? "Type safety" actually means, keeping the type secure or unchangeable when executing any task in the program. This helps us to reduce run time errors.

Now lets write the above program using object type instead of generic to see how generics handle type safety and object type doesn't. 