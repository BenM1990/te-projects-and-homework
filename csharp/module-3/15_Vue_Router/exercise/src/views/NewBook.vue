<template>
   <div class="newBook">
       <h1>New Book</h1>
       
       <new-book-form />
       <add-book />
       </div>

</template>

<script>
import NewBookForm from '../components/NewBookForm.vue'
export default {
    components: {
       NewBookForm
    }
}
</script>