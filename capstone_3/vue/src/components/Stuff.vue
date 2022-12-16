urls: [
      'https://image.tmdb.org/t/p/w500/6FfCtAuVAW8XJjZ7eWeLibRLWTw.jpg',
      'https://image.tmdb.org/t/p/w500/eHuGQ10FUzK1mdOY69wF5pGgEf5.jpg',
      'https://image.tmdb.org/t/p/w500/h5J4W4veyxMXDMjeNxZI46TsHOb.jpg',
      'https://image.tmdb.org/t/p/w500/wby9315QzVKdW9BonAefg8jGTTb.jpg',
      'https://image.tmdb.org/t/p/w500/sav0jxhqiH0bPr2vZFU0Kjt2nZL.jpg',
      'https://image.tmdb.org/t/p/w500/9rsivF4sWfmBzrNr4LPu6TNJhXX.jpg',
      'https://image.tmdb.org/t/p/w500/fPtlCO1yQtnoLHOwKtWz7db6RGU.jpg',
      'https://image.tmdb.org/t/p/w500/z8onk7LV9Mmw6zKz4hT6pzzvmvl.jpg',
      'https://image.tmdb.org/t/p/w500/v7TaX8kXMXs5yFFGR41guUDNcnB.jpg',
      'https://image.tmdb.org/t/p/w500/gQB8Y5RCMkv2zwzFHbUJX3kAhvA.jpg',
      // 'https://image.tmdb.org/t/p/w500/xFuIVB1aPb29vq0G0X9E5p7LuhN.jpg',
      // 'https://image.tmdb.org/t/p/w500/ve72VxNqjGM69Uky4WTo2bK6rfq.jpg',
      // 'https://image.tmdb.org/t/p/w500/170VKibfqMR1k0eaR2pIj830MgW.jpg',
      // 'https://image.tmdb.org/t/p/w500/d0PibPzCK4fVikjoD1PqHovbvkt.jpg',
      // 'https://image.tmdb.org/t/p/w500/c2gsmSQ2Cqv8zosqKOCwRS0GFBS.jpg',
      // 'https://image.tmdb.org/t/p/w500/6KWnXYoV1htDT3TGYdFWucfTt6t.jpg',
      // 'https://image.tmdb.org/t/p/w500/vfzE3pjE5G7G7kcZWrA3fnbZo7V.jpg',
      // 'https://image.tmdb.org/t/p/w500/gycdE1ARByGQcK4fYR2mgpU6OO.jpg',
      // 'https://image.tmdb.org/t/p/w500/ceG9VzoRAVGwivFU403Wc3AHRys.jpg',
      // 'https://image.tmdb.org/t/p/w500/acgJPtbeXdBaKYAUVdfYLVwKzAC.jpg',
      // 'https://image.tmdb.org/t/p/w500/lMWWs7IskGldLfwwnVxHhffsVLw.jpg',
      // 'https://image.tmdb.org/t/p/w500/qcF8qt8toajvQllOMVRCUqZCxjV.jpg',
      // 'https://image.tmdb.org/t/p/w500/ehGpN04mLJIrSnxcZBMvHeG0eDc.jpg',
      // 'https://image.tmdb.org/t/p/w500/8kSerJrhrJWKLk1LViesGcnrUPE.jpg',
      // 'https://image.tmdb.org/t/p/w500/jtNOfwZu3zea5grnqpq4nyqXoID.jpg',
      // 'https://image.tmdb.org/t/p/w500/ekstpH614fwDX8DUln1a2Opz0N8.jpg',
      // 'https://image.tmdb.org/t/p/w500/xlBivetfrtF84Yx0zISShnNtHYe.jpg',
      // 'https://image.tmdb.org/t/p/w500/biznhvfedHPp9GKjlVFXH6OZtyU.jpg',
      // 'https://image.tmdb.org/t/p/w500/56mOJth6DJ6JhgoE2jtpilVqJO.jpg'
    ]

    <div id="swiper">

    <h1>This is the home view</h1>
    <card
      v-for="(urlpath,index) in urlList"
      :key="index"
      :pcardy='urlpath'
      :pcardyKey='index'
    />

  </div>

  // @ is an alias to /src

import Card from '../components/Card.vue'
export default {
  name: 'HomeView',
  components: {
    Card
  },
  data(){
    return{
      urlList :this.$store.state.urls,
    };
  }
}
</script>
<style   scoped src="@/assets/style.css">

</style>
