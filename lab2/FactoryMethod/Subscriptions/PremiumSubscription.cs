namespace Lab2.Subscriptions;

public class PremiumSubscription : ISubscription
{
    private string _name= "Premium Subscription";
    private float _monthlyFee = 300;
    private float _minSubscriptionPeriod = 30;
    private string[] _channels = ["premium channel 1", "premium channel 2"];

    public PremiumSubscription()
    {
       
    }

    public string Name => _name;
    public string[] Channels => _channels;
    public float MinSubscriptionPeriod => _minSubscriptionPeriod;
    public float GetPrice() => _monthlyFee;
}