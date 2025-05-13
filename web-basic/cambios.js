
console.log("cambios.js");

// Para programar es necesario,
// que no hagan sabotaje !.

const main = document.getElementById("mani");
main.className= "container-fluid";

let addDiv = (elementoX) => {
    const unDiv = document.createElement("div");
    unDiv.appendChild(elementoX);
    return unDiv;
}
let addRowCol12 = (txt) => {
    const row = document.createElement("div");
    row.className = "row";
    const col12 = document.createElement("div");
    col12.className= "col-12";
    col12.id = "" + txt;
    row.appendChild(col12);
    return row;
}

let addH1 = (txt) => {
    const divInfo = document.createElement("div");
    divInfo.className = "h1";
    divInfo.innerHTML = "" + txt;
    return divInfo;
}

let addBtn = (txt, someFunction) => {
    const btn = document.createElement("button");
    btn.className = "btn btn-secondary";
    btn.innerHTML = "" + txt;
    btn.style.width = "max-content !important";
    btn.addEventListener("click", someFunction);
    return btn;
}

let addImg = (src, alt, className) => {
    const divImg = document.createElement("img");
    divImg.src = src;
    divImg.alt = alt;
    divImg.classList.add(className);
    return divImg;
}



//
// MAIN
const viewBtnShowMainPage = () => {
    const fila1 = addRowCol12("fila1");
    fila1.appendChild( addDiv(addBtn("Show Main Page", mainPage)) );
    main.appendChild( fila1 );
}
const mainPage = () => {
    const fila1 = addRowCol12("fila1");
    fila1.appendChild( addH1("Hola Mundo") );
    fila1.appendChild( addImg("IMG_0830.jpg", "img", "w50") );
    main.appendChild( fila1 );
}
viewBtnShowMainPage();

