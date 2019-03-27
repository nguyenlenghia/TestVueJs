var TimerComponent = (function ($, Vue) {
    var result = {
        template: '<h1>Time: {{timer}} <button v-on:click="getTime">Get Time</button></h1>'
//`
//<div role="alert" v-bind:class="alertClass">
//    Time: {{timer}} <button v-on:click="getTime">Get Time</button>
//</div>
//`
        ,
        props: {
            timer: {
                type: String,
                default: 'test'
            },
        },
        data() {
            return {
                timeout: 0
            };
        },
        methods: {
            getTime() {
                const vm = this;
                const $elm = $(vm.$el);
                //alert(new Date().toISOString());

                vm.$emit("update:timer", new Date().toISOString());
            },
        },
        mounted() {
            const vm = this;

        },
        destroyed() {
            const vm = this;

        },
    };

    Vue.component('TimerComponent', result);
    return result;
})($, Vue);
