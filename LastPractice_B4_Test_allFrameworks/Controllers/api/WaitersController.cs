using LastPractice_B4_Test_allFrameworks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LastPractice_B4_Test_allFrameworks.Controllers.api
{
    public class WaitersController : ApiController
    {
        public RestrauntDBC DataContext = new RestrauntDBC();
        // GET: api/Waiters
        public IHttpActionResult Get()
        {
            List<Waiter> theWaitersList = DataContext.Waiters.ToList();
            return Ok(new { theWaitersList });
        }

        // GET: api/Waiters/5
        public async Task<IHttpActionResult> Get(int id)
        {
            Waiter theChosenWaiter = await DataContext.Waiters.FindAsync(id);
            await DataContext.SaveChangesAsync();
            return Ok(new { theChosenWaiter });
        }

        // POST: api/Waiters
        public async Task<IHttpActionResult> Post([FromBody] Waiter WaiterToAdd)
        {
            DataContext.Waiters.Add(WaiterToAdd);
            await DataContext.SaveChangesAsync();
            return Ok("Add Successfully.");
        }

        // PUT: api/Waiters/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Waiter WaiterToAdd)
        {
            Waiter theChosenWaiter = await DataContext.Waiters.FindAsync(id);
            theChosenWaiter.Id = WaiterToAdd.Id;
            theChosenWaiter.FirstName = WaiterToAdd.FirstName;
            theChosenWaiter.LastName = WaiterToAdd.LastName;
            theChosenWaiter.Birthday = WaiterToAdd.Birthday;
            theChosenWaiter.WorkHours = WaiterToAdd.WorkHours;

            await DataContext.SaveChangesAsync();

            return Ok(new { EditWhatUWanted = theChosenWaiter });

        }

        // DELETE: api/Waiters/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            Waiter theChosenWaiter = await DataContext.Waiters.FindAsync(id);
            DataContext.Waiters.Remove(theChosenWaiter);
            await DataContext.SaveChangesAsync();
            return Ok(new { DeletedWaiter = theChosenWaiter });

        }
    }
}
