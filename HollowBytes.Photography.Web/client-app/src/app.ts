import { defineComponent } from "vue";

import {
	HomeOutlined,
	VideoCameraOutlined,
	MenuUnfoldOutlined,
	MenuFoldOutlined,
} from '@ant-design/icons-vue';

export default defineComponent({
	name: "App",
	components: {
		HomeOutlined, VideoCameraOutlined, MenuFoldOutlined, MenuUnfoldOutlined
	},
	data() {
		return {
			collapsed: false,
		}
	},
});