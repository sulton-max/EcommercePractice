<template>

  <div class="w-[230px] h-[300px]">

    <!-- Product Header -->
    <div>
      <img :src="product.imageUrl" alt="Product image" class="w-full h-auto">
    </div>

    <!-- Product Content -->

  </div>

</template>

<script setup lang="ts">

import type {IProduct} from "@/models/IProduct";
import type {PropType} from "vue";

const props = defineProps({
  product: {
    type: Object as PropType<IProduct>,
    required: true
  }
});

</script>