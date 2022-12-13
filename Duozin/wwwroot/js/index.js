function LutadorSelecionado(id){
    let card = document.getElementById(id);
    if($(card).hasClass("selected")){
        card.classList.remove("selected"); 
    } else {
        card.classList.add("selected");     
    }
}

function check(name) {
    let checkBox = document.getElementById(name);

    if(checkBox.checked == false){
        checkBox.checked = true;
    } else {
        checkBox.checked = false;
    }
}

function countCheckbox(){
    let checks = document.getElementsByClassName("selected").length
    if(checks == 16 || checks == 32){
        return true

    }else{

        alert('Problema')
        return false
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