function LutadorSelecionado(){
    var card = document.getElementById("cardSelecionado");

    if($(card).hasClass("selected")){
        card.classList.remove("selected");
    } else {
        card.classList.add("selected");
    }
}
