using StrategyPattern;
using StrategyPattern.Enums;

var orderServiceEmail = new OrderService(new EmailService());
orderServiceEmail.ShipOrder(Order.Create(EOrderStatus.Shipped));

var orderServiceSms = new OrderService(new SmsService());
orderServiceSms.ShipOrder(Order.Create(EOrderStatus.Shipped));

var orderServicePush = new OrderService(new PushService());
orderServicePush.ShipOrder(Order.Create(EOrderStatus.Shipped));

var orderServicePostal = new OrderService(new PostalService());
orderServicePostal.ShipOrder(Order.Create(EOrderStatus.Shipped));