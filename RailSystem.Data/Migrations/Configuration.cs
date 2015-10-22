using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using RailSystem.Data.Models;

namespace RailSystem.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<RailwaySystemContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RailwaySystemContext context)
        {
            if (!context.TrainLineStatus.Any())
            {
                var trainsLineStatuses = new List<TrainLineStatus>
                {
                    new TrainLineStatus
                    {
                        Name = "Good",
                        Description = "Optimal condition"
                    },
                    new TrainLineStatus
                    {
                        Name = "Slow",
                        Description = "Not working in optimal condition"
                    },
                    new TrainLineStatus
                    {
                        Name = "Fault",
                        Description = "Track fault not working"
                    }
                };


                context.TrainLineStatus.AddRange(trainsLineStatuses);
                context.SaveChanges();
            }

            if (!context.LineColors.Any())
            {
                var lineColors = new List<LineColor>
                {
                    new LineColor
                    {
                        Name = "Red"
                    },
                    new LineColor
                    {
                        Name = "Blue"
                    },
                    new LineColor
                    {
                        Name = "Yellow"
                    }
                };


                context.LineColors.AddRange(lineColors);
                context.SaveChanges();
            }

            if (!context.Stations.Any())
            {
                var stations = new List<Station>
                {
                    new Station
                    {
                        Id = 1,
                        Name = "Station 1",
                        Description = "Station 1"
                    },
                    new Station
                    {
                        Id = 2,
                        Name = "Station 2",
                        Description = "Station 2"
                    },
                    new Station
                    {
                        Id = 3,
                        Name = "Station 3",
                        Description = "Station 3"
                    },
                    new Station
                    {
                        Id = 4,
                        Name = "Station 4",
                        Description = "Station 4"
                    },
                    new Station
                    {
                        Id = 5,
                        Name = "Station 5",
                        Description = "Station 5"
                    },
                    new Station
                    {
                        Id = 6,
                        Name = "Station 6",
                        Description = "Station 6"
                    },
                    new Station
                    {
                        Id = 7,
                        Name = "Station 7",
                        Description = "Station 7"
                    },
                    new Station
                    {
                        Id = 8,
                        Name = "Station 8",
                        Description = "Station 8"
                    },
                    new Station
                    {
                        Id = 9,
                        Name = "Station 9",
                        Description = "Station 9"
                    },
                    new Station
                    {
                        Id = 10,
                        Name = "Station 10",
                        Description = "Station 10"
                    },
                    new Station
                    {
                        Id = 11,
                        Name = "Station 11",
                        Description = "Station 11"
                    },
                    new Station
                    {
                        Id = 12,
                        Name = "Station 12",
                        Description = "Station 12"
                    }
                };


                context.Stations.AddRange(stations);
                context.SaveChanges();
            }


            if (!context.Trains.Any())
            {
                var trains = new List<Train>
                {
                    new Train
                    {
                        Id = 1,
                        Code = "TR1"
                    },
                    new Train
                    {
                        Id = 2,
                        Code = "TR2"
                    },
                    new Train
                    {
                        Id = 3,
                        Code = "TR3"
                    },
                    new Train
                    {
                        Id = 4,
                        Code = "TR4"
                    },
                    new Train
                    {
                        Id = 5,
                        Code = "TR5"
                    }
                };


                context.Trains.AddRange(trains);
                context.SaveChanges();
            }


            if (!context.TrainLines.Any())
            {
                var trainLines = new List<TrainLine>
                {
                    new TrainLine
                    {
                        Id = 1,
                        Name = "Red Line",
                        Description = "Red line track",
                        FirstStationId = 1,
                        LastStationId = 5,
                        LineColorId = 1,
                        StatusId = 1
                    },
                    new TrainLine
                    {
                        Id = 2,
                        Name = "Blue Line",
                        Description = "Blue line track",
                        FirstStationId = 6,
                        LastStationId = 9,
                        LineColorId = 2,
                        StatusId = 1
                    },
                    new TrainLine
                    {
                        Id = 3,
                        Name = "Yellow Line",
                        Description = "Yello line track",
                        FirstStationId = 10,
                        LastStationId = 12,
                        LineColorId = 3,
                        StatusId = 1
                    }
                };


                context.TrainLines.AddRange(trainLines);
                context.SaveChanges();
            }

            if (!context.TrainSchedules.Any())
            {
                var schedules = new List<TrainSchedule>
                {
                    new TrainSchedule
                    {
                        TrainId = 1,
                        FromStationId = 1,
                        ToStationId = 2,
                        StartTime = new DateTime(2015, 10, 22, 6, 0, 0),
                        ArriveTime = new DateTime(2015, 10, 22, 6, 15, 0),
                        LineId = 1
                    },
                    new TrainSchedule
                    {
                        TrainId = 1,
                        FromStationId = 2,
                        ToStationId = 3,
                        StartTime = new DateTime(2015, 10, 22, 6, 15, 0),
                        ArriveTime = new DateTime(2015, 10, 22, 6, 30, 0),
                        LineId = 1
                    },
                    new TrainSchedule
                    {
                        TrainId = 1,
                        FromStationId = 3,
                        ToStationId = 4,
                        StartTime = new DateTime(2015, 10, 22, 6, 33, 0),
                        ArriveTime = new DateTime(2015, 10, 22, 6, 50, 0),
                        LineId = 1
                    },
                    new TrainSchedule
                    {
                        TrainId = 1,
                        FromStationId = 4,
                        ToStationId = 5,
                        StartTime = new DateTime(2015, 10, 22, 6, 53, 0),
                        ArriveTime = new DateTime(2015, 10, 22, 7, 20, 0),
                        LineId = 1
                    }
                };


                context.TrainSchedules.AddRange(schedules);
                context.SaveChanges();
            }
        }
    }
}