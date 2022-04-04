import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import vuetify from './plugins/vuetify'
import { loadFonts } from './plugins/webfontloader'
import AntD from 'ant-design-vue';

import 'font-awesome/css/font-awesome.min.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import 'ant-design-vue/dist/antd.min.css';
import '@/assets/scss/app.scss';
loadFonts()

createApp(App)
	.use(router)
	.use(vuetify)
	.use(AntD)
	.mount('#app')
