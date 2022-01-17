import axios from "axios"

export const ProductStore = {
   state() {
      return {
         productList: [],
         quesName: '',
         quesWarehouse: 0,
         quesDate: '',
      }
   },
   getters: {
      getNameProduct(state) {
         return state.productList.filter( el => el.name === state.quesName)
      },
      getWarehouseValueList(state) {
         let arSet = new Set()
         state.productList.forEach(el=> arSet.add(el['warehouse']))
         return [...arSet]
      },
   },
   mutations: {
      changeQuesData(state, str) {
         state.quesDate = str
      },

      addProduct(state, product) {
         let d = new Date()
         let prod = {
            dateIn: `${d.getDate()}.${d.getMonth()+1}.${d.getFullYear()}`,
            ...product
         }
          state.postProduct(prod)
      },
      deleteProduct(state, id) {
         state.productList = state.productList.filter(el=>el.id !== id)
      },
      addProductValue(state, obj) {
         let {name, warehouse, value} = obj
         let prod = state.productList.filter(el=>el.name === name).filter(el=>el.warehouse === parseInt(warehouse))

         prod[0]['value'] = parseInt(prod[0]['value']) + parseInt(value)
      },
      deleteProductValue(state, obj) {
         let {id, value} = obj
         let item = state.productList.filter(el => el.id === parseInt(id))
         if(parseInt(item[0]['value']) === parseInt(value)) {
            state.deleteProduct(id)
         } else {
            item[0]['value'] = parseInt(item[0]['value']) - parseInt(value)
         }

      }
   },
    actions: {
        getListProduct() {
            axios.get('/Product')
                .then((response) => {
                    state.productList = JSON.parse(response.data['result'])
                })
                .catch(function (err) {
                    alert(err.message)
                })
        },

        getProduct() {
            axios.get('/Product/').then((response) => {
                console.log(response.data['result'])
            }).catch(function (e) {
                alert(e.message)
            })
        },
        postProduct(product) {
            axios.post('/Product/', product).then(response => {
                console.log('post', response.data)
            }).catch(function (e) {
                alert(e.message)
            })
        },
        async putProduct(product) {
            try {
                const response = await Axios.put('/Product', product)
                return response.data
            } catch (e) {
                alert(e.message)
            }
        },
        async deleteProduct(id) {
            try {
                const response = await Axios.delete(`/Product/${id}`)
                return response.data
            } catch (e) {
                alert(e.message)
            }
        },

   },
   namespaced: true,
}