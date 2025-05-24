using FactoryPattern.Enums;

namespace FactoryPattern;

public abstract class PaymentFactory
{
    public static IPayment GetPayment(EPaymentMethod paymentMethod)
    {
        return paymentMethod switch
        {
            EPaymentMethod.CreditCard => new CreditCardPayment(),
            EPaymentMethod.PayPal => new PayPalPayment(),
            EPaymentMethod.GooglePay => new GooglePayPayment(),
            EPaymentMethod.ApplePay => new ApplePayment(),
            _ => throw new NotSupportedException("Invalid payment method")
        };
    }
}