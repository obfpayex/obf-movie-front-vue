<template>
  <div>
    <h1>Home Movie</h1>

    <h3>Latest Movie</h3>

    <div v-if="!movie" class="text-center">
      <p>
        <em>Loading...</em>
      </p>
      <h1>
        <icon icon="spinner" pulse=""/>
      </h1>
    </div>
    <p>Original Title : {{movie.originalTitle}}</p>
    <p>Production Year : {{movie.productionYear}}</p>
    <p>Production Year : {{movie.summary}}</p>

    <input v-model="searchText" placeholder="Search text"></input>

    <button type="button" class="btn btn-primary" @click="searchMovie()">Search</button>


  </div>
</template>

<script>export default {

    data() {
      return {
        movie: null,
        searchText: ''
      }
    },

    methods: {
      async loadPage(page) {
        this.currentPage = page

        try {
          let response = await this.$http.get(`/api/movie/getLatest`)
          console.log(response.data)
          this.movie = response.data
        } catch (err) {
          window.alert(err)
          console.log(err)
        }
      },
      searchMovie() {
        try {

           this.$router.push({
             name: 'movie-list',
             params: {originalTitleSearch: this.searchText}
           })


        } catch (err) {
          window.alert(err)
          console.log(err)
        }
      }
    },

    async created() {
      this.loadPage(1)
    }
  }</script>

<style>
</style>
