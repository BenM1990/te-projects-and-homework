import axios from "axios";

const http = axios.create({
    baseURL: "https://localhost:44315"
  });

export default {

    getMovies(genresArray){
        return http.post('/movies',  (genresArray));
    },

    getMovieByName(movie_name){
        return http.get(`/movies/${movie_name}`);
    }
}