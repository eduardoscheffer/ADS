const fieldNum1 = document.getElementById('num1');
const fieldNum2 = document.getElementById('num2');
const fieldAp1 = document.getElementById('ap1');
const fieldAp2 = document.getElementById('ap2');
const fieldAs = document.getElementById('as');
const resultadoCalc = document.getElementById('result');
const resultadoMedia = document.getElementById('msg');


function mostraErro(campo, mensagem) {

    const div = document.createElement('div');
    div.innerHTML = mensagem;
    div.classList.add('error-text');

    campo.insertAdjacentElement('afterend', div);

}

function limpar() {

    num1.value = '';
    num2.value = '';
    resultadoCalc.innerText = '';
    num1.focus();

}

function limparMedias() {

    fieldAp1.value = '';
    fieldAp2.value = '';
    fieldAs.value = '';
    resultadoMedia.innerText = '';
    fieldAp1.focus();

}

function somar() {

    try {

        let num1 = Number(document.getElementById('num1').value);
        let num2 = Number(document.getElementById('num2').value);
        
        if (num1 == '' || num2 == '') {

            mostraErro(fieldNum1, 'Número 1 e Número 2 são requeridos.');
            mostraErro(fieldNum2, 'Número 1 e Número 2 são requeridos.');
            return;

        }

        if (typeof num1 === 'number' && typeof num2 === 'number') {


            const resultado = num1 + num2;
            resultadoCalc.innerHTML = resultado;
            resultadoCalc.classList.add('fs-1');

        }
        
    } catch (error) {

        alert('Somente numeros permitidos');

    }

}

function subtrair() {

    try {
        
        let num1 = Number(document.getElementById('num1').value);
        let num2 = Number(document.getElementById('num2').value);
        
        if (num1 == '' || num2 == '') {

            mostraErro(fieldNum1, 'Número 1 e Número 2 são requeridos.');
            mostraErro(fieldNum2, 'Número 1 e Número 2 são requeridos.');
            return;

        }

        if (typeof num1 === 'number' && typeof num2 === 'number') {


            const resultado = num1 - num2;
            resultadoCalc.innerHTML = resultado;
            resultadoCalc.classList.add('fs-1');

        }
        
    } catch (error) {

        alert('Somente numeros permitidos');

    }

}

function multiplicar() {

    try {
        
        let num1 = Number(document.getElementById('num1').value);
        let num2 = Number(document.getElementById('num2').value);
        
        if (num1 == '' || num2 == '') {

            mostraErro(fieldNum1, 'Número 1 e Número 2 são requeridos.');
            mostraErro(fieldNum2, 'Número 1 e Número 2 são requeridos.');
            return;

        }

        if (typeof num1 === 'number' && typeof num2 === 'number') {


            const resultado = num1 * num2;
            resultadoCalc.innerHTML = resultado;
            resultadoCalc.classList.add('fs-1');

        }
        
    } catch (error) {

        alert('Somente numeros permitidos');

    }

}

function dividir() {

    try {
        
        let num1 = Number(document.getElementById('num1').value);
        let num2 = Number(document.getElementById('num2').value);
        
        if (num1 == '' || num2 == '') {

            mostraErro(fieldNum1, 'Número 1 e Número 2 são requeridos.');
            mostraErro(fieldNum2, 'Número 1 e Número 2 são requeridos.');
            return;

        }

        if (typeof num1 === 'number' && typeof num2 === 'number') {


            const resultado = num1 / num2;
            resultadoCalc.innerHTML = resultado;
            resultadoCalc.classList.add('fs-1');

        }
        
    } catch (error) {

        alert('Somente numeros permitidos');

    }

}

function calcularMedia() {

    try {
        
        let ap1 = Number(document.getElementById('ap1').value);
        let ap2 = Number(document.getElementById('ap2').value);
        let aS = Number(document.getElementById('as').value);
        
        if (ap1 == '' || ap2 == '' || aS == '') {

            mostraErro(fieldAp1, 'Notas obrigatórias.');
            mostraErro(fieldAp2, 'Notas obrigatórias.');
            mostraErro(fieldAs, 'Notas obrigatórias.');
            return;

        }

        if (typeof ap1 === 'number' && typeof ap2 === 'number' && typeof aS === 'number') {

            const resultado = ((ap1 + ap2 + aS) / 3).toFixed(2);

            if (resultado >= 6) {
                
                resultadoMedia.innerHTML = `Nota: ${resultado}. Aprovado. Parabéns!`;
                resultadoMedia.classList.add('aprovado');

            } else {
                
                resultadoMedia.innerHTML = `Nota: ${resultado}. Reprovado. Reforce seus estudos para realização da AF.`;
                resultadoMedia.classList.add('reprovado');

            }
            

        }
        
    } catch (error) {

        alert('Somente numeros permitidos');

    }

}