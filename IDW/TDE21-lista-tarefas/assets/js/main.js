const tarefa = document.querySelector('#adiciona-field'); // input

// codigo que pega o evento da tecla enter:
tarefa.addEventListener('keypress', (e) => {
    if (e.keyCode === 13) { // código pra tecla enter
        if (!tarefa.value) return; // previne o campo de ficar vazio
        e.preventDefault(); // cancela o envio do form
        adicionar();
    }
})

// gerencia os cliques e direciona pra funcao correta
document.addEventListener('click', (e) => {
    const el = e.target;

    if (el.classList.contains('add-button')) adicionar();
    if (el.classList.contains('rem-button')) el.parentElement.remove();
    if (el.classList.contains('concluido-button')) concluirTask(el);

})

function adicionar() {

    const li = document.createElement("li");
    const ol = document.getElementById("listaTarefas");

    li.innerHTML = `<h4 id="tarefa-adicionada" class="d-flex align-items-baseline">${tarefa.value}<button class="btn btn-danger m-2 rem-button btn-sm">Remover</button><button type="button" class="btn btn-success concluido-button btn-sm">Concluído</button></h4><br>`;
    li.style.listStyle = 'none';
    ol.appendChild(li);
    tarefa.value = '';
    tarefa.focus();

}

// funcao que conclui a task
function concluirTask(el) {

    el.parentElement.remove();
    el.parentElement.style.textDecoration = 'line-through';
    const h2Concluidas = document.querySelector('#tarefas-concluidas');
    h2Concluidas.appendChild(el.parentElement);    

}
