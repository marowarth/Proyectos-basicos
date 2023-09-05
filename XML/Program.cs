// Serialización
using System.Xml.Serialization;
using System;
using XML;

Person person = new Person { Name = "Alice", Age = 28 };
XmlSerializer serializer = new XmlSerializer(typeof(Person));

using (StringWriter writer = new StringWriter())
{
    serializer.Serialize(writer, person);
    string xml = writer.ToString();
    Console.WriteLine(xml);
}

// Deserialización
string xmlInput = "<Person><Name>Bob</Name><Age>22</Age></Person>";
using (StringReader reader = new StringReader(xmlInput))
{
    Person deserializedPerson = (Person)serializer.Deserialize(reader);
    Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
}