"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var vue_1 = require("vue");
var icons_vue_1 = require("@ant-design/icons-vue");
exports.default = vue_1.defineComponent({
	name: "App",
	components: {
		HomeOutlined: icons_vue_1.HomeOutlined,
		VideoCameraOutlined: icons_vue_1.VideoCameraOutlined,
		MenuFoldOutlined: icons_vue_1.MenuFoldOutlined,
		MenuUnfoldOutlined: icons_vue_1.MenuUnfoldOutlined
	},
	data: function () {
		return {
			collapsed: false,
		};
	},
});
//# sourceMappingURL=app.js.map