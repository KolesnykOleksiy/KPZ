using System.Data;
using System.Transactions;

namespace Lab2.Subscriptions;

public class DomesticSubscription : ISubscription
{
    private string _name= "Domestic Subscription";
    private float _monthlyFee = 100;
    private float _minSubscriptionPeriod = 20;
    private string[] _channels= ["domestic channel 1", "domestic channel 2"];

    public DomesticSubscription()
    {
        
    }

    public string Name => _name;
    public string[] Channels => _channels;
    public float MinSubscriptionPeriod => _minSubscriptionPeriod;
    public float GetPrice() => _monthlyFee;
}