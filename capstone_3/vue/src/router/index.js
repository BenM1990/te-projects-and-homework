import Vue from 'vue'
import Router from 'vue-router'
import Home from '../views/Home.vue'
import Login from '../views/Login.vue'
import Logout from '../views/Logout.vue'
import Register from '../views/Register.vue'
import store from '../store/index'
import Delete from '../views/DeleteAccount.vue'
import Swiper from '../views/Swiper.vue'
import BrowseMovies from '../views/BrowseMovies.vue'
import MovieDetails from '../views/MovieDetails.vue'
import LandingPage from '../views/LandingPage.vue'

Vue.use(Router)
const router = new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
      path: '/profile/:username',
      name: 'profile',
      component: Home,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: "/login",
      name: "login",
      component: Login,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/logout",
      name: "logout",
      component: Logout,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/register",
      name: "register",
      component: Register,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/delete",
      name: "delete",
      component: Delete,
      meta: {
        requiresAuth: true
      }
    },
    {
      path: "/movies",
      name: "movies",
      component: Swiper,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/browse",
      name: "browse",
      component: BrowseMovies,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: "/movies/:movie_name",
      name: "moviesByName",
      component: MovieDetails,
      meta: {
        requiresAuth: false
      }
    },
    {
      path: '/',
      name: 'landingPage',
      component: LandingPage,
      meta: {
        requiresAuth: false
      }
    }


  ]
})

router.beforeEach((to, from, next) => {
 
  if(from.name=="movies"){

    // save to database
    console.log("Update database");
  }
  
  // Determine if the route requires Authentication
  const requiresAuth = to.matched.some(x => x.meta.requiresAuth);

  // If it does and they are not logged in, send the user to "/login"
  if (requiresAuth && store.state.token === '') {
    next("/login");
  } else {
    // Else let them go to their next destination
    next();
  }
});

export default router;
