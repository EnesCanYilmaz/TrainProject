using System;
using System.Runtime.Serialization;

namespace TrainProjectAPI.Entities
{
    [DataContract]
    public class ReservationResponse
	{
        public bool ReservationPossible { get; set; }
        public List<PlacementDetail> PlacementDetails { get; set; }
    }
}

