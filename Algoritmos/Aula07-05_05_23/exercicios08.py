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

# 1. Escreva um programa que receba uma lista de números do usuário e retorne o maior número
# presente na lista.
def exercise_1():
    import random
    random_list = random.sample(range(0, 100), 10)
    max_number = max(random_list)
    print(max_number)
# exercise_1()

# 2. Escreva um programa que receba uma lista de números do usuário e retorne o menor número
# presente na lista.
def exercise_1():
    import random
    random_list = random.sample(range(0, 100), 10)
    max_number = min(random_list)
    print(max_number)
# exercise_1()

# 3. Escreva um programa que receba uma lista de números do usuário e retorne a soma de todos os
# números presentes na lista.
def exercise_3():
    import random
    random_list = random.sample(range(0, 100), 10)
    sum_list = sum(random_list)
    print(sum_list)
# exercise_3()

# 4. Escreva um programa que receba uma lista de números do usuário e retorne a quantidade de
# números pares presentes na lista.
def exercise_4():
    import random
    random_list = random.sample(range(0, 100), 10)
    even_list = list(filter(lambda x: x % 2 == 0, random_list))
    print(f'A lista {even_list} contém {len(even_list)} números pares')
# exercise_4()

# 5. Escreva um programa que receba uma lista de números do usuário e retorne a quantidade de
# números ímpares presentes na lista.
def exercise_5():
    import random
    random_list = random.sample(range(0, 100), 10)
    even_list = list(filter(lambda x: x % 2 != 0, random_list))
    print(f'A lista {even_list} contém {len(even_list)} números ímpares')
# exercise_5()

# 6. Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
# apenas os números pares presentes na lista.
def exercise_6():
    import random
    random_list = random.sample(range(0, 100), 10)
    even_list = list(filter(lambda x: x % 2 == 0, random_list))
    print(random_list)
    print(even_list)
# exercise_6()

# 7. Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
# apenas os números ímpares presentes na lista.
def exercise_7():
    import random
    random_list = random.sample(range(0, 100), 10)
    odd_list = list(filter(lambda x: x % 2 != 0, random_list))

    print(random_list)
    print(odd_list)
# exercise_7()

# 8. Escreva um programa que receba uma lista de nomes do usuário e retorne o nome mais longo
# presente na lista.
def exercise_8():
    nomes_usuarios = ['eduardo', 'maria', 'joao', 'Mariana', 'Pedro', 'Joao Pedro']
    # max_user_length = max(nomes_usuarios, key=len)
    # print(max_user_length)

    max_str = nomes_usuarios[0]
    for name in nomes_usuarios:
        if len(name) > len(max_str):
            max_str = name
    
    print(max_str)

# exercise_8()

# 9. Escreva um programa que receba uma lista de números do usuário e retorne a média dos
# números presentes na lista.
def exercise_9():
    numeros = [32, 443, 443, 43, 78, 32, 382, 2411]
    media = sum(numeros) / len(numeros)
    print(f'A média da lista {numeros} é {media:.2f}')
# exercise_9()

# 10. Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
# apenas os números que são múltiplos de 3 e 5 simultaneamente.
def exercise_10():
    import random
    random_list = random.sample(range(0, 100), 10)
    new_list = list(filter(lambda x: x % 3 == 0 and x % 5 == 0, random_list))

    print(random_list)
    print(new_list)
# exercise_10()

# 11. Escreva um programa que receba uma lista de nomes do usuário e determine se todos os
# nomes possuem a mesma quantidade de caracteres.
def exersise_11():
    import random
    random_list = ['eduardo', 'maria', 'eduardo', 'eduardo']

    print(len(random_list[0]) == len(random_list[1]))

# exersise_11()

# 12. Escreva um programa que receba uma lista de números do usuário e retorne uma lista com
# apenas os números ímpares presentes na lista, utilizando um loop while.
def exercise_12():
    import random
    random_list = random.sample(range(0, 100), 10)
    odd_list = []
    
    i = 0
    while i < len(random_list):
        if random_list[i] % 2 != 0:
            odd_list.append(random_list[i])
        i+=1
    print(random_list)
    print(odd_list)

# exercise_12()


# 13. Escreva um programa que receba uma lista de números do usuário e retorne a lista em ordem
# crescente.
def exercise_13():
    import random
    random_list = random.sample(range(0, 100), 10)

    sorted_random_list = sorted(random_list)
    print(sorted_random_list)
# exercise_13()

# 14. Escreva um programa que receba uma lista de números do usuário e retorne a lista em ordem
# decrescente.
def exercise_14():
    import random
    random_list = random.sample(range(0, 100), 10)

    sorted_random_list = sorted(random_list, reverse=True)
    print(sorted_random_list)
# exercise_14()

# 15. Escreva um programa que receba uma lista de números do usuário e retorne uma lista sem
# duplicatas.
def exercise_15():
    user_list = ['eduardo', 'mengue', 'mengue', 'scheffer', 'joao', 'maria', 'eduardo', 'maria']
    new_list = []

    for i, nome in enumerate(user_list):
        if user_list.index(nome) == i:
            new_list.append(nome)
    print(new_list)
# exercise_15()