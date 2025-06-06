using StrategyPattern._01_Approach;
using StrategyPattern._01_Approach.Enums;
using StrategyPattern._02_Approach;

Console.WriteLine("01_Approach Strategy Pattern ===============");
Console.WriteLine(" ");

var orderServiceEmail = new OrderService(new EmailService());
orderServiceEmail.ShipOrder(Order.Create(EOrderStatus.Shipped));

var orderServiceSms = new OrderService(new SmsService());
orderServiceSms.ShipOrder(Order.Create(EOrderStatus.Shipped));

var orderServicePush = new OrderService(new PushService());
orderServicePush.ShipOrder(Order.Create(EOrderStatus.Shipped));

var orderServicePostal = new OrderService(new PostalService());
orderServicePostal.ShipOrder(Order.Create(EOrderStatus.Shipped));

Console.WriteLine(" ");

Console.WriteLine("02_Approach Strategy Pattern ===============");
Console.WriteLine(" ");

var context = new Context();

Console.WriteLine("Client: Strategy is set to normal sorting");
context.SetStrategy((new ConcreteStrategyA()));
context.DoSomething();

Console.WriteLine(" ");

Console.WriteLine("Client: Strategy is set to reverse sorting");
context.SetStrategy((new ConcreteStrategyB()));
context.DoSomething();