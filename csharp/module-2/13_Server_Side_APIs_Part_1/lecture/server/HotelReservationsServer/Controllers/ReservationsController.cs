using HotelReservations.DAO;
using HotelReservations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HotelReservations.Controllers
{
    [Route("reservations")] //localhost:44322/reservations
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private static IReservationDao reservationDao;
        private static IHotelDao hotelDao;
        public ReservationsController()
        {
            if (hotelDao == null)
            {
                hotelDao = new HotelMemoryDao();
            }
            if (reservationDao == null)
            {
                reservationDao = new ReservationMemoryDao();
            }
        }

        //get all reservations
        [HttpGet()]
        public List<Reservation> GetAllReservations()
        {
            return reservationDao.List(); //get all reservations from the DAO and return them
        }

        //get reservations by id

        [HttpGet("{id}")]
        public ActionResult<Reservation> GetReservationById(int id) //parameter name should match token in route
        {
            Reservation reservation = reservationDao.Get(id); // go get information from the DAO

            if(reservation != null)
            {
                return reservation;
            }
            else
            {
                return NotFound(); // return 404
            }
        }

        //get reservations by hotel id
        //even though the expected route is /hotels/:id/reservations

        [HttpGet("{/hotels/{hotelId}/reservations}")] //starting the / yanks control of the rought away from the route attribution and says "nah" 
        public ActionResult<List<Reservation>> ListReservationsByHotel(int hotelId)
        {
            Hotel hotel = hotelDao.Get(hotelId); //something is wrong if the hotel doesn't exist
            if(hotel == null)
            {
                return NotFound();
            }
            return reservationDao.FindByHotel(hotelId); //but I'm okay with an empty list if no one has a reservation
        }


        //add reservation
        [HttpPost()] //POST request to /reservations
        public ActionResult<Reservation> AddReservation(Reservation newReservation) //if expecting a data object, it goes in the parameters (newRestervation)
        {
            Reservation addedReservation = reservationDao.Create(newReservation); //try to add the new reservation to wherever our data comes from
            if(addedReservation != null)
            {
                //return the reservation + the 201 Created status
                //Created(URL of the new thing, the new thing)
                return Created($"/reservations/{addedReservation.Id}", addedReservation);
            }
            else
            {
                return Problem("Can't create this reservation");
            }

        }
        



        //update reservation

        [HttpPut("{id}")] // /reservations/:id
        public ActionResult<Reservation> UpdateReservation(int id, Reservation reservation)
        {
            Reservation existingReservation = reservationDao.Get(id);
            if(existingReservation == null) // if the reservation doesn't exist
            {
                return NotFound(); //404
            }

            //do what you gotta do to update the thign
            Reservation updatedReservation = reservationDao.Update(existingReservation.Id, reservation);

            return updatedReservation;
        }



        //delete reservation
        [HttpDelete("{id}")] // /reservations/:id
        public ActionResult DeleteReservation(int id) //send back an untyped ActionResult since I will never be sending a reservation
        {
            Reservation reservationToDelete = reservationDao.Get(id);
            if (reservationToDelete == null)
            {
                return NotFound(); //404
            }

            bool result = reservationDao.Delete(id);

            if(result) //if true (thing was deleted)
            {
                return NoContent(); //return 204 No Content
            }
            else
            {
                return StatusCode(500);
            }
        }

    }
}
