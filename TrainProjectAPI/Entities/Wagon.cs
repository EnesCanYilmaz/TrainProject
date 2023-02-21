using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace TrainProjectAPI.Entities
{
    public class Wagon
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int FullCapacity { get; set; }
    }
}

