using Lab2.Subscriptions;

namespace Lab2.Factories;

public interface ISubscriptionFactory
{
    public ISubscription GetSubscription();
    string Description { get; }
}