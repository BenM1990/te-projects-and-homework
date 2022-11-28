
<template>
   <div class="Reading List">
       <h1>Reading List</h1>
       <reading-list />
       <a href="/addBook">Add Book to Reading List</a>
       <my-books />
       
       </div>
</template>

<script>
import ReadingList from '../components/ReadingList.vue'
export default {
    components: {
       ReadingList,
    },
}
</script>