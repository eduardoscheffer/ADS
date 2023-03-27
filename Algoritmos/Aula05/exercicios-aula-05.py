# 1. Você está desenvolvendo um programa para calcular a corrente elétrica em um circuito elétrico. O
# usuário deve informar a resistência elétrica e a tensão elétrica do circuito. Escreva um algoritmo que
# calcule e imprima a corrente elétrica do circuito, de acordo com a lei de Ohm.
# I = U/R
def exercise_1():
    resistencia = float(input('Qual o valor da Resistência elétrica? '))
    tensao_eletrica = float(input('Qual o valor da tensão elétrica em V? '))
    print(f'A corrente elétrica no circuito é {tensao_eletrica / resistencia} A')
# exercise_1()


# 2. Você está desenvolvendo um programa que verifica se uma pessoa pode dirigir ou não. Para isso,
# você precisa solicitar a idade da pessoa e verificar se ela é maior ou igual a 18 anos. Se a idade for
# menor que 18, o programa deve informar que a pessoa não pode dirigir, caso contrário, o programa
# deve informar que a pessoa pode dirigir.
def exercise_2():
    idade = int(input('Qual a sua idade? '))
    if idade < 18:
        print('Não habilitado!')
    else:
        print('Habilitado!')
# exercise_2()


# 3. Você está desenvolvendo um programa que verifica se um número é par ou ímpar. Para isso, você
# precisa solicitar o número e verificar se ele é divisível por 2. Se o número for divisível por 2, o
# programa deve informar que o número é par, caso contrário, o programa deve informar que o número
# é ímpar.
def exercise_3():
    number = int(input('Qual numero deseja saber se é par ou ímpar? '))
    if number % 2 == 0:
        print(f'{number} é par.')
    else:
        print(f'{number} é ímpar.')
# exercise_3()


# 4. Você está desenvolvendo um programa para calcular a altura máxima e o tempo de queda de um
# objeto em um lançamento vertical. O usuário deve informar a altura inicial do objeto. Assuma que a
# aceleração da gravidade é igual a 9,81 m/s2. Escreva um algoritmo que calcule e imprima a altura
# máxima e o tempo de queda do objeto.
# g = 9.81 m/s²
def exercise_4():
    import math
    G = 9.81 #m/2²
    altura = float(input('Altura inicial (m): '))
    tempo_queda = math.sqrt(2 * altura / G)
    altura_maxima = (G * (tempo_queda ** 2)) / 2
    print(f'O tempo foi de {tempo_queda:.2f}s e a altura maxima de {altura_maxima:.2f}m')
# exercise_4()


# 5. Você está desenvolvendo um programa para calcular a distância percorrida por um objeto em um
# movimento uniformemente acelerado. O usuário deve informar a velocidade inicial, a aceleração e o
# tempo de deslocamento. Escreva um algoritmo que calcule e imprima a distância percorrida pelo
# # objeto.
def exercise_5():
    velocidade_inicial = round(float(input('Qual a velocidade inicial? (Km/h) ')) / 3.6, 2)
    aceleracao = float(input('Qual a aceleração? (m/s²) '))
    tempo_deslocamento = round(float(input('Qual o tempo de deslocamento (h)? ')) * 3600, 2)
    print(f'A distância percorrida foi de {(velocidade_inicial * tempo_deslocamento + (aceleracao * (tempo_deslocamento ** 2)) / 2) / 1000} Km')
# exercise_5()

# 6. Você está desenvolvendo um programa para classificar triângulos de acordo com as medidas de
# seus lados. O usuário deve informar as medidas dos três lados do triângulo. Escreva um algoritmo
# que determine e imprima se o triângulo é equilátero, isósceles ou escaleno.
def exercise_6():
    lado_a = float(input('Qual tamanho do lado do triângulo? '))
    lado_b = float(input('Qual tamanho do outro lado? '))
    lado_c = float(input('E do outro lado? '))
    if lado_a == lado_b == lado_c:
        print('Equilátero!')
    elif lado_a == lado_b or lado_a == lado_c or lado_b == lado_c:
        print('Isósceles!')
    else:
        print('Escaleno!')
