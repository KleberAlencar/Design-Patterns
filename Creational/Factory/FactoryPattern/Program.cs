using FactoryPattern;
using FactoryPattern.Enums;

IPayment payment = PaymentFactory.GetPayment(EPaymentMethod.GooglePay);
payment.Pay(1000.00);
