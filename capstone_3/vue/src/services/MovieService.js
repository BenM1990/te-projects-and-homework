import axios from "axios";

const http = axios.create({
    baseURL: "https://localhost:44315"
  });

export default {

    getMovies(genres){
        return http.post('/movies', (genres))
    }

}