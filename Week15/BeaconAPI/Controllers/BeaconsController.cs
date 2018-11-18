using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using BeaconAPI.Models;

namespace BeaconAPI.Controllers
{
    public class BeaconsController : ApiController
    {
        private BeaconsEntities db = new BeaconsEntities();

        // GET: api/Beacons
        public IQueryable<Beacon> GetBeacons()
        {
            return db.Beacons;
        }

        // GET: api/Beacons/5
        [ResponseType(typeof(Beacon))]
        public async Task<IHttpActionResult> GetBeacon(int id)
        {
            Beacon beacon = await db.Beacons.FindAsync(id);
            if (beacon == null)
            {
                return NotFound();
            }

            return Ok(beacon);
        }

        // PUT: api/Beacons/5
        [ResponseType(typeof(Beacon))]
        public async Task<IHttpActionResult> PutBeacon(int id, string username, string game, int minutes)
        {
            Beacon beacon = new Beacon();
            beacon.Id = id;
            beacon.Username = username;
            beacon.Game = game;
            beacon.StartTime = DateTime.Now;
            beacon.EndTime = DateTime.Now.AddMinutes(minutes);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != beacon.Id)
            {
                return BadRequest();
            }

            db.Entry(beacon).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BeaconExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok();
        }

        // POST: api/Beacons
        [ResponseType(typeof(Beacon))]
        public async Task<IHttpActionResult> PostBeacon(Beacon beacon)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Beacons.Add(beacon);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = beacon.Id }, beacon);
        }

        // DELETE: api/Beacons/5
        [ResponseType(typeof(Beacon))]
        public async Task<IHttpActionResult> DeleteBeacon(int id)
        {
            Beacon beacon = await db.Beacons.FindAsync(id);
            if (beacon == null)
            {
                return NotFound();
            }

            db.Beacons.Remove(beacon);
            await db.SaveChangesAsync();

            return Ok(beacon);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BeaconExists(int id)
        {
            return db.Beacons.Count(e => e.Id == id) > 0;
        }
    }
}