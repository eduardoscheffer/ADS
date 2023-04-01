# 7. Verificação de senha: Escreva um programa que peça ao usuário uma senha e verifique se
# ela é válida ou não. Considere uma senha válida aquela que possui pelo menos 8
# caracteres, contendo pelo menos uma letra maiúscula e um número. Se a senha for válida,
# exiba a mensagem "Senha válida". Caso contrário, exiba "Senha inválida".
def exercise_8():
    senha = input('Digite a sua senha: ')
    maximo_caracter = 8
    tem_maiuscula = False
    tem_minuscula = False
    if len(senha) > maximo_caracter:
        for caracter in senha:
            if caracter.isupper():
                tem_maiuscula = True
            if caracter.islower():
                tem_minuscula = True
    else:
        print('Senha deve ter no minimo 8 caracteres')
    if tem_maiuscula and tem_minuscula:
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