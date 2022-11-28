<template>
  <div>
  {{book.title}}
  {{book.author}}
  {{book.isbn}}
  </div>
</template>

<script>
export default {
    props: {
        book: Object
    }
}
</script>

<style>

</style>