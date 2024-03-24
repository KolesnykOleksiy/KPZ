using Lab2.Subscriptions;

namespace Lab2.Factories;

public class WebSite : ISubscriptionFactory
{
    //private float _monthlyFee;
    private string _description;
    private string _subsciptionType;
    private string _studentCode;

    public WebSite(string description, string subscriptionType, string studentCode = null)
    {
        _description = description;
        _subsciptionType = subscriptionType;
        _studentCode = studentCode;
    }
    public string Description => _description;

    public ISubscription GetSubscription()
    {
        ISubscription subscription = null;

        switch (_subsciptionType)
        {
            case "d":
                subscription = new DomesticSubscription();
                break;
            case "e":
                subscription = new EducationalSubscription(_studentCode);
                break;
            case "p":
                subscription = new PremiumSubscription();
                break;
            default:

                break;
        }

        return subscription;
    }
}