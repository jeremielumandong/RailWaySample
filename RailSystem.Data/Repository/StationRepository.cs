using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using RailSystem.Data.Models;
using RailwaySystem.Core.Repository;

namespace RailSystem.Data.Repository
{
    public class StationRepository : DataRepositoryBase<Station, RailwaySystemContext>, IStationRepository
    {
        protected override DbSet<Station> DbSet(RailwaySystemContext entityContext)
        {
            return entityContext.Stations;
        }

        protected override Expression<Func<Station, bool>> IdentifierPredicate(RailwaySystemContext entityContext,
            int id)
        {
            return (e => e.Id == id);
        }
    }
}