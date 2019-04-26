<template>
  <div>
    <h1>Movie</h1>


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


  </div>
</template>

<script>
  export default {
    props: {
      oid: {
        type: String,
        default: '0'
      }
    },
    data() {
      return {
        movie: null,

      }
    },
    mounted() {
      this.getMovie();
    },
    methods: {
      async getMovie () {
        try {
          let response = await this.$http.get(`/api/movie/getMovie?oid=${this.oid}`)

          console.log(response.data)
          this.movie = response.data
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
