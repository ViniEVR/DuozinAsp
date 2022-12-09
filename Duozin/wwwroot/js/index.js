function LutadorSelecionado(id){
    var card = document.getElementById(id);

    if($(card).hasClass("selected")){
        card.classList.remove("selected");
    } else {
        card.classList.add("selected");
    }
}


let button = document.getElementById("backTop")

window.onscroll = function() {
    scrollFunction()
};

function scrollFunction(){
    if(document.body.scrollTop > 250 || document.documentElement.scrollTop > 250){
        button.style.display = "block";
    } else {
        button.style.display = "none";
    }
}

function topFunction() {
    document.documentElement.scrollTop = 0;
}