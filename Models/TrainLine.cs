namespace RailSystem.Data.Models
{
    public class TrainLine
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int FirstStationId { get; set; }

        public int LastStationId { get; set; }

        public int LineColorId { get; set; }

        public int TrainStatusId { get; set; }
    }
}