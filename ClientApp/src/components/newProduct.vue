<template>
  <div class="container pt-2">

    <div class="mb-3">
      <label for="exampleInputName" class="form-label">Название товара</label>
      <input v-model="nameProduct" type="text" class="form-control" id="exampleInputName">
    </div>
    <div class="mb-3">
      <label for="exampleInputValue" class="form-label">Объем товара</label>
      <input v-model="value" type="text" class="form-control" id="exampleInputValue">
    </div>
    <div class="mb-3">
      <label for="exampleInputWarehouseIn" class="form-label">На какой склад</label>
      <input v-model="wareIn" type="text" class="form-control" id="exampleInputWarehouseIn">
    </div>
    <router-link :to="{ name: 'BalanceReport'}" @click="addProd" class="btn btn-primary">ДОБАВИТЬ</router-link>

  </div>
</template>

<script>
import {mapMutations} from "vuex";

export default {
  name: "newProduct",
  data() {
    return {
      wareIn:'',
      nameProduct:'',
      value:'',
    }
  },
  methods: {
    addProd() {
      let prod = {
        name: this.nameProduct,
        warehouse: parseInt(this.wareIn),
        value: this.value,
      }
      this.addProduct(prod)
    },
    ...mapMutations({
      addProduct: 'products/addProduct'
    })
  },
}
</script>

<style scoped>

</style>