namespace Prototype;

public class MutatedVirus : Virus
{
    private string _feature;

    public MutatedVirus(string feature, float weight, int age, string name, string type, MutatedVirus[] viruses = null) : base(
        weight, age, name, type, viruses)
    {
        this._feature = feature;
    }

    public MutatedVirus(MutatedVirus mutatedVirus) : base(mutatedVirus)
    {
        this._feature = mutatedVirus._feature;
    }

    public override IVirus Clone()
    {
        return new MutatedVirus(this);
    }

    public string SetFeature(string feature) // change one field for example
    {
        return this._feature = feature;
    }

    public void ShowInfo()
    {
        Console.WriteLine(
            $"Weight: {_weight} \n Age = {_age}\n Name = {_name}\n Type = {_type}\n Viruses = {_viruses} \n Feature = {_feature} \n \n");
    }
}