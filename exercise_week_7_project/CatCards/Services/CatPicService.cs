using CatCards.Models;
using RestSharp;

namespace CatCards.Services
{
    public class CatPicService : ICatPicService
    {
        public CatPic GetPic()
        {
            RestClient client = new RestClient();
            RestRequest request = new RestRequest($"https://cat-data.netlify.app/api/pictures/random");
            IRestResponse<CatPic> response = client.Get<CatPic>(request);

            return response.Data;
        }
    }
}
// You can use the API at `https://cat-data.netlify.app/api/pictures/random` to retrieve the URL of a random cat picture as a JSON object