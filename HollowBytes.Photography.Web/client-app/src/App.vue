<template>
	<ALayout>
		<ALayoutSider id="components-layout-demo-custom-trigger" v-model:collapsed="collapsed" :trigger="null" collapsible>
			<div class="logo" />
			<AMenu :default-selected-keys="['/']" :selected-keys="[$route.path]" theme="dark" mode="inline">
				<AMenuItem key="1">
					<RouterLink to="/">
						<HomeOutlined class="me-1" />
						<span>
							Home
						</span>
					</RouterLink>
				</AMenuItem>
				<AMenuItem key="2">
					<RouterLink to="/about">
						<VideoCameraOutlined class="me-1" />
						<span>
							About
						</span>
					</RouterLink>
				</AMenuItem>
			</AMenu>
		</ALayoutSider>
		<ALayout>
			<ALayoutHeader class="ps-4" style="background: #fff;">
				<MenuUnfoldOutlined v-if="collapsed"
					class="trigger"
					@click="() => (collapsed = !collapsed)" />
				<MenuFoldOutlined v-else class="trigger" @click="() => (collapsed = !collapsed)" />
			</ALayoutHeader>
			<ALayoutContent :style="{ margin: '24px 16px', padding: '24px', background: '#fff', minHeight: '280px' }">
				<RouterView />
			</ALayoutContent>
		</ALayout>
	</ALayout>
</template>

<script lang="ts" src="./app.ts"></script>

<style>
	#components-layout-demo-custom-trigger .trigger {
		font-size: 18px;
		line-height: 64px;
		padding: 0 24px;
		cursor: pointer;
		transition: color 0.3s;
	}

	#components-layout-demo-custom-trigger .trigger:hover {
		color: #1890ff;
	}

	#components-layout-demo-custom-trigger .logo {
		height: 32px;
		background: rgba(255, 255, 255, 0.3);
		margin: 16px;
	}

	.site-layout .site-layout-background {
		background: #fff;
	}
</style>