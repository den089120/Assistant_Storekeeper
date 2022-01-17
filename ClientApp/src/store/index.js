import {createStore} from "vuex";
import {ProductStore} from "@/store/ProductStore";
import {MoveProductStore} from "@/store/MoveProductStore";


export default createStore({
   modules: {
      products: ProductStore,
      moveProducts: MoveProductStore,
   }
})