<template>
  <div v-if = "movieList.length > 0">
      <h4> {{movieList[counter].title}} </h4>
      <img :src = "movieList[counter].poster_path">
      
      <button v-on:click = "nextMovie"> Click </button>
  </div>
  
</template>

<script>


export default {
  name: 'Movies',

  data(){
    return {
      counter: 0,
      movieList: this.$store.state.MovieList
    }
  },

  methods: {
    nextMovie()
    {
      this.counter++;
    }
  }

}
</script>

<style>

body{
  width: 100vw;
    height: 100vh;
    overflow: hidden;
    display: flex;
    justify-content: space-evenly;
    align-items: center;
    background: linear-gradient(0deg,#4ad6a8, #000000);
}
</style>


