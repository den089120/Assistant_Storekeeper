import { createWebHistory, createRouter } from "vue-router";
import HelloWorld from "@/components/HelloWorld";
import MoveList from "@/components/MoveList";
import FormMoveProduct from "@/components/FormMoveProduct";
import BalanceReport from "@/components/BalanceReport";
import newProduct from "@/components/newProduct";

const routes = [
    {
        path: "/",
        name: "HelloWorld",
        component: HelloWorld,
    },
    {
        path: "/MoveList",
        name: "MoveList",
        component: MoveList,
    },
    {
        path: "/FormMoveProduct",
        name: "FormMoveProduct",
        component: FormMoveProduct,
    },
    {
        path: "/BalanceReport",
        name: "BalanceReport",
        component: BalanceReport,
    },
    {
        path: "/newProduct",
        name: "newProduct",
        component: newProduct,
    },
];

const router = createRouter({
    history: createWebHistory(),
    routes,
});

export default router;
