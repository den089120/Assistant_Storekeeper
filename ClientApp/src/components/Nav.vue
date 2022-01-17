<template>
  <div class="navigation" data-id="container">
    <router-link :to="{name: 'HelloWorld'}" @click="isShow1=true; isShow2=false; isShow3=false; isShow4=false" :class="{active: isShow1}" class="navigation__elem">
      <span class="navigation__icon"><img src="icons/house-door.svg" alt=""></span>
      <span class="navigation__text">Главная</span>
    </router-link>
    <router-link :to="{ name: 'MoveList'}" @click="isShow1=false; isShow2=true; isShow3=false; isShow4=false" :class="{active: isShow2}" class="navigation__elem">
      <span class="navigation__icon"><img src="icons/journals.svg" alt=""></span>
      <span class="navigation__text">Список перемещений</span>
    </router-link>
    <router-link :to="{ name: 'newProduct'}" @click="isShow1=false; isShow2=false; isShow3=true; isShow4=false" :class="{active: isShow3}" class="navigation__elem">
      <span class="navigation__icon"><img src="icons/clipboard.svg" alt=""></span>
      <span class="navigation__text">Форма</span>
    </router-link>
    <router-link :to="{ name: 'BalanceReport'}" @click="isShow1=false; isShow2=false; isShow3=false; isShow4=true" :class="{active: isShow4}" class="navigation__elem">
      <span class="navigation__icon"><img src="icons/journal-text.svg" alt=""></span>
      <span class="navigation__text">Баланс</span>
    </router-link>
    <div class="indicator"></div>
  </div>
</template>

<script>
export default {
  name: "Nav",
  data() {
    return {
      isShow1: true,
      isShow2: false,
      isShow3: false,
      isShow4: false,
    }
  },
  methods: {
  }
}
</script>

<style scoped>
.navigation {
  position: relative;
  height: 70px;
  width: 100%;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  border-bottom-left-radius: 10px;
  border-bottom-right-radius: 10px;
  background-color: aqua;
}
.navigation__elem {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  padding: 12px;
}
.navigation__elem.active .navigation__icon {
  transform: translateY(40px);
}
.navigation__elem.active .navigation__text {
  opacity: 1;
  transform: translateY(-10px);
}
.navigation__icon {
  position: relative;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 70px;

  transition: 0.5s;
  z-index: 5;
}
.navigation__icon img {
  width: 25px;
  display: block;
  line-height: 70px;

}
.navigation__text {
  position: absolute;
  opacity: 0;
  transition: 0.5s;
  transform: translateY(-20px);
}

.indicator {
  position: absolute;
  margin: 10px;
  top: 50%;
  width: 64px;
  height: 64px;
  background-color: cornflowerblue;
  border-radius: 50%;
  border: 6px solid white;
  transition: 0.5s;
}

.navigation__elem.active:nth-child(1) ~ .indicator {
  transform: translateX(calc(70px * 0.07));
}

.navigation__elem.active:nth-child(2) ~ .indicator {
  transform: translateX(calc(70px * 1.4));
}

.navigation__elem.active:nth-child(3) ~ .indicator {
  transform: translateX(calc(70px * 2.76));
}

.navigation__elem.active:nth-child(4) ~ .indicator {
  transform: translateX(calc(70px * 4.1));
}
</style>