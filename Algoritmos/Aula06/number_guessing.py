import random

numero_correto = random.randint(1, 100)
tentativas_restantes = 10

print('Tente adivinhar um numero entre 1 e 100')

while tentativas_restantes > 0:
    try:
        palpite = int(input('Digite seu palpite: '))
    except:
        print('Digite apena números!')
        continue
    if palpite == numero_correto:
        print('Você acertou!')
        break
    elif palpite < numero_correto:
        print('Seu palpite é menor do que o número correto')
        tentativas_restantes -= 1
    else:
        print('Seu palpite é menor do que o número correto')
        tentativas_restantes -= 1
    print(f'Tentativas restantes: {tentativas_restantes}')