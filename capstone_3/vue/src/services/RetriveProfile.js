import axios from "axios";

const http = axios.create({
    baseURL: "https://localhost:44315"
  });

export default {

    getProfile(id){
        return http.post(`/profile/${id}`)
    }
}