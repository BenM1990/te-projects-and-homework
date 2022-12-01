import axios from 'axios';

//name of the axios instance (in this case it is 'http')
const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  getBoards() {
    return http.get('/boards');
    //passes the Promise back to the component
  },

  getCards(boardID) {
    return http.get(`/boards/${boardID}`)
  },

  getCard(boardID, cardID) {
    return http.get(`/boards/${boardID}`).then((response) => {
      const cards = response.data.cards;
      return cards.find(card => card.id == cardID);
    })
    //handles the Promise in the function and passes
    //data back to the component
  }

}
