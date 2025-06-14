﻿using FactoryMethodPattern._01_Approach;
using FactoryMethodPattern._02_Approach;
using FactoryMethodPattern._01_Approach.Enums;

Console.WriteLine("01_Approach Factory Pattern ================");
Console.WriteLine(" ");

IPayment payment = PaymentFactory.GetPayment(EPaymentMethod.GooglePay);
payment.Pay(1000.00);

Console.WriteLine(" ");

Console.WriteLine("02_Approach Factory Pattern ================");
Console.WriteLine(" ");

Console.WriteLine("App: Launched with the ConcreteCreator1.");
new Client().ClientCode(new ConcreteFactory1());

Console.WriteLine(" ");

Console.WriteLine("App: Launched with the ConcreteCreator2.");
new Client().ClientCode(new ConcreteFactory2());