# Exercícios de Python
# 1. Faça um algoritmo que some dois números e imprima o resultado.
def exercise1 (a, b):
    print(f'A soma é {a + b}.')
# exercise1(2, 2)

# 2. Faça um algoritmo que subtraia dois números e imprima o resultado.
def exercise2 (a, b):
    print(f'A subtração é {a - b}.')
# exercise2(4 ,2)

# 3. Faça um algoritmo que multiplique dois números e imprima o resultado.
def exercise3 (a ,b):
    print(f'A multiplicação é {a * b}.')
# exercise3(3, 3)

# 4. Faça um algoritmo que divida dois números e imprima o resultado.
def exercise4 (a , b):
    print(f'A divisão é {a / b}')
# exercise4(10, 5)

# 5. Faça um algoritmo que calcule o resto da divisão de um número por outro e imprima o
# resultado.
def exercise5 (a, b):
    print(f'O resto da divisão é {a % b}')
# exercise5(5, 2)

# 6. Faça um algoritmo que calcule a potência de um número e imprima o resultado.
def exercise6 (a , b):
    print(f'O resultado de {a} elevado a {b}ª potência é {a ** b}.')
# exercise6(2, 2)


# 7. Faça um algoritmo que calcule a média aritmética de dois números e imprima o resultado.
def exercise7 (a , b):
    print(f'A média é {(a + b) / 2}')
# exercise7(5, 13)

# 8. Faça um algoritmo que calcule a área de um retângulo de base e altura informados pelo
# usuário e imprima o resultado.
def exercise8 ():
    base = int(input('Qual a base do triângulo? '))
    altura = int(input('Qual a altura do triângulo? '))
    area = (base * altura) / 2
    print(f'A área do triângulo é {area}m²')
# exercise8()

# 9. Faça um algoritmo que calcule o perímetro de um quadrado de lado informado pelo usuário e
# imprima o resultado.
def exercise9 ():
    perimetro = int(input('Qual o lado do quadrado? '))
    print(f'O perímetro do quadrado é {perimetro * 4}')
# exercise9()

# 10. Faça um algoritmo que calcule o volume de uma caixa de dimensões informadas pelo
# usuário e imprima o resultado.
def exercise10 ():
    x = int(input('Qual a largura da caixa? '))
    y = int(input('Qual o comprimento da caixa? '))
    z = int(input('Qual a altura da caixa? '))
    print(f'O volume da caixa é {x * y * z}m³')
# exercise10()

# 11. Faça um algoritmo que calcule o desconto de um produto com base em sua porcentagem de
# desconto e imprima o preço final.
def exercise11():
    preco_produto = int(input('Qual o valor do produto? '))
    desconto = float(input('Qual a porcentagem(%) de desconto? '))
    preco_final = preco_produto - (preco_produto * (desconto / 100))
    print(f'O preço com desconto agora é R${preco_final}.')
# exercise11()

# 12. Faça um algoritmo que calcule a distância percorrida por um veículo com base em sua
# velocidade e tempo de percurso informados pelo usuário e imprima o resultado.
def exercise12():
    velocidade_media = float(input('Qual a velocidade (em Km/h) média do percurso? '))
    tempo_medio = float(input('Qual o tempo (em horas) levado? '))
    distancia = velocidade_media * tempo_medio
    print(f'A distância percorrida doi de {distancia}Km')
# exercise12()

# 13. Faça um algoritmo que calcule o valor final de uma aplicação financeira com base em seu
# valor inicial, taxa de juros e tempo de aplicação informados pelo usuário e imprima o resultado.
def exercise13():
    valor_inicial_aplicado = float(input('Qual o valor(R$) aplicado? '))
    tempo_da_aplicacao = int(input('Qual o tempo (meses) da aplicação? '))
    taxa_de_juros = float(input('Qual a taxa de juros(%) mensais? '))
    montante = valor_inicial_aplicado * (1 + (taxa_de_juros / 100))**tempo_da_aplicacao
    print(f'O montante no final da aplicação será de R${montante}.')
# exercise13()

# 14. Faça um algoritmo que calcule a média ponderada de três notas com pesos informados pelo
# usuário e imprima o resultado.
def exercise14(bio, port, mat):
    peso1 = float(input('Qual o peso da nota de biologia? '))
    peso2 = float(input('Qual o peso da nota de portugues? '))
    peso3 = float(input('Qual o peso da nota de matematica? '))
    media_ponderada = round(((bio * peso1) + (port * peso2) + (mat * peso3)) / (peso1 + peso2 + peso3), 2)
    print(f'A media do aluno foi {media_ponderada}')
exercise14(7, 6.5, 6)
