using GoalSetter.Domain.Features.Vehicles;

namespace GoalSetter.Testing.Builders
{
    public class VehicleDtoBuilder
    {
        private VehicleDto _vehicleDto;

        public VehicleDtoBuilder()
        {
            _vehicleDto = new VehicleDto()
            {
                DailyRate = 1m,
                Year = 2004,
                Make = "Test",
                Model = "Test"
            };
        }

        public VehicleDto Build()
        {
            return _vehicleDto;
        }
    }
}
