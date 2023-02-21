using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrainProjectAPI.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrainProjectAPI.Controllers
{
    [Route("api/[controller]")]
    public class ReservationController : Controller
    {
        readonly TrainReservationContext _context;

        public ReservationController(TrainReservationContext trainReservationContext)
        {
            _context = trainReservationContext;
        }
        public ReservationResponse MakeReservation(Train train, ReservationRequest reservationRequest)
        {
            var response = new ReservationResponse { ReservationPossible  = false, PlacementDetails = new List<PlacementDetail>() };

            if (train == null || reservationRequest == null || reservationRequest.NumberOfPeople <= 0 || train.Wagons == null || train.Wagons.Count == 0)
            {
                return response;
            }

            var availableWagon = train.Wagons.FirstOrDefault(w => w.Capacity - w.FullCapacity >= reservationRequest.NumberOfPeople);

            if (availableWagon == null && reservationRequest.CanSplit)
            {
                var availableWagons = train.Wagons.Where(w => ((double)w.FullCapacity / w.Capacity) < 0.7)
                                                  .OrderBy(w => w.Capacity - w.FullCapacity)
                                                  .ToList();

                var remainingPeople = reservationRequest.NumberOfPeople;

                foreach (var wagon in availableWagons)
                {
                    var availableCapacity = wagon.Capacity - wagon.FullCapacity;

                    if (remainingPeople <= availableCapacity)
                    {
                        response.ReservationPossible = true;
                        response.PlacementDetails.Add(new PlacementDetail { WagonName = wagon.Name, NumberOfPeople = remainingPeople });
                        wagon.FullCapacity += remainingPeople;
                        break;
                    }
                    else
                    {
                        response.ReservationPossible = true;
                        response.PlacementDetails.Add(new PlacementDetail { WagonName = wagon.Name, NumberOfPeople = availableCapacity });
                        wagon.FullCapacity += availableCapacity;
                        remainingPeople -= availableCapacity;
                    }
                }
            }
            else if (availableWagon != null)
            {
                response.ReservationPossible = true;
                response.PlacementDetails.Add(new PlacementDetail { WagonName = availableWagon.Name, NumberOfPeople = reservationRequest.NumberOfPeople });
                availableWagon.FullCapacity += reservationRequest.NumberOfPeople;
            }

            return response;
        }
    }
}
