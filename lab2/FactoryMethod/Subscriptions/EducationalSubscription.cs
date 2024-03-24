namespace Lab2.Subscriptions;

public class EducationalSubscription : ISubscription
{
    private string _name= "Educational Subscription";
    private float _monthlyFee = 200;
    private float _minSubscriptionPeriod = 365;
    private string[] _channels= ["Educational channel 1", "Educational channel 2"];

    private string _studentCode;
    private string _code = "student";
    private int _discount = 20;

    public EducationalSubscription(string studentCode = null)
    {
        _studentCode = studentCode;
    }

    public string Name => _name;
    public string[] Channels => _channels;
    public float MinSubscriptionPeriod => _minSubscriptionPeriod;
    public float GetPrice() => Discount();

    private float Discount()
    {
        if (_studentCode == _code)
        {
            float num = (_monthlyFee * _discount) / 100;
            return _monthlyFee - num;
        }
        else
        {
            return _monthlyFee;
        }
    }
}
