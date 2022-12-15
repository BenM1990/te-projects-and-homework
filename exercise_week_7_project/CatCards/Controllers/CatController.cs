using System.Collections.Generic;
using CatCards.DAO;
using CatCards.Models;
using CatCards.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CatCards.Controllers
{
    [Route("/api/cards")]
    [ApiController]
    public class CatController : ControllerBase
    {
        private readonly ICatCardDao cardDao;
        private readonly ICatFactService catFactService;
        private readonly ICatPicService catPicService;

        public CatController(ICatCardDao _cardDao, ICatFactService _catFact, ICatPicService _catPic)
        {
            catFactService = _catFact;
            catPicService = _catPic;
            cardDao = _cardDao;
        }

        [HttpGet()]
        public List<CatCard> GetAllCatCards()
        {
            return cardDao.GetAllCards();
        }

        [HttpGet("random")]
        public CatCard CreateCatCard()
        {
            CatCard catCard = new CatCard();

            catCard.CatFact = catFactService.GetFact().Text;
            catCard.ImgUrl = catPicService.GetPic().File;
            

            return catCard;
        }

        [HttpGet("{id}")]
        public ActionResult<CatCard> GetCatCardById(int id)
        {
            CatCard catCard = cardDao.GetCard(id);
            if(catCard != null)
            {
                return Ok(catCard);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<CatCard> Create(CatCard catCard)
        {
            CatCard newCatCard = cardDao.SaveCard(catCard);
            return Created($"/cards/{newCatCard.CatCardId}", newCatCard);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, CatCard catcard)
        {
            CatCard currentCatCard = cardDao.GetCard(id);
            if (currentCatCard == null)
            {
                return NotFound();
            }
            bool result = cardDao.UpdateCard(catcard);
            if (result == true)
            {
                return Ok(result);
            }
            else
            {
                return Problem("Not purrfect");
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            CatCard catCard = cardDao.GetCard(id);
            if (catCard == null)
            {
                return NotFound();
            }

            cardDao.RemoveCard(id);
            return NoContent();
               
        }
    }
}
// http://localhost:51605
