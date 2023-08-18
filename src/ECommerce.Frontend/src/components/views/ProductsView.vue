<template>

  <div class="h-full w-full flex items-center justify-center">
    <div class="md:container p-5">



    </div>
  </div>

</template>

<script setup lang="ts">

import {reactive, ref} from "vue";
import type {IProduct} from "@/models/IProduct";
import {Guid} from "guid-typescript";

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