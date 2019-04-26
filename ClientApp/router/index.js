import Vue from 'vue'
import VueRouter from 'vue-router'
// import CounterExample from 'components/counter-example'
// import FetchData from 'components/fetch-data'
// import About from 'components/about'
import HomePage from 'components/home-page'
import HomeMovie from 'components/home-movie'
import MovieList from 'components/movie-list'
import Movie from 'components/movie'



Vue.use(VueRouter)

export default new VueRouter({
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomePage
    },
    // {
    //   path: '/about',
    //   name: 'about',
    //   component: About
    // },
    // {
    //   path: '/counter',
    //   name: 'counter',
    //   component: CounterExample
    // },
    // {
    //   path: '/fetch-data',
    //   name: 'fetch-data',
    //   component: FetchData
    // },
    {
      path: '/home-movie',
      name: 'home-movie',
      component: HomeMovie
    },
    {
      path: '/movie-list',
      name: 'movie-list',
      component: MovieList,
      props: true
    },
    {
      path: '/movie',
      name: 'movie',
      component: Movie,
      props: true
    }
  ]
})
