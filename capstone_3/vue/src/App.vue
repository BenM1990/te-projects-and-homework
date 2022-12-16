<template>
  <div id="app">
    <div id="nav">
      <router-link v-bind:to="{ name: 'profile' }" v-if="$store.state.token != ''" class="links">Home</router-link>&nbsp;&nbsp;
      <router-link v-bind:to="{ name: 'logout' }" v-if="$store.state.token != ''" class="links">Logout</router-link>
    </div>
    <router-view />
  </div>
</template>

<style>
  .links {
    display:inline-block;
    padding: 0.5em 3em;
    border: 0.16em solid white;
    margin: 0 0.3em 0.3em 0;
    box-sizing: border-box;
    text-decoration: none;
    text-transform: uppercase;
    font-weight:400;
    background-color: rgb(193,225,193);
    text-align: center;
    transition: all 0.15s;
    color: white;

  }

  .links:hover {
    color: black;
   
   border-color: black;
  }


</style>
