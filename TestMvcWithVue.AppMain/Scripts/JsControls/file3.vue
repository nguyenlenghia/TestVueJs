<template>
    <div class="hello">
        Hello3 {{who}}

        <my-component></my-component>
        <my-component-two></my-component-two>
    </div>
</template>

<script>
    module.exports = {
        data: function () {
            return {
                who: 'world3'
            }
        },
        components: {
            'my-component': httpVueLoader('/Scripts/JsControls/file1.vue'),
            'my-component-two': httpVueLoader('/Scripts/JsControls/file2.vue')
        }
    }
</script>

<style scoped>
    .hello {
        background-color: yellow;
    }
</style>