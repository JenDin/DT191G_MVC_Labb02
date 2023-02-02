using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;

namespace AnimalAdoption.Models
{
    // Save each enum as a string instead of a number in the JSON file
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public enum Category
    {
        Cat,
        Dog,
        Bunny,
        Hamster
    }
}