# Chapter 6

## Introduction

Events and Delegates! Ok! These words are heavy. Specially if your not a native english speaker, you might think these are some rocket science words! But actually not. Before we will learn what these are meant in programming, lets first try to understand what they are meant in English. Lets first start with Delegate.

## What is Delegate

Delegate in English is like a proxy, an alternative or representative. For example: sometimes we see delegates are coming from different countries to meet someone in a country. Have a ever tried to understand who are they. They are actually representing the country they are coming from. They could be a replacement of the president, prime minister or any other high official of that country. Just for easy to understand, lets think its a delegate of a President. Then the person will come and do the same work that the president was suppose to do on that trip. May be the president couldn't make it, so he/she might have sent a delegate of him. In software we also have this kind of functionality. We can write a method, which will not be used when the method gets called, but another method will get executed for that original method. So a delegate will actually hold a reference of a method. When the delegate will be called, that method called actually. Now you may ask, why should i call a delegate if that is going to call another method?, why don't i call the method directly? Because there are other benefits of calling a delegate. First benefit is, which method will be called by the delegate is decided on runtime, instead of compile time. So upon the situation, in runtime you can decide which method should be called. Let me give you an example to make it clear.

Lets say you have created a calculator and your calculator program has addition and subtraction functionality. Now suppose if you want to

Suppose I have 3 programmers in my group. Every one is expert in different programming languages. 1 is an expert in C#, another is in Java and another is is Python. Now when my client has asked to send me a person to discuss about the application they are going to develop in the upcoming year, which programmer should i send! I can send any of them, but if the customer wants to develop windows based application or wants to use Microsoft tools, then the C# expert would be the appropriate! but before doing a first meeting with the client i can't determine it. So the first thing i will do is, i will send a delegate of the programmer. He will go and discuss with the client and analyze what would be the best programming language for the project! After the meeting, lets say, the delegate found out that C# would be the appropriate language. So he will assign the C# expert programmer in the project. By sending the delegate first thing is i didn't engage a wrong match and secondly i was able to assign the perfect match on the fly. So thats why we need delegates.

## How to create and use delegate

## Method group conversion

## Using static and instance method as delegates

## Multicasting

## Covariance and Contravariance

## Why delegates?