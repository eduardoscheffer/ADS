# Alguma ajuda, caso necessário:
# Função === Descrição
# print === Imprime na tela
# input === Recebe uma entrada do usuário
# int === Converte uma string em um número inteiro
# str === Converte um objeto em uma string
# range === Cria uma sequência de números
# while === Executa um loop enquanto a condição for verdadeira
# if, elif, else === Estruturas de decisão para executar um bloco de código caso a condição seja verdadeira ou falsa

# append === Adiciona um elemento ao final da lista
# len === Retorna o tamanho da lista
# sum === Retorna a soma dos elementos da lista
# sort === Ordena a lista
# set === Cria um conjunto com os elementos da lista
# list === Converte um objeto iterável em uma lista

# Método === Descrição
# append() === Adiciona um elemento ao final da lista
# extend() === Adiciona os elementos de um objeto iterável ao final da lista
# extend() === Adiciona os elementos de um objeto iterável ao final da lista
# insert() === Insere um elemento em uma posição específica na lista
# remove() === Remove a primeira ocorrência de um elemento na lista
# pop() === Remove e retorna o último elemento da lista, ou um elemento em uma posição específica

# index() === Retorna o índice da primeira ocorrência de um elemento na lista
# count() === Retorna o número de ocorrências de um elemento na lista
# sort() === Ordena os elementos da lista em ordem crescente ou decrescente
# reverse() === Inverte a ordem dos elementos da lista
# copy() === Retorna uma cópia da lista original
# clear() === Remove todos os elementos da lista

# 1. Escreva um programa que receba uma lista de números do usuário e imprima a
# lista na tela.
def exercise_1():
    lista = [1, 2, 3, 4, 5]
    print(lista)
# exercise_1() # [1, 2, 3, 4, 5]

# 2. Escreva um programa que receba uma lista de nomes do usuário e imprima cada
# nome em uma linha separada.
def exercise_2():
    usuarios = ['eduardoscheffer', 'marianamendes', 'joaodasilva']
    for index, usuario in enumerate(usuarios):
        print(f'{index} - {usuario}')
# exercise_2()
# 0 - eduardoscheffer
# 1 - marianamendes
# 2 - joaodasilva

# 3. Escreva um programa que receba uma lista de números do usuário e calcule a
# soma de todos os números presentes na lista.
def exercise_3():
    numeros = [32, 443, 443, 43, 78, 32, 382, 2411]
    print(sum(numeros))
# exercise_3() #3864

# 4. Escreva um programa que receba uma lista de números do usuário e calcule a
# média de todos os números presentes na lista.
def exercise_4():
    numeros = [32, 443, 443, 43, 78, 32, 382, 2411]
    media = sum(numeros) / len(numeros)
    print(f'A média da lista {numeros} é {media:.2f}')
# exercise_4() # A média da lista [32, 443, 443, 43, 78, 32, 382, 2411] é 483.00

# 5. Escreva um programa que receba uma lista de números do usuário e imprima
# apenas os números pares presentes na lista.
def exercise_5():
    import random
    random_list = random.sample(range(0, 100), 10) # cria uma lista de 10 numeros inteiros aleatorios entre 0 e  100
    even_random_list = [] # lista que vai receber os valores pares
    for num in random_list:
        if num % 2 == 0:
            even_random_list.append(num)
    print(random_list) # printa a lista aleatorio
    print(even_random_list) # printa so os valores pares da lista aleatoria
# exercise_5()

# 6. Escreva um programa que receba uma lista de números do usuário e imprima
# apenas os números ímpares presentes na lista.
def exercise_6():
    import random
    random_list = random.sample(range(0, 100), 10) # cria uma lista de 10 numeros inteiros aleatorios entre 0 e  100
    even_random_list = [] # lista que vai receber os valores pares
    for num in random_list:
        if num % 2 != 0:
            even_random_list.append(num)
    print(random_list) # printa a lista aleatorio
    print(even_random_list) # printa so os valores pares da lista aleatoria
# exercise_6()

# 7. Escreva um programa que receba uma lista de números do usuário e imprima
# apenas os números que são múltiplos de 3 e 5 simultaneamente.
def exercise_7():
    import random
    # random_list = random.sample(range(0, 100), 10)
    random_list = [2, 5, 7, 11, 29, 14,53, 66, 81, 90, 40, 48, 45]
        
    new_list = filter(lambda x: x % 3 == 0 and x % 5 == 0, random_list)
    
    print(random_list)
    print(list(new_list)) # [90, 45]  
# exercise_7()


# 8. Escreva um programa que receba uma lista de números do usuário e imprima a
# lista em ordem crescente.
def exercise_8():
    import random
    # random_list = random.sample(range(0, 100), 10)
    random_list = [90, 278,21, 45, 8392, 0.34]
    sorted_list = sorted(random_list)
    print(sorted_list)
# exercise_8()

# 9. Escreva um programa que receba uma lista de números do usuário e imprima a
# lista em ordem decrescente.
def exercise_9():
    import random
    # random_list = random.sample(range(0, 100), 10)
    random_list = [90, 278,21, 45, 8392, 0.34]
    sorted_list = sorted(random_list, reverse=True)
    print(sorted_list)
# exercise_9()

# 10.Escreva um programa que receba uma lista de números do usuário e verifique se
# um número específico está presente na lista.
def exercise_10():
    import random
    try:
        random_list = random.sample(range(0, 100), 30)
        number = int(input('Qual número deseja procurar? '))

        print(f'O número se encontra na lista no index: [{random_list.index(number)}]') if number in random_list else print('Número não localizado.')

    except:
        print('Somente números permitido.')
        return
# exercise_10()