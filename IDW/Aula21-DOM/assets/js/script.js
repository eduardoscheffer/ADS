const meuTitulo = document.getElementById("titulo");

meuTitulo.innerText += '!'; // manipuando o texto
meuTitulo.style.color = 'red'; // manipulando o css do elemento

const paragrafos = document.getElementsByTagName("p"); // retorna uma array: [p, p, p]

for (let paragrafo of paragrafos) {
    let i = 0;
    paragrafo.innerText = `Paragrafo ${i}`;
    i++;
}

const itemUm = document.querySelector("li"); // pega o primeiro elemento que encontrar
itemUm.style.color = 'green';

const itens = document.querySelectorAll("li"); // retorna uma array
itens[0].style.color = 'red'; // pega o primeiro item
console.log(itens[2].innerText); // Item 3

// innerHTML consegue adicionar tags dentro
meuTitulo.innerHTML = `Manipulando a <br> DOM`;

const alteraImagem = () => {
    const imagem = document.querySelector("img");
    imagem.style.width = '200px'
}

const voltaImagem = () => {
    const imagem = document.querySelector("img");
    imagem.style.width = '300px';
}


const minhaHeader = document.querySelector('header');
minhaHeader.style.backgroundColor = 'black';    
minhaHeader.style.color = 'white';
minhaHeader.style.padding = '5%';
minhaHeader.style.width = '50%';
minhaHeader.style.margin = '0 auto';

const adicionar = () => {

    const clube = document.getElementById("club").value;
    const li = document.createElement("li");
    const ol = document.getElementById("listaClubs");

    li.innerText = clube;
    ol.appendChild(li);
    document.getElementById("club").focus();
}

function remover() {

    const club = document.getElementById("clubRemove").value;
    const listaTime = document.querySelectorAll('li');

    let encontrado;
    for (const time of listaTime) {
        
        if (club === time.innerText) {
            time.remove();
            encontrado = true;
        }
    }

    if (!encontrado) {

        alert('Time não encontrado. Verifique se digitou corretamente.')

    }

}