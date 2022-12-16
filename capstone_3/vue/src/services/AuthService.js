import axios from 'axios';

axios.create();

export default {

  login(user) {
    return axios.post('/login', user)
  },

  register(user) {
    return axios.post('/register', user)
  },

  getProfile(id){
    return axios.get(`/profile/${id}`)
  }

}
