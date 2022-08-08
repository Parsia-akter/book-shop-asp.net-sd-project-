import Vue from 'vue'
//import Router from 'vue-router'
import HomeComponent from './TheHome'
//import Login from '@/components/pages/Login'
//import admin from '@/components/pages/admin/admin'
import ShopComponent from './TheShop'
//import ProductDetails from '@/components/pages/ProductDetails'



/*Vue.use(Router)

export default new Router({
    routes: [
        {
            path: '/',
            name: 'TheHome',
            redirect: '/home'
        },
        {
            path: '/home',
            name: 'home',
            component: TheHome
        },
        {
            path: '/shop',
            name: 'shop',
            component: TheShop
        },
        {
            path: '/productdetails',
            name: 'productdetails',
            component: ProductDetails
        }


    ],
    mode: "history"
})*/
new Vue({
    el: "#app",
    components: {
        HomeComponent,
        ShopComponent
    }
})