using System;
using System.Runtime.Serialization;

namespace TrainProjectAPI.Entities
{
    [DataContract]
    public class PlacementDetail
	{
        public string WagonName { get; set; }
        public int NumberOfPeople { get; set; }
    }
}

