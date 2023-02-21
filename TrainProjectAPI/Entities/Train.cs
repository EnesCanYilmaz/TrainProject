using System;
using System.Runtime.Serialization;

namespace TrainProjectAPI.Entities
{
    public class Train
    {
        public string TrainName { get; set; }
        public List<Wagon> Wagons { get; set; }
    }
}

