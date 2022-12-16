<template>
  <div
    id="login"
    class="text-center"
  >
    <form
      class="form-signin"
      @submit.prevent="login"
    >
      <h1
        class="h3 mb-3 font-weight-normal"
        id="signIn"
      >Please Sign In</h1>
      <div
        class="alert alert-danger"
        role="alert"
        v-if="invalidCredentials"
      >
        Invalid username and password!
      </div>
      <div
        class="alert alert-success"
        role="alert"
        v-if="this.$route.query.registration"
      >
        Thank you for registering, please sign in.
      </div>
      <label
        for="username"
        class="sr-only"
      >Username</label>
      <input
        type="text"
        id="username"
        class="form-control"
        placeholder="Username"
        v-model="user.username"
        required
        autofocus
      />
      <br />
      <label
        for="password"
        class="sr-only"
      >Password</label>
      <input
        type="password"
        id="password"
        class="form-control"
        placeholder="Password"
        v-model="user.password"
        required
      />
      <br />
      <button
        type="submit"
        id="button"
      >Sign in</button>
      <br />
      <router-link id = "needact" class = "click" :to="{ name: 'register' }">Need an account?</router-link>
    </form>
    <about-app />
  </div>
</template>
<script>
import authService from "../services/AuthService";
import AboutApp from "../components/AboutApp.vue";
export default {
  name: "login",
  components: { AboutApp },
  data() {
    return {
      user: {
        username: "",
        password: "",
      },
      invalidCredentials: false,
    };
  }, 
  computed:{
   },
  methods: {
    async login() {
      await authService
        .login(this.user)
        .then((response) => {
          if (response.status == 200) {
            this.$store.commit("SET_AUTH_TOKEN", response.data.token);
            this.$store.commit("SET_USER", response.data.user);
            this.$store.commit("SET_PROFILE", response.data.user.userId);
            let checkedId = response.data.user.userId;
            authService.getProfile(checkedId).then(response => {
              console.log(response.data)
            this.$store.commit("SET_ACTUAL_PROFILE", response.data);
            this.$router.push(`/profile/${this.user.username}`); 
        });
          }
        })
        .catch(error => {
          const response = error.response;
          if (response.status === 401) {
            this.invalidCredentials = true;
          }
        });
    }
  }
}
</script>
<style>
@import "../landingstyle.css";
</style>
