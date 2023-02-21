using System;
using System.Numerics;
using System.Runtime.Serialization;

namespace TrainProjectAPI.Entities
{
    public class ReservationRequest
	{
        public int NumberOfPeople { get; set; }
        public bool CanSplit { get; set; }
    }
}

