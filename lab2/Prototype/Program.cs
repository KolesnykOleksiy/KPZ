// See https://aka.ms/new-console-template for more information

using Prototype;


MutatedVirus mutatedCovid = new MutatedVirus("affects the nervous system", 11, 100, "covid 19", " SARS-CoV-2");

var mutatedCovidOmicron = (MutatedVirus)mutatedCovid.Clone();
mutatedCovidOmicron.SetFeature("affects the lungs");

var mutatedCovidDelta = (MutatedVirus)mutatedCovid.Clone();
mutatedCovidDelta.SetFeature("Affects the circulatory system");

Virus covid =
    new Virus(10, 100, "covid 19", " SARS-CoV-2", new MutatedVirus[]
    {
        mutatedCovid, mutatedCovidDelta, mutatedCovidOmicron
    }); //there must be a IVirus type, but I want to show that my array is being cloned (call GetViruses() method below)

Console.WriteLine("Original mutated virus:");
mutatedCovid.ShowInfo();

Console.WriteLine("Copy mutated virus Omicron:");
mutatedCovidOmicron.ShowInfo();

Console.WriteLine("Copy mutated virus Delta:");
mutatedCovidDelta.ShowInfo();

Virus clonedVirus = (Virus)covid.Clone();

Console.WriteLine("Original virus:");
covid.ShowInfo();
Console.WriteLine("Cloned virus:");
clonedVirus.ShowInfo();

Console.WriteLine(
    $"Are original and cloned viruses sharing same reference to viruses array? {covid.GetViruses() == clonedVirus.GetViruses()}");

Console.WriteLine("Original mutated virus:");
mutatedCovid.ShowInfo();