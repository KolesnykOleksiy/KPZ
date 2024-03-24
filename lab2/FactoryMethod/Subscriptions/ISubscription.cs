namespace Lab2.Subscriptions;

public interface ISubscription
{
    string Name { get; }
    float MinSubscriptionPeriod { get; }
    string[] Channels { get; }
    float GetPrice();
}