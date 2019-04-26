// import CounterExample from 'components/counter-example'
// import FetchData from 'components/fetch-data'
// import About from 'components/about'
import HomeMovie from 'components/home-movie'
import HomePage from 'components/home-page'

export const routes = [
  { name: 'home', path: '/', component: HomePage, display: 'Home', icon: 'home' },
  // { name: 'about', path: '/about', component: About, display: 'About Template', icon: 'info' },
  // { name: 'counter', path: '/counter', component: CounterExample, display: 'Counter', icon: 'graduation-cap' },
  // { name: 'fetch-data', path: '/fetch-data', component: FetchData, display: 'Data', icon: 'list' },
  { name: 'home-movie', path: '/home-movie', component: HomeMovie, display: 'Home Movie', icon: 'home' }
]
