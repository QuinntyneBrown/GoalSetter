using System;

namespace GoalSetter.Domain.Features.Rentals
{
    public class RentalDto
    {
        public Guid RentalId { get; private set; }
        public Guid VehicleId { get; set; }
        public Guid ClientId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public decimal Total { get; set; }
    }
}
