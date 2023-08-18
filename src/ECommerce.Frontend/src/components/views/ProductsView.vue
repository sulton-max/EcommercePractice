<template>

  <div class="h-full w-full flex items-center justify-center">
    <div>
      <product-grid products="products"></product-grid>
    </div>
  </div>

</template>

<script setup lang="ts">

import {reactive, ref} from "vue";
import type {IProduct} from "@/models/IProduct";
import {Guid} from "guid-typescript";
import ProductGrid from "@/components/grids/ProductGrid.vue";

const isLogin = ref(true);

const products = reactive<Array<IProduct>>([
  {
    id: Guid.createEmpty(),
    name: 'Product 1',
    price: 1,
    imageUrl: 'https://images.uzum.uz/chb49b73jia9r083dni0/t_product_540_high.jpg#1692369570684'
  }
]);

</script>