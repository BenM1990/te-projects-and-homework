<template>

<div>
  <div>
      <img :src=RetrivedMovies.poster_path :alt=RetrivedMovies.movie_id>
  </div>
  <div>
    {{RetrivedMovies.overview}}
  </div>

</div>
</template>

<script>
import Movies from "../services/Movies"; 
export default {
    name:'movie-details',
    data(){
        return{
         RetrivedMovies:''
        }
    },
    methods:{

    },
    computed:{
        movieName(){
            return this.$route.params.movie_name;
        }
    },
    beforeMount(){
        
        Movies.getMovieByName(this.movieName).then((response) => {
        this.RetrivedMovies = response.data;
       })      
    
    }
}
</script>

<style>

</style>