using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RailSystem.Data.Models;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Repository
{
    public class TrainScheduleRepository : DataRepositoryBase<TrainSchedule, RailwaySystemContext>, ITrainScheduleRepository
    {
        protected override DbSet<TrainSchedule> DbSet(RailwaySystemContext entityContext)
        {
            return entityContext.TrainSchedules;
        }

        protected override Expression<Func<TrainSchedule, bool>> IdentifierPredicate(RailwaySystemContext entityContext, int id)
        {
            return e => e.TrainId == id;
        }

        public IEnumerable<TrainSchedule> GetTrainSchedules(int trainId)
        {
            return null;
            //return 
        }
    }
}
