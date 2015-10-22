namespace RailSystem.Data.Models
{
    public class TrainLineStations
    {
        public int LineId { get; set; }

        public int StationId { get; set; }

        public int NextStationId { get; set; }

        public int PreviousStationId { get; set; }
    }
}