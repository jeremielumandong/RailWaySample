namespace RailSystem.Data.Models
{
    public class TrainLineStation
    {
        public int LineId { get; set; }

        public int StationId { get; set; }

        public int NextStationId { get; set; }

        public int PreviousStationId { get; set; }
    }
}