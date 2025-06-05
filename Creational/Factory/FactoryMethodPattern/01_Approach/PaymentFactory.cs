using FactoryPattern._01_Approach.Enums;

namespace FactoryPattern._01_Approach;

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