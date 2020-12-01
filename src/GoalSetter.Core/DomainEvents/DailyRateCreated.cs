using GoalSetter.Core.ValueObjects;
using System;

namespace GoalSetter.Core.DomainEvents
{
    public class DailyRateCreated
    {
        public DailyRateCreated(Guid dailyRateId, Price price)
        {
            DailyRateId = dailyRateId;
            Price = price;
        }

        public Guid DailyRateId { get; set; }
        public Price Price { get; }
    }
}
