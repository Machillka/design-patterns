namespace Adapter;

// Target -> 支付接口
public interface IPaymentProcesser
{
    /// <summary>
    /// 模拟支付接口
    /// </summary>
    /// <param name="amount">传入的货币数量</param>
    /// <param name="currency">传入的货币单位</param>
    public void Process(float amount, string currency);
}

// 模拟 Paypal 的支付
public class PayPalSdk
{
    public void ReceivePayment(float amount)
    {
        Console.WriteLine("Paypal 接收" + amount);
    }
}

// 模拟 ApplePay 支付方式
public class ApplePalSdk
{
    public void ReceiveMoney(float amount, string currency)
    {
        Console.WriteLine($"ApplePaySDK: 接受到 {amount} {currency}");
    }
}

public class PayPalAdapter : IPaymentProcesser
{
    private readonly PayPalSdk _paypalSdk;

    // 用于 DI
    public PayPalAdapter(PayPalSdk paypal)
    {
        _paypalSdk = paypal;
    }

    /// <summary>
    /// 假设 Paypal 只能接收 美元
    /// </summary>
    /// <param name="amount">支付金额</param>
    /// <param name="_">不使用</param>
    public void Process(float amount, string _)
    {
        Console.WriteLine($"支付了 {amount} 美元");
    }
}

public class ApplePayAdapter : IPaymentProcesser
{
    private readonly ApplePalSdk _applePalSdk;

    public ApplePayAdapter(ApplePalSdk applePalSdk)
    {
        _applePalSdk = applePalSdk;
    }

    public void Process(float amount, string currency)
    {
        _applePalSdk.ReceiveMoney(amount, currency);
        Console.WriteLine($"支付了 {amount} {currency}");
    }
}

// 模拟客户端逻辑
public class OrderService(IPaymentProcesser paymentProcesser)
{
    private readonly IPaymentProcesser _paymentProcesser = paymentProcesser;

    public void CheckOut(float amount, string currency)
    {
        _paymentProcesser.Process(amount, currency);
    }
}