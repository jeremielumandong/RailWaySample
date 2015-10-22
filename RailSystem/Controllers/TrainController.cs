using System.Web.Http;
using RailSystem.Data.Repository;

namespace RailSystem.Controllers
{
    [RoutePrefix("api")]
    public class TrainController : ApiController
    {
        private readonly ITrainLineRepository trainLineRepository;

        public TrainController(ITrainLineRepository trainLineRepository)
        {
            this.trainLineRepository = trainLineRepository;
        }

        [Route("trainLineStatus/{lineid}")]
        [HttpGet]
        public IHttpActionResult GetLineStatus(int lineid)
        {
            var status = this.trainLineRepository.GetStatus(lineid);
            return this.Ok(status);
        }
    }
}