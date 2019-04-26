<template>
  <div>
    <h1>List of Movies</h1>
    <div v-if="!movieList" class="text-center">
      <p>
        <em>Loading...</em>
      </p>
      <h1>
        <icon icon="spinner" pulse="" />
      </h1>
    </div>
    <table class="table">
      <thead class="dark-bg text-white">
      <tr>
        <th>originalTitle</th>
        <th>productionYear</th>
        <th>Summary</th>
      </tr>
      </thead>
      <tbody>
      <tr :class="index % 2 == 0 ? 'bg-white' : 'bg-light'" v-for="(movie, index) in movieList" :key="index">
        <td><li @click="getMovie(movie.oid)">{{ movie.originalTitle }}</li> </td>
        <td>{{ movie.productionYear }}</td>
        <td>{{ movie.summary }}</td>
      </tr>
      </tbody>
    </table>


  </div>
</template>

<script>
  export default {
    props: {
      originalTitleSearch: {
        type: String,
        default: 'FIlm'
      }
    },
    data() {
      return {
        movieList: null,

      }
    },
    mounted() {
      this.searchMovie();
    },
    methods: {
      async searchMovie () {
        try {
          console.log(`/api/movie/search?searchMovie=${this.originalTitleSearch}`)
          let response = await this.$http.get(`/api/movie/search?searchMovie=${this.originalTitleSearch}`)

          console.log(response.data)
          this.movieList = response.data
        } catch (err) {
          window.alert(err)
          console.log(err)
        }
      },
      async getMovie(oid) {
        try {

          console.log(' movie list ' + oid)
          this.$router.push({
            name: 'movie',
            params: {oid: oid}
          })


        } catch (err) {
          window.alert(err)
          console.log(err)
        }
      }
    }
  };
</script>

<style>
</style>
