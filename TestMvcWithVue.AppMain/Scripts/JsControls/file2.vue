<template>
    <div class="hello">Hello2 {{who}}</div>
</template>

<script>
    module.exports = {
        data: function () {
            return {
                who: 'world2'
            }
        }
    }
</script>

<style scoped>
    .hello {
        background-color: red;
    }
</style>