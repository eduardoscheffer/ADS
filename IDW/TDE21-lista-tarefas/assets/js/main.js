const tarefa = document.querySelector('#adiciona-field');

document.addEventListener('click', (e) => {
    const el = e.target;

    if (el.classList.contains('add-button')) adicionar(); 

})

function adicionar() {

    const li = document.createElement("li");
    const ol = document.getElementById("listaTarefas");

    li.innerHTML = `${tarefa.value}<button class="btn btn-danger m-2">Remover</button><button type="button" class="btn btn-success">Concluído</button><br>`;
    ol.appendChild(li);
    tarefa.focus();

}