<template>
<body>
  <div>
      <h1> Are you sure? </h1>
      <button v-on:click = "deleteUser"> Yes </button>
  </div>
</body>
</template>

<script>
import createProfile from '../services/CreateProfile'



export default {
    name: 'Delete',
    methods: {
        deleteUser()
        {
            createProfile.deleteProfile(this.$store.state.user.userId);
            this.$router.push({
                path: '/login'
            });
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