# Lista ficticia de alunos
alunos = [
#   id      nome    idade
    [1, 'Joao Pedro', 20],
    [2, 'Eduardo', 25],
    [3, 'Pedro', 21],
    [4, 'Renan', 23]
    
]

while True:
    try:
       id_busca = input('Qual o ID deseja atualiza? ')
       id_busca = int(id_busca)
       if id_busca >= 0:
           break
    except:
        print('ID dever ser um numero inteiro valido maior que 0. Tente novamente')

# pra cada aluno na lista de alunos
for aluno in alunos:
    if aluno[0] == id_busca:
        try:
            novo_nome = input('Qual o novo nome do aluno? ')
            nova_idade = int(input('Qual a nova idade do aluno? '))
            if nova_idade < 0:
                break
        except:
            print('Nome deve conter apenas caracteres validos e idade deve ser um numero inteiro maior que 0')
            break
        
        aluno[0] = id_busca
        aluno[1] = novo_nome
        aluno[2] = nova_idade
        print('Atualizado com sucesso')
        break
    print('Aluno não encontrado')
    break

# print(aluno)
for aluno in alunos:
    print(aluno)
    