let listBg = document.querySelectorAll('.banner .bg');
let titleBanner = document.querySelector('.banner h1');
let listTab = document.querySelectorAll('.tab');

window.addEventListener("scroll", (event) => {
    let top = this.scrollY

    listBg.forEach((bg, index) => {
        if(index != 0 && index != 8){
            bg.style.transform = `translateY(${top*index/2}px)`;
        }else if(index == 0){
            bg.style.transform = `translateY(${top/3}px)`;
        }
    })
    titleBanner.style.transform = `translateY(${top*4/2}px)`;

    listTab.forEach(tab =>{
        if(tab.offsetTop - top < 550){
            tab.classList.add('active');
        }else{
            tab.classList.remove('active');
        }
    })
});