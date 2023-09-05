// Serialización
using JSON;
using Newtonsoft.Json;
using System;

Person person = new Person { Name = "John", Age = 30 };
string json = JsonConvert.SerializeObject(person);
Console.WriteLine(json);

// Deserialización
string jsonInput = "{\"Name\":\"Jane\",\"Age\":25}";
Person deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonInput);
Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");