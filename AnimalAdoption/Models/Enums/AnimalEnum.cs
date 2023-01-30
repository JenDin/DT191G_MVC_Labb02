﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;

namespace AnimalAdoption.Models
{
    [Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
    public enum Category
    {
        Cat,
        Dog,
        Bunny,
        Hamster
    }
}