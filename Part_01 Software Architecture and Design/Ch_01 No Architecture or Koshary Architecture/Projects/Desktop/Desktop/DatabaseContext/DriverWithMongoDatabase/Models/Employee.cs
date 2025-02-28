﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koshary_Architecture.DatabaseContext.DriverWithMongoDatabase.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? StreetAndBuildingNumber { get; set; }
        public string Email { get; set; } = "";
        public string? PhoneNumber { get; set; }
        public List<EmployeeSkill>? EmployeeSkills { get; set;}

    }
}