# exercise_6()


# 7. João é um médico que trabalha em uma clínica especializada em saúde preventiva. Ele está
# desenvolvendo um programa para calcular o IMC (Índice de Massa Corporal) de seus pacientes. O
# IMC é uma medida que relaciona o peso e a altura de uma pessoa e é utilizada para verificar se ela
# está com o peso ideal. João sabe que, para calcular o IMC, ele precisa da altura e do peso do
# paciente. Escreva um algoritmo em Python que ajude João a calcular o IMC de seus pacientes.
def exercise_7():
    nome = input('Qual o seu nome? ')
    peso = float(input('Qual o seu peso? '))
    altura = float(input('Qual a sua altura? '))

    imc = peso / altura ** 2
    resultado = ''
    if imc <= 18.5:
        resultado = 'Abaixo do peso normal'
        print(f'{nome}, seu IMC está classificado como "{resultado}"')
    elif imc > 18.5 and imc < 24.9:
        resultado = 'Peso normal'
        print(f'{nome}, seu IMC está classificado como "{resultado}"')
    elif imc > 25 and imc < 29.9:
        resultado = 'Excesso de peso'
        print(f'{nome}, seu IMC está classificado como "{resultado}"')
    elif imc > 30.0 and imc < 34.9:
        resultado = 'Obesidade classe I'
        print(f'{nome}, seu IMC está classificado como "{resultado}"')
    elif imc > 35.0 and imc < 39.9:
        resultado = 'Obesidade classe II'
        print(f'{nome}, seu IMC está classificado como "{resultado}"')
    else:
        resultado = 'Obesidade classe III'
        print(f'{nome}, seu IMC está classificado como "{resultado}"')
# exercise_7()

# 8. Maria é uma estudante de física que está desenvolvendo um programa para converter uma
# temperatura de Celsius para Fahrenheit. Ela sabe que muitas vezes precisa realizar essa conversão
# em seus estudos, mas a fórmula matemática pode ser confusa. Por isso, ela está desenvolvendo um
# programa em Python que simplifica esse processo. Escreva um algoritmo que ajude Maria a
# converter uma temperatura de Celsius para Fahrenheit.
# F = (9/5 * C) + 32
def celcius_to_fahrenheit():
    celcius = float(input('Qual a temperatura em ºC? '))
    fahrenheit = round(((9/5) * celcius) + 32, 2)
    print(f'{celcius}ºC equivalem a {fahrenheit}F')
# celcius_to_fahrenheit()


# 9. Pedro é um estudante de matemática que está desenvolvendo um programa para calcular o volume
# de uma esfera. Ele sabe que o cálculo pode ser um pouco complicado, mas também é muito
# importante em diversas áreas da matemática e da física. Pedro está animado em desenvolver esse
# programa em Python para ajudar outros estudantes a entenderem melhor a fórmula. Escreva um
# algoritmo que ajude Pedro a calcular o volume de uma esfera.
# V = 4/3π * r³
def volume_esfera():
    import math
    raio = float(input('Qual o raio dessa esfera (cm)? '))
    volume = (4 * math.pi * (raio ** 3)) / 3
    print(f'O volume da esfera é de {volume:.2f}cm³')
# volume_esfera()


# 10. Ana é uma professora de matemática que está desenvolvendo um programa para calcular a média
# aritmética de uma lista de números. Ela sabe que, para calcular a média, é necessário somar todos
# os números da lista e dividir pelo total de números. Ana quer desenvolver um programa em Python
# que possa ser utilizado por seus alunos para facilitar esse processo. Escreva um algoritmo que ajude
# Ana a calcular a média aritmética de uma lista de números.

def media_notas():
    notas = []
    while True:
        decisao = input('Adicionar nota? (s / n) ').lower()
        if decisao == 's' or decisao == 'sim':
            nota = float(input('Nota: '))
            notas.append(nota)
        else:
            break
    print(f'A média é de: {sum(notas) / len(notas):.2f}')
# media_notas()