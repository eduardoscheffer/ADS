# 1. Cálculo de média: Escreva um programa que leia três notas e calcule a média do aluno. Se a
# média for maior ou igual a 7, exiba a mensagem "Aprovado". Caso contrário, exiba
# "Reprovado".
def exercise_1():
    qtd_notas = 3
    notas = []
    while qtd_notas > 0:
        nota = int(input('Qual a nota do aluno? '))
        notas.append(nota)
        qtd_notas -= 1
    media = round(sum(notas) / len(notas), 3)
    if media < 7:
        print(f'Reprovado! Média: {media}')
    else:
        print(f'Aprovado! Média: {media}')
# exercise_1()

# 2. Verificação de idade: Escreva um programa que peça a idade do usuário e verifique se ele é
# maior de idade ou não. Se for maior de idade, exiba a mensagem "Você é maior de idade".
# Caso contrário, exiba "Você é menor de idade".
def exercise_2():
    try:
        idade = int(input('Qual a sua idade? '))
    except:
        print('Idade deve ser um número inteiro!')
        return
    if idade >= 18:
        print('Maior de idade.')
    else:
        print('Menor de idade.')
# exercise_2()

# 3. Verificação de números pares: Escreva um programa que leia um número inteiro e verifique
# se ele é par ou ímpar. Se for par, exiba a mensagem "O número é par". Caso contrário, exiba
# "O número é ímpar".
def is_even(number):
    # number = int(input('Qual numero deseja saber se é par ou não? '))
    # if number % 2 == 0:
    #     return True
    # return False
    return number % 2 == 0
# print(is_even(8)) # True

# 4. Cálculo de desconto: Escreva um programa que leia o valor de um produto e calcule o valor
# com desconto de 10%. Se o valor do produto for maior que R$ 50,00, aplique um desconto
# adicional de 5%. Exiba o valor final com desconto.
def exercise_4():
    valor_produto = float(input('Qual o valor do produto? R$'))
    if valor_produto <= 50:
        valor_produto -= valor_produto * (10 / 100)
        print(f'O produto com desconto agora custa: R${valor_produto}')
    else:
        valor_produto -= valor_produto * (15 / 100)
        print(f'O produto com desconto agora custa: R${valor_produto}')
# exercise_4()

# 7. Verificação de senha: Escreva um programa que peça ao usuário uma senha e verifique se
# ela é válida ou não. Considere uma senha válida aquela que possui pelo menos 8
# caracteres, contendo pelo menos uma letra maiúscula e um número. Se a senha for válida,
# exiba a mensagem "Senha válida". Caso contrário, exiba "Senha inválida".
def exercise_7():
    senha = input('Digite a sua senha: ')
    maximo_caracter = 8
    tem_maiuscula = False
    tem_minuscula = False
    if len(senha) > maximo_caracter: # se a senha tiver mais que 8 caracteres:
        for caracter in senha: # percorre a senha pra ver cada caracter
            if caracter.isupper():
                tem_maiuscula = True # se tiver maiuscula
            if caracter.islower():
                tem_minuscula = True # se tiver minuscula
    else:
        print('Senha deve ter no minimo 8 caracteres') # caso nao tiver 8 caracteres a senha
    if tem_maiuscula and tem_minuscula: # se tem_maiuscula e tem_minuscula forem true
        print('Senha forte.')
    else:
        print('Senha fraca. Deve ter letra maiúscula e números')


# 9. Verificação de ano bissexto: Escreva um programa que peça ao usuário um ano e verifique
# se ele é bissexto ou não. Um ano é bissexto se for divisível por 4 e não for divisível por 100,
# exceto quando é divisível por 400. Se o ano for bissexto, exiba a mensagem "O ano é
# bissexto". Caso contrário, exiba "O ano não é bissexto".
def exercise_9():
    ano = int(input('Qual o ano deseja saber? '))
    if ano % 4 == 0 and (ano % 100 != 0 or ano % 400 == 0):
        print('O ano é bissexto')
    else:
        print('O ano não é bissexto')
# exercise_9()

# 10.Verificação de vogal: Escreva um programa que leia uma letra e verifique se ela é uma vogal
# ou não. Se for uma vogal, exiba a mensagem "A letra é uma vogal". Caso contrário, exiba "A
# letra é uma consoante".
def exercise_10():
    while True:
        letra = input('Qual a letra deseja saber? ').lower()
        vogais = ['a', 'e', 'i', 'o', 'u']
        if letra in vogais:
            print('A letra é uma vogal')
            break # sai do loop
        else:
            print('A letra é uma consoante')
# exercise_10()