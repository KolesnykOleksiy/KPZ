namespace Prototype;

public class Virus : IVirus
{
    protected float _weight; //protected fields for ShowInfo method in child class
    protected int _age;
    protected string _name;
    protected string _type;
    protected MutatedVirus[] _viruses;

    public Virus(float weight, int age, string name, string type, MutatedVirus[] viruses = null)
    {
        _weight = weight;
        _age = age;
        _name = name;
        _type = type;
        _viruses = viruses;
    }

    public Virus(Virus virus)
    {
        this._weight = virus._weight;
        this._age = virus._age;
        this._name = virus._name;
        this._type = virus._type;
        //this._viruses = virus._viruses;
        if (virus._viruses != null)
        {
            this._viruses = new MutatedVirus[virus._viruses.Length];
            for (int i = 0; i < virus._viruses.Length; i++)
            {
                this._viruses[i] = (MutatedVirus)virus._viruses[i].Clone();
            }
        }
        else
        {
            this._viruses = null;
        }
    }

    public virtual IVirus Clone()
    {
        return new Virus(this);
    }

    public string SetName(string name) // change one field for example
    {
        return this._name = name;
    }

    public void ShowInfo()
    {
        Console.WriteLine(
            $"Weight: {_weight} \n Age = {_age}\n Name = {_name}\n Type = {_type}\n Viruses = {_viruses} \n \n");
    }
    
    public MutatedVirus[] GetViruses()
    {
        return _viruses;
    }
   
}