function exercise_1() {
    let num1 = prompt("Digite um número: ");
    let num2 = prompt("Digite outro número: ");
    alert(`${num1} x ${num2} = ${num1 * num2}`);
    return
}

function exercise_2() {
    let num1 = Number(prompt("Digite um número: "));
    if (num1 < 0) {
        let negativeResponse = "O número é negativo e ";
        if (num1 % 2 === 0) negativeResponse += "par."
        if (num1 % 2 !== 0) negativeResponse += "ímpar."
        alert(`${negativeResponse}`);
        return
        
    }
    else if(num1 >= 0) {
        let positiveResponse = "O número é positivo e ";
        if (num1 % 2 === 0) positiveResponse += "par."
        if (num1 % 2 !== 0) positiveResponse += "ímpar."
        alert(`${positiveResponse}`);
        return
        
    }
    else {
        alert('Número inválido');
        return
    }
}

function exercise_3() {

    let nome = prompt('Qual o seu nome? ');
    let idade = Number(prompt('Qual a sua idade? '));
    if (idade >= 18) {
        return alert(`${nome} você é maior de idade.`)
    } 
    else if (idade < 18) {
        return alert(`${nome} é menor de idade`);
    } else{
        return alert('Algo deu errado')
    }

}

function exercise_4() {

    const numeroUsuario = Number(prompt('Qual tabuada deseja saber? '));

    const numeros = [0,1,2,3,4,5,6,7,8,9];

    for (let numero of numeros) {
        alert(`${numeroUsuario} x ${numero} = ${numeroUsuario * numero}`);
    }

    location.reload();

}

function exercise_5() {
    
    let notas = [];
    
    const nota1 = Number(prompt('Qual a nota 01 do aluno: '));
    
    const nota2 = Number(prompt('Qual a nota 02 do aluno: '));
    
    const nota3 = Number(prompt('Qual a nota 03 do aluno: '));
    
    notas.push(nota1, nota2, nota3);
    
    const somaNotas = notas.reduce((a,b) => a + b);
    
    const qtdNotas = notas.length;
    
    const mediaNotas = somaNotas/ qtdNotas;
    
    if (mediaNotas >= 6) {
        alert(`Aprovado. Média ${mediaNotas}`);
        location.reload();
    }
    
    if (mediaNotas < 6) {
        alert(`Aprovado. Média ${mediaNotas}`);
        location.reload();
    }
    
}

function exercise_6() {

    const diasDaSemana = [
        "Domingo",
        "Segunda-Feira",
        "Terça-Feira",
        "Quarta-Feira",
        "Quinta-Feira",
        "Sexta-Feira",
        "Sábado"
    ];

    let dia = Number(prompt('Qual dia da semana deseja? '));
    if (dia >= 1 && dia <= 7) {
        return alert(`${diasDaSemana[dia - 1]}`)
    } else {
        return alert('Número inválido')
    }

}

function exercise_7() {

    let multiplos = [];
    
    let i = 0;
    while (i !== 100) {
        if (i % 3 === 0) multiplos.push(i);
        i++;
    }

    const somaMultiplos = multiplos.reduce((ac,val) => ac + val);

    alert(`A soma dos números multiplos de 3, entre 0 e 100 é ${somaMultiplos}`);

    location.reload();

}

function exercise_8() {

    const notas = [];
    isValid = true
    while(isValid) {
        let nota = Number(prompt('Qual nota deseja inserir? '));

        if (nota < 0) break

        notas.push(nota);
    }

    const somaNotas = notas.reduce((ac, val) => ac + val);

    const qtdNotas = notas.length;

    const media = somaNotas / qtdNotas;

    alert(`A média das notas foi de ${media}.`)

    location.reload();

}

function calcula() {

    document.addEventListener('click', (event) => {
        const el = event.target;
        if(el.classList.contains('btn1')) exercise_1();
        if(el.classList.contains('btn2')) exercise_2();
        if(el.classList.contains('btn3')) exercise_3();
        if(el.classList.contains('btn4')) exercise_4();
        if(el.classList.contains('btn5')) exercise_5();
        if(el.classList.contains('btn6')) exercise_6();
        if(el.classList.contains('btn7')) exercise_7();
        if(el.classList.contains('btn8')) exercise_8();
    })

}

