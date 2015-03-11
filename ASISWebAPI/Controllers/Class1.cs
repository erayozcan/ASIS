
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using ASISModel;
namespace AcilIhbarWebAPI.Controllers
{
    [RoutePrefix("api/Incidents")]
    public class IncidentViewModelsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: IncidentViewModels

        // POST: IncidentViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("InsertIncident")]
        public async Task<IHttpActionResult> InsertIncident(Incident incident)
        {
            if (ModelState.IsValid)
            {
                return Ok();
            }

            return Ok();
        }

        [Route("CreateUser")]
        public async Task<IHttpActionResult> CreateUser(ApplicationUser user)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            if (ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return Ok();
            }

            return Ok();
        }
        




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
