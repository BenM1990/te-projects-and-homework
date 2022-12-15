using CatCards.Models;
using RestSharp;

namespace CatCards.Services
{
    public class CatFactService : ICatFactService
    {
        public CatFact GetFact()
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest($"https://cat-data.netlify.app/api/facts/random");
            IRestResponse<CatFact> response = client.Get<CatFact>(request);
            
            return response.Data;
        }
    }
}
// You can use `https://cat-data.netlify.app/api/facts/random` to retrieve a random cat fact as a JSON object

/*public Reservation AddReservation(Reservation newReservation)
        {
            //build a request and send it to  http://localhost:3000/reservations 
            //the endpoint doesn't change, but the HTTP method does depending on actions we want to take 
            RestRequest request = new RestRequest("reservations");
            request.AddJsonBody(newReservation); //attach the data to the request 
            IRestResponse<Reservation> response = client.Post<Reservation>(request); //send the request 
            //check for success
            CheckForError(response, $"Add reservation for {newReservation.HotelId}");
            // we know that when we POST to that endpoint, we get a reservation object back with a reservation id
            return response.Data;

        }*/