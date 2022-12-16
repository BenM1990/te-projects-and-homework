<template>

  <div class="home">
    <h1>{{this.$store.state.user.username}}'s Profile</h1>
    <form v-if="isSaved === false">
      <label for="about"> About Me! </label><br>
      <input
        type="textarea"
        v-model="profile.about"
        name="about"
      ><br>
      <label
        v-for="(genre,index) in genreList"
        v-bind:key="index"
        :for="genre"
      > {{genre}} </label><br>
      <input
        type="checkbox"
        v-for="(genre,index) in genreList"
        :key="index"
        :id="genre"
        :value="genre"
        v-model="profile.genres"
        :name="genre"
      ><br>
      <button v-on:click="submitForm"> Submit </button>
    </form>

    <div v-else>
      <h3> {{theProfile.aboutMe}} </h3>
      <h4
        v-for="genre in theProfile.pickedGenres"
        v-bind:key="genre"
      > {{genre}} </h4>
      <h4
        v-for="movie in theProfile.seenMovies"
        v-bind:key="movie"
      > {{movie}} </h4>

    </div>

    <div v-if="seenMovies">
      <div
        v-for="movie in seenMovies"
        v-bind:key="movie"
      >
        <router-link :to="`/movies/${movie.title}`">
          <h4> {{movie.title}} </h4>
        </router-link>
      </div>
    </div>

      <button v-on:click = "deleteButton" id="dltbtn"> Delete Account </button>

      <button v-on:click = "goBrowse" id="browse"> Browse Movies </button>

      
    </div>

</template>


<script>

import createProfile from '../services/CreateProfile'
import MovieService from '../services/MovieService'


export default {
    name: 'Home',
    
    data(){
      return {
        seenMovies: this.$store.state.chosenMovies,
        genreList: [
          "Adventure",
          "Action",
          "Romance",
          "Comedy",
          "Drama"
        ],
        isSaved: (this.$store.state.Profile.pickedGenres).length != 0 ? true : false,

        profile: {
          about: "",
          genres: []
        },
       
        theProfile: this.$store.state.Profile != null ? this.$store.state.Profile : {}

      };
    },

    methods: {
        submitForm() {
          this.isSaved = false;
            let newProfile = {
            AboutMe: this.profile.about,
            UserId: this.$store.state.user.userId,
            SeenMovies: this.$store.state.seenMovies,
            PickedGenres: this.profile.genres
            };
            console.log('we here')
            createProfile.makeProfile(newProfile);
            this.$router.push({path: '/login'});
        },

        deleteButton(){
          this.$router.push({ path: '/delete'});
        },

        goBrowse(){
          MovieService.getMovies(this.theProfile.pickedGenres).then(response => {
            this.$store.commit("SET_MOVIES", response.data)
  
          })
          this.$router.push({path: '/movies'});
        },
  }
  
}

</script>

<style>

  @import '../homeStyle.css';
</style>
