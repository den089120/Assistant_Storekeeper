export const MoveProductStore = {
   state() {
      return {
         MoveList: [
            {
               id: 1,
               idProduct: 22,
               nameProduct: 'яблоко',
               warehouseOut: 1,
               warehouseIn: 2,
               value: 2,
               dateIn: '11.10.2021',
            },
            {
               id: 2,
               idProduct: 33,
               nameProduct: 'яблоко',
               warehouseOut: 3,
               warehouseIn: 1,
               value: 5,
               dateIn: '11.11.2021',
            },
            {
               id: 3,
               idProduct: 44,
               nameProduct: 'груша',
               warehouseOut: 2,
               warehouseIn: 1,
               value: 6,
               dateIn: '10.10.2021',
            },
            {
               id: 4,
               idProduct: 55,
               nameProduct: 'апельсин',
               warehouseOut: 2,
               warehouseIn: 1,
               value: 1,
               dateIn: '10.08.2021',
            },
            {
               id: 5,
               idProduct: 66,
               nameProduct: 'апельсин',
               warehouseOut: 1,
               warehouseIn: 3,
               value: 20,
               dateIn: '02.08.2021',
            },
            {
               id: 6,
               idProduct: 77,
               nameProduct: 'мандарин',
               warehouseOut: 1,
               warehouseIn: 3,
               value: 10,
               dateIn: '02.04.2021',
            },
         ],
      }
   },
   getters: {},
   mutations: {
      deleteMoveItem(state, id) {
         state.MoveList = state.MoveList.filter(el => el.id !== id)
      },
      addMoveItem(state, item) {
         let d = new Date()
         let obj = {
            id: Date.now(),
            dateIn: `${d.getDate()}.${d.getMonth()+1}.${d.getFullYear()}`,
            ...item,
         }
         state.MoveList.push(obj)
      },
   },
   actions: {
   },
   namespaced: true,
}