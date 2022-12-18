let countFighters = 16;

function LutadorSelecionado(id) {
    let checks = document.getElementsByClassName("selected").length

    let card = document.getElementById(id);
    let fightersChecked = $("#fightersChecked")
    let fightersCheckedN =  $("#fightersCheckedN")


    if(checks >= 16){
        if ($(card).hasClass("selected")) {
            card.classList.remove("selected");
            countFighters++;
        } else{
            alert('Você já selecionou os 16 Mid laners!')
            return;
        }
        
    } else{
        if ($(card).hasClass("selected")) {
            card.classList.remove("selected");
            countFighters++;
        } else {
            card.classList.add("selected");
            countFighters--;
        }
    }
    

    fightersChecked.text(`Selecione ${countFighters} Mid laners e inicie`);
    fightersCheckedN.text(`Selecione mais ${countFighters} Mid laners`);

    if (countFighters == 0) {
        fightersChecked.text(`Mid laners selecionados, bora iniciar?`);
        fightersCheckedN.text(`Mid laners selecionados, bora iniciar?`);
    }

}

function check(name) {
    let checks = document.getElementsByClassName("selected").length

    let checkBox = document.getElementById(name);

    if(checks == 16){
        if (checkBox.checked == true) {
            checkBox.checked = false;
        } 
        return;
    } else{
        if (checkBox.checked == false) {
            checkBox.checked = true;
        } else {
            checkBox.checked = false;
        }
    }

    
    
}

function countCheckbox() {
    let checks = document.getElementsByClassName("selected").length
    if (checks == 16) {
        return true
    } else if (checks < 16) {
        alert('Ops! você selecionou menos do que 16 Mid laners.')
        return false
    } else {
        alert('Ops! você selecionou mais do que 16 Mid laners.')
        return false
    }
}


let button = document.getElementById("backTop")
let notification = document.getElementById("notification")

window.onscroll = function () {
    scrollFunction()
};

function scrollFunction() {
    if (document.body.scrollTop > 250 || document.documentElement.scrollTop > 250) {
        button.style.display = "block";
        notification.style.display = "block"
    } else {
        button.style.display = "none";
        notification.style.display = "none"
    }
}

function topFunction() {
    document.documentElement.scrollTop = 0;
}


