<template>
   <div>
       <bestseller-list />
       <new-releases-list />

</template>

<script>
import BestsellerList from '../components/BestSellerList'
import NewReleasesList from '../components/NewReleasesList'
export default {
    components: {
        BestsellerList,
        NewReleasesList
    }
}
</script>