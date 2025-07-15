namespace Adapter;

// 支付接口
public interface IPaymentProcesser
{
    public void Process(float amount);
}

public class PayPalAdapter : IPaymentProcesser
{
    public void Process(float amount)
    {
    }
}