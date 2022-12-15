using CatCards.Models;
using System.Collections.Generic;

namespace CatCards.DAO
{
    public interface ICatCardDao
    {
        List<CatCard> GetAllCards();

        CatCard GetCard(int id);

        CatCard SaveCard(CatCard cardToSave); // cardToSave is the currently displayed card

        bool UpdateCard(CatCard updatedCard);

        bool RemoveCard(int id);
    }
}