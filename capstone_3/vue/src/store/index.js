import Vue from 'vue'
import Vuex from 'vuex'
import axios from 'axios'
Vue.use(Vuex)
const currentToken = localStorage.getItem('token')
const currentUser = JSON.parse(localStorage.getItem('user'));
if (currentToken != null) {
  axios.defaults.headers.common['Authorization'] = `Bearer ${currentToken}`;
}
export default new Vuex.Store({
  state: {
    token: currentToken || '',
    user: currentUser || {},
    ProfileID: 0,
    Profile: null,
    MovieList: [],
    seenMovies: [],
    chosenMovies: [],
  },
  mutations: {
    SET_AUTH_TOKEN(state, token) {
      state.token = token;
      localStorage.setItem('token', token);
      axios.defaults.headers.common['Authorization'] = `Bearer ${token}`
    },
    SET_USER(state, user) {
      state.user = user;
      localStorage.setItem('user', JSON.stringify(user));
    },
    ADD_MOVIE(state, movie) {
      state.seenMovies.push(movie);
    },
    SET_MOVIES(state, movieList) {
      state.MovieList = movieList;
    },
    SET_ACTUAL_PROFILE(state, profileData) {
      if (profileData.aboutMe != "" || profileData != null)
      {
        state.Profile = profileData;
      }
      
    },
    SET_PROFILE(state, profileID) {
      state.ProfileID = profileID;
    },
    LOGOUT(state) {
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      localStorage.removeItem('Profile');
      state.token = '';
      state.user = {};
      state.Profile = {};
      state.MovieList = [];
      state.seenMovies = [];
      state.ChosenMovies = {};
      axios.defaults.headers.common = {};
    },
    async ADD_CHOSEN_MOVIE(state, movie) {
      state.chosenMovies.push(movie);
    },
  }
}
);
