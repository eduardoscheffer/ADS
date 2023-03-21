import random

secret_number = random.randint(1, 100) # cria um número aleatório entre 1 e 100

while True: # loop que vai ser executado até encontrar o 'break'
    guess = int(input('Adivinhe um número entre 1 e 100: ')) # pede um número entre 1 e 100 do usuário e converte pra Number ja que input retorna uma string

    if guess == secret_number:
        print('Você acertou!')
        break
    elif guess < secret_number:
        print('Você chutou baixo.')
    else:
        print('Você chutou alto')