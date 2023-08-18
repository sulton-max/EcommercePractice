<template>

  <div>
    <div class="grid grid-cols-4">
      <product-card v-for="(product, index) in products" :key="product.id" :product="product"></product-card>
    </div>
  </div>

</template>

<script setup lang="ts">

import type {PropType} from "vue";
import type {IProduct} from "@/models/IProduct";
import ProductCard from "@/components/cards/ProductCard.vue";

const props = defineProps({
  products: {
    type: Array as PropType<Array<IProduct>>,
    required: true
  }
});

</script>