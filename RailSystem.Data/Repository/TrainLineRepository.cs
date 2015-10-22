using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using RailSystem.Data.Models;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Repository
{
    public class TrainLineRepository : DataRepositoryBase<TrainLine, RailwaySystemContext>, ITrainLineRepository
    {
        public TrainLineStatus GetStatus(int id)
        {
            using (var entityContext = new RailwaySystemContext())
            {
                var trainLine = entityContext.TrainLines.FirstOrDefault(a => a.Id == id);

                if (trainLine != null)
                {
                    return trainLine.TrainLineStatus;
                }

                return null;
            }
        }

        public IEnumerable<TrainSchedule> GetTrainSchedules(int lineId)
        {
            using (var entityContext = new RailwaySystemContext())
            {
                var trainLine = entityContext.TrainLines.FirstOrDefault(a => a.Id == lineId);

                if (trainLine != null)
                {
                    return trainLine.TrainSchedules.ToFullyLoaded();
                }
            }

            return null;
        }

        protected override DbSet<TrainLine> DbSet(RailwaySystemContext entityContext)
        {
            return entityContext.TrainLines;
        }

        protected override Expression<Func<TrainLine, bool>> IdentifierPredicate(RailwaySystemContext entityContext,
            int id)
        {
            return (e => e.Id == id);
        }
    }
}