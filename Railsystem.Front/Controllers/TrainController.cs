using System.Web.Http;
using RailSystem.Service.Data;

namespace Railsystem.Front.Controllers
{
    [RoutePrefix("api")]
    public class TrainController : ApiController
    {
        private readonly ITrainService trainService;

        public TrainController(ITrainService trainService)
        {
            this.trainService = trainService;
        }

        [Route("trainLineStatus/{lineid}")]
        [HttpGet]
        public IHttpActionResult GetLineStatus(int lineid)
        {
            var status = this.trainService.GetTrainLineStatus(lineid);

            if (status != null)
            {
                return this.Ok(status);
            }

            return this.NotFound();
        }

        [Route("trainLines")]
        [HttpGet]
        public IHttpActionResult GetTrainLines()
        {
            var trainLines = this.trainService.GetTrainLines();

            if (trainLines != null)
            {
                return this.Ok(trainLines);
            }

            return this.NotFound();
        }

        [Route("trainStations")]
        [HttpGet]
        public IHttpActionResult GetTrainStations()
        {
            var stations = this.trainService.GetStations();

            if (stations != null)
            {
                return this.Ok(stations);
            }

            return this.NotFound();
        }

        [Route("trainLines/{lineId}/schedules")]
        [HttpGet]
        public IHttpActionResult GetTrainSchedules(int lineId)
        {
            var schedules = this.trainService.GetTrainSchedules(lineId);

            if (schedules != null)
            {
                return this.Ok(schedules);
            }

            return this.NotFound();
        }
    }
}