using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Lab_6.Adapter.Adapter;
using System.Xml.Linq;


namespace Lab_6.Adapter.Person;

internal class Person
{
    private string _name;
    private int _age;
    private string _city;

    public Person(IJsonToString jsonString)
    {
        ParseJson(jsonString);
    }
    private void ParseJson(IJsonToString jsonString)
    {
        string json = jsonString.ConvertToString();
        var personData = JsonSerializer.Deserialize<PersonData>(json);
        _name = personData.name;
        _age = personData.age;
        _city = personData.city;
    }

    public override string ToString()
    {
        return $"Name: {_name};\nAge: {_age}\nCity: {_city};";
    }
}
public class PersonData
{
    public string name { get; set; }
    public int age { get; set; }
    public string city { get; set; }
}