import axios from "axios";

const http = axios.create({
    baseURL: "https://localhost:44315"
  });

export default {

    makeProfile(user_profile){
        return http.post('/profile', user_profile)
    },

    deleteProfile(user_id)
    {
        return http.delete(`/${user_id}`)
    }










}