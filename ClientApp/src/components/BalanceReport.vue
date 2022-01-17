<template>
  <div class="container pt-2">
    <div class="row" style="justify-content: center;align-items: center">Введите дату для выписки в формате "день.месяц.год"
      <input class="col m-2" v-model="DateReq">
       и номер склада
      <input class="col m-2" v-model="WarehouseReq">
      <button class="btn btn-success col m-2" @click="changeQuesData(DateReq)">Создать выписку</button>
    </div>
    <div class="p-2" style="justify-content: center;align-items: center;">Остатки на складах на {{quesDate ? quesDate : 'настоящее время'}}</div>
    <div v-if="WarehouseReq > 0">
      <div class="m-3">Наименование склада "{{WarehouseReq}}"</div>
      <div class="row">
        <div class="col" style="justify-content: center;align-items: center;">Название товара</div>
        <div class="col" style="justify-content: center;align-items: center;">Объем товара</div>
        <div class="col" style="justify-content: center;align-items: center;">Дата поступления</div>
        <div class="col" style="justify-content: center;align-items: center;"></div>
      </div>
      <div class="row" v-for="prod in getWarehouseDateProd(parseInt(WarehouseReq))" :key="prod.id">
        <div class="col" style="display:flex;justify-content: center;align-items: center;">{{prod.name}}</div>
        <div class="col" style="display:flex;justify-content: center;align-items: center;">{{prod.value}}</div>
        <div class="col" style="display:flex;justify-content: center;align-items: center;">{{prod.dateIn}}</div>
        <router-link :to="{ name: 'FormMoveProduct', params: {...prod} }" class="btn btn-success col m-2">ПЕРЕМЕСТИТЬ</router-link>
      </div>
    </div>
    <div v-else >
      <div v-for="warehouse in warehouseList" :key="warehouse">
        <div class="m-3">Наименование склада "{{warehouse}}"</div>
        <div class="row">
          <div class="col" style="justify-content: center;align-items: center;">Название товара</div>
          <div class="col" style="justify-content: center;align-items: center;">Объем товара</div>
          <div class="col" style="justify-content: center;align-items: center;">Дата поступления</div>
          <div class="col" style="justify-content: center;align-items: center;"></div>
        </div>
        <div class="row" v-for="prod in getWarehouseDateProd(warehouse)" :key="prod.id">
          <div class="col" style="display:flex;justify-content:center;align-items:center;">{{prod.name}}</div>
          <div class="col" style="display:flex;justify-content: center;align-items: center;">{{prod.value}}</div>
          <div class="col" style="display:flex;justify-content: center;align-items: center;">{{prod.dateIn}}</div>
          <router-link :to="{ name: 'FormMoveProduct', params: {...prod} }" class="btn btn-success col m-2">ПЕРЕМЕСТИТЬ</router-link>
        </div>
      </div>
    </div>

  </div>
</template>

<script>
import {mapState, mapActions, mapMutations, mapGetters} from "vuex";
export default {
  name: "BalanceReport",
  data() {
    return {
      DateReq: '',
      WarehouseReq: 0,
    }
  },

  mounted() {
     this.getListProduct()
  },

  computed: {
    ...mapState({
      productList: state => state.products.productList,
      quesDate: state => state.products.quesDate,
    }),
    ...mapGetters({
      warehouseList: 'products/getWarehouseValueList',
    }),
  },
  methods: {
    productListWarehouse(warehouse) {
      return this.productList.filter(el=>el['warehouse'] === warehouse)
    },
    getWarehouseDateProd(warehouse) {
      if(this.quesDate === '') {
        return this.productListWarehouse(warehouse)
      } else {
        return this.productListWarehouse(warehouse).filter(el=> {

          let [day, month, year] = el['dateIn'].split('.')
          day = parseInt(day)
          month = parseInt(month)
          year = parseInt(year)

          let [qDay, qMonth, qYear] = this.quesDate.split('.')
          qDay = parseInt(qDay)
          qMonth = parseInt(qMonth)
          qYear = parseInt(qYear)

          if(year < qYear) {
            return true
          } else if(year === qYear) {
            if(month < qMonth) {
              return true
            } else if (month === qMonth) {
              if(day <= qDay) {
                return true
              }
            }
          }
        })
      }
    },
    ...mapMutations({
      changeQuesData: 'products/changeQuesData',
    }),
      ...mapActions({
          getListProduct: 'products/getListProduct',
          getProduct: 'products/getProduct',
          postProduct: 'products/postProduct',
          putProduct: 'products/putProduct',
          deleteProduct: 'products/deleteProduct',
    })
  },
}
</script>

<style scoped>

</style>