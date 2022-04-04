<template>
	<!--	<ACarousel arrows>-->
	<!--		<template #prevArrow>-->
	<!--			<div class="custom-slick-arrow" style="left: 10px; z-index: 1">-->
	<!--				<LeftCircleOutlined />-->
	<!--			</div>-->
	<!--		</template>-->
	<!--		<template #nextArrow>-->
	<!--			<div class="custom-slick-arrow" style="right: 10px">-->
	<!--				<RightCircleOutlined />-->
	<!--			</div>-->
	<!--		</template>-->
	<!--	</ACarousel>-->

	<VFileInput
		multiple
		label="File input"
	></VFileInput>
</template>

<script lang="ts" src="./homeView.ts"></script>

<style scoped>
	/* For demo */
	.ant-carousel :deep(.slick-slide) {
		text-align: center;
		height: 320px;
		line-height: 160px;
		background: black;
		overflow: hidden;
	}

	.ant-carousel :deep(.slick-arrow.custom-slick-arrow) {
		width: 25px;
		height: 25px;
		font-size: 25px;
		color: #fff;
		background-color: rgba(31, 45, 61, 0.11);
		opacity: 0.3;
		z-index: 1;
	}

	.ant-carousel :deep(.custom-slick-arrow:before) {
		display: none;
	}

	.ant-carousel :deep(.custom-slick-arrow:hover) {
		opacity: 0.5;
	}

	.ant-carousel :deep(.slick-slide h3) {
		color: #fff;
	}
</style>