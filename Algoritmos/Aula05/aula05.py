# Faça um algoritmo que receba um número inteiro e apresente a tabuada deste número:
    # multiplos = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    # numero = int(input('Qual tabuada você deseja obter? '))

    # for multiplo in multiplos:
    #     print(numero * multiplo)

# Você está desenvolvendo um programa para calcular a distância percorrida por um objeto em um movimento uniformemente acelerado. O usuário deve informar a velocidade inicial, a aceleração e o tempo de deslocamento. Escreva um algoritmo que calcule e imprima a distância percorrida pelo objeto.
velocidade_inicial = round(float(input('Qual a velocidade inicial? (Km/h) ')) / 3.6, 2)
aceleracao = float(input('Qual a aceleração? (m/s²) '))
tempo_deslocamento = round(float(input('Qual o tempo de deslocamento (h)? ')) * 3600, 2)

def calculate_distancia(vo, a, t):
    print(f'A distância percorrida foi de {(vo * t + (a * (t ** 2)) / 2) / 1000} Km')

calculate_distancia(velocidade_inicial, aceleracao, tempo_deslocamento)