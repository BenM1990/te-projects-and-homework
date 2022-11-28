import Vue from 'vue'
import VueRouter from 'vue-router'
//gotta import the views we want toi use for routes
import Products from '../views/Products.vue'
import ProductDetail from '../views/ProductDetail.vue'
import AddReview from '../views/AddReview.vue'

Vue.use(VueRouter)

const routes = [
 //define routes to views
 //each route is its own object
 {
   path: '/', //this is the route
   name: 'products', //it is good practice to give the route a name
   component: Products //this is the view
 },
 {
   path: '/products/:id', //dynamic route based on the product id
   name: 'product-detail',
   component: ProductDetail
 },
 {
   path: '/products/:id/add-review', //dynamic route for adding a review to a particular product
   name: 'add-review',
   component: AddReview
 }

]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
