<template>
  <div>
      <!--
    <a
      id="show-form-button"
      href="#"
      v-if="showForm === false"
      v-on:click.prevent="showForm = true"
    >Show Form</a>
    <a
      id="hide-form-button"
      href="#"
      v-if="showForm === true"
      v-on:click.prevent="showForm = false"
    >Hide Form</a> -->

    <form v-on:submit.prevent="addNewBook" v-if="showForm === true">
      <div class="new-book-form">
        <label for="title-input">Title:</label>
        <input class="title-input" type="text" v-model="newBook.title" />
      </div>
      <div class="new-book-form">
        <label for="author-input">Author:</label>
        <input class="author-input" type="text" v-model="newBook.author" />
      </div>
      <div class="new-book-form">
        <label for="isbn-input">ISBN:</label>
        <input class="isbn-input" type="text" v-model="newBook.isbn" />
      </div>
      <input type="submit" value="Save" />
      <input type="button" value="Cancel" v-on:click.prevent="resetForm" />
    </form>
  </div>
</template>

<script>
export default {
  name: "add-book",
  data() {
    return {
      showForm: true,
      newBook: {
        read: false,
      },
    };
  },
  methods: {
    addNewBook() {
      this.$store.commit("ADD_BOOK", this.newBook)
      this.resetForm();
    },
    resetForm() {
      this.showForm = false;
      this.newBook = {};
    },
  },
};
</script>

<style>
div.new-book-form {
  margin-top: 10px;
}
div.new-book-form > label {
  display: block;
}
div.new-book-form > input,
div.new-book-form > select {
  height: 30px;
  width: 300px;
}
div.new-book-form > textarea {
  height: 60px;
  width: 300px;
}
form > input[type="button"] {
  width: 100px;
}
form > input[type="submit"] {
  width: 100px;
  margin-right: 10px;
}
</style>