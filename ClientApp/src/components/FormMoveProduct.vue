<template>
  <div class="container pt-2">

      <div class="mb-3">
        <label for="exampleInputName" class="form-label">Название товара</label>
        <input v-model="product.name" type="text" class="form-control" id="exampleInputName">
      </div>
      <div class="mb-3">
        <label for="exampleInputValue" class="form-label">Объем перемещаемого товара</label>
        <input v-model="product.value" type="text" class="form-control" id="exampleInputValue">
      </div>
      <div class="mb-3">
        <label for="exampleInputWarehouseOut" class="form-label">С какого склада</label>
        <input :value="product.warehouse" disabled type="text" class="form-control" id="exampleInputWarehouseOut">
      </div>
      <div class="mb-3">
        <label for="exampleInputWarehouseIn" class="form-label">На какой склад</label>
        <input v-model="wareIn" type="text" class="form-control" id="exampleInputWarehouseIn">
      </div>
      <router-link :to="{ name: 'BalanceReport'}" @click="addMove" class="btn btn-primary">ПЕРЕМЕСТИТЬ</router-link>

  </div>
</template>

<script>
import {mapMutations} from "vuex";

export default {
  name: "FormMoveProduct",
  data() {
    return {
      product: this.$route.params,
      wareIn: 0,
    }
  },
  methods: {
    addMove() {
      let obj = {
        idProduct: this.product.id,
        nameProduct: this.product.name,
        warehouseOut: this.product.warehouse,
        warehouseIn: this.wareIn,
        value: this.product.value,
      }
      this.addMoveItem(obj)

      let obj2 = {
        name:this.product.name,
        warehouse: this.wareIn,
        value: this.product.value
      }

      this.addProductValue(obj2)

      let obj3 ={
        id: this.product.id,
        value: this.product.value,
      }

      this.deleteProductValue(obj3)
    },
    ...mapMutations({
      addMoveItem: 'moveProducts/addMoveItem',
      addProductValue: 'products/addProductValue',
      deleteProductValue: 'products/deleteProductValue',
    }),
  },
}
</script>

<style scoped>

</style>