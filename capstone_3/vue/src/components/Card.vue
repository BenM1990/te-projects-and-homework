<!-- eslint-disable vue/no-parsing-error -->
<template>
  <div
    class="card"
    @mousedown="handelMouseDown"
    @dragstart="handeldragdrop"
    @mousemove="handelMouseMove"
    @mouseup="handelMouseUp"
  >
    <img
      :src="movieObj.poster_path"
      :alt="pcardyKey"
    />
  </div>
</template>

<script>
//import { onMounted } from 'vue';

export default {
  name: "card",
  props: {
    movieObj: {},
    pcardyKey: Number,
  },
  data() {
    return {
      startPoint: null,
      offsetX: null,
      offsetY: null,
      seen: null,
      notseen: null,
      direction: 0,
    };
  },
  

  computed: {
    // styles () {
    //   if (this.pcardyKey % 2 === 0) {
    //     return `transform: rotate(${-4}deg)`;
    //   } else {
    //     return `transform: rotate(${4}deg)`;
    //   }
    // },
  },
  methods: {
    handelMouseDown(event) {
      const { clientX, clientY } = event;
      this.startPoint = { x: clientX, y: clientY };
      this.$el.style.transition = ""; // no transtion when moving
      //   console.log(`MOUSE DOWN IS CLICKED ${this.startPoint.x}`);
    },
    handeldragdrop(event) {
      event.preventDefault();
    },
    handelMouseMove(event) {
      if (!this.startPoint) return;
      const { clientX, clientY } = event;
      this.offsetX = clientX - this.startPoint.x;
      this.offsetY = clientY - this.startPoint.y;

      const rotate = this.offsetX * 0.1;

      //dismiss card when moving too far away

      if (Math.abs(this.offsetX) > this.$el.clientWidth * 0.7) {
        this.direction = this.offsetX > 0 ? 1 : -1;
        console.log(this.direction, this.movieObj.movieId);

         
        this.$emit("sendingData", [this.movieObj.title, this.direction]);

        //  if (this.direction == 1)
        //  {
        //    let name = this.$store.state.MovieList[this.pcardyKey].title;
        //    if (!this.$store.state.seenMovies.includes(this.$store.state.MovieList[this.pcardyKey].title))
        //    {
        //      this.$store.commit("ADD_MOVIE",name)
        //    }
        //  }
        this.dismiss(this.direction);
      }
      this.$el.style.transform = `translate(${this.offsetX}px , ${this.offsetY}px) rotate(${rotate}deg)`;
    },
    handelMouseUp() {
      this.startPoint = null;
      document.removeEventListener("mousemove", this.handelMouseMove);
      this.$el.style.transition = "transform 0.5s"; // we my not need this did
      this.$el.style.transform = "";
    },
    dismiss(direction) {
      this.startPoint = null;
      document.removeEventListener("mouseup", this.handelMouseUp);
      document.removeEventListener("mousemove", this.handelMouseMove);
      this.$el.style.transition = "transform 0.1s";
      this.$el.style.transform = `translate(${
        direction * window.innerWidth
      }px) rotate(${90 * direction}deg)`;
      this.$el.classList.add("dismissing");
      setTimeout(() => {
        this.$el.remove();
      }, 1);
      if (typeof this.onDismiss === "function") {
        this.onDismiss();
      }
      if (typeof this.seen === "function" && direction === -1) {
        this.seen();
        console.log("SEEN", this.direction);
      }
      if (typeof this.notseen === "function" && direction === 1) {
        this.notseen();
        console.log("NOTSEEN", this.direction);
      }
    },
    onseen() {
      this.seen.style.animationPlayState = "running";
    },
    onNnotSeen() {
      this.notseen.style.animationPlayState = "running";
    },
  },
  onMounted() {
    this.seen = document.querySelector("#seen");
    this.notseen = document.querySelector("#notseen");
  },
};
</script>
