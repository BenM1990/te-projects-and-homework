using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionMemoryDao();
            }
            else
            {
                dao = auctionDao;
            }
        }

        [HttpGet()]
        public List<Auction> GetAllAuctions(string title_like = "", double currentBid_lte = 0)
        {

            if (dao.SearchByTitle(title_like) != null && currentBid_lte > 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }

            else if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            else if (dao.SearchByTitle(title_like) != null)
            {
                return dao.SearchByTitle(title_like);
            }

            else
            {
                return dao.List();
            }
        }



        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id); 

            if (auction != null)
            {
                return auction;
            }
            else
            {
                return auction;
            }
        }

        [HttpPost()]
        public ActionResult<Auction> CreatAuction(Auction auction) //if expecting a data object, it goes in the parameters (newRestervation)
        {
            Auction newAuction = dao.Create(auction); //try to add the new reservation to wherever our data comes from
            if (newAuction != null)
            {
                //return the reservation + the 201 Created status
                //Created(URL of the new thing, the new thing)
                return Created($"/auctions/{newAuction.Id}", newAuction);
            }
            else
            {
                return Problem("Can't create this auction");
            }

        }

  
    }
}
