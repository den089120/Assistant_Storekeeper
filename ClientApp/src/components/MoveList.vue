<template>
  <div class="container pt-2">
    <div>
      <div class="m-2">Список перемещений товаров между складами</div>
      <div class="row">
        <div class="col">Название товара</div>
        <div class="col">кол-во товара</div>
        <div class="col">С какого склада</div>
        <div class="col">На какой склад</div>
        <div class="col">Дата перемещения</div>
        <div class="col"></div>
      </div>
      <div class="row" v-for="list in MoveList" :key="list.id">
        <div class="col" style="display:flex;justify-content:center;align-items:center;">{{list.nameProduct}}</div>
        <div class="col" style="display:flex;justify-content:center;align-items:center;">{{list.value}}</div>
        <div class="col" style="display:flex;justify-content:center;align-items:center;">{{list.warehouseOut}}</div>
        <div class="col" style="display:flex;justify-content:center;align-items:center;">{{list.warehouseIn}}</div>
        <div class="col" style="display:flex;justify-content:center;align-items:center;">{{list.dateIn}}</div>
        <button class="col btn btn-success m-2" @click="deleteMoveItem(list.id)">УДАЛИТЬ</button>
      </div>
    </div>
  </div>
</template>

<script>
import {mapGetters, mapMutations, mapState} from "vuex";

export default {
  name: "MoveList",
  data() {
    return {}
  },
  computed: {
    ...mapState({
      MoveList: state => state.moveProducts.MoveList,
    }),
    ...mapGetters({
    }),
  },
  methods: {
    ...mapMutations({
      deleteMoveItem: 'moveProducts/deleteMoveItem'
    }),
  },
}
</script>

<style scoped>

</style>