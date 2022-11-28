import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../views/Home.vue';
import myBooks from '../views/MyBooks.vue';
import NewBook from '../views/NewBook.vue';
import Details from '../views/Details.vue';

Vue.use(VueRouter);

const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/myBooks',
    name: 'myBooks',
    component: myBooks
  },
  {
    path: '/addBook',
    name: 'NewBook',
    component: NewBook
  },
  {
    path: '/book/:isbn',
    name: 'Book',
    component: Details
  }

];

const router = new VueRouter({
  mode: 'history',
  routes
});

export default router;
