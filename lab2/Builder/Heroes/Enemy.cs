using System.Text;

namespace Builder.Heroes;

public class Enemy : IPersonage
{
    public string Head { get; set; }
    public string Body { get; set; }
    public string Feets { get; set; }
    
    public string Do { get; set; }

    public override string ToString() =>
        new StringBuilder()
            .Append(Head)
            .Append(Body)
            .Append(Feets)
            .Append(Do)
            .ToString();
}