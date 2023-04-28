# Crie um algoritmo capaz de ler dois valores e imprimir uma das três mensagens a seguir:
# ‘Números iguais’, caso os números sejam iguais
# ‘Primeiro é maior’, caso o primeiro seja maior que o segundo;
# ‘Segundo maior’, caso o segundo seja maior que o primeiro.
def questao_7():
    try:
        numero = float(input('Digite um número: ')) # pega o primeiro numero
        outro_numero = float(input('Digite outro número: ')) # pega o segundo numero
    except:
        print('Sómente números permitido!') # trata o erro caso não for um numero no try
        return # sai fora da funcao
    if numero > outro_numero: # se o primeiro numero for maior que o segundo
        print('Primeiro número maior que o segundo.')
    elif numero < outro_numero: # se o primeiro numero for menor que o segunfo
        print('Segundo número maior que o primeiro')
    else: # se não for maior nem menor, são iguais
        print('Números iguais')
# questao_7()


# Crie um algoritmo que receba o nome, sexo, idade e tempo de trabalho (contribuição).
# Com base nos seguintes requisitos para aposentadoria: 
# Mulheres - 30 anos de contribuição e 55 anos de idade
# Homens - 35 anos de contribuição e 60 anos
# Diga se as pessoas consultadas podem ou não requerer a aposentadoria.
# Armazene as informações de quantas pessoas foram consultadas, por exemplo: esta é a consulta número XX.
# Necessário MENU com interface para usuário (no terminal, não é tela gráfica!).

def calcula_aposentadoria_homem(tempo, idade):
    if idade >= 60 and tempo >= 35:
        print('Pode se aposentar.')
    else:
        print('Não tem o direito ainda.')

def calcula_aposentadoria_mulher(tempo, idade):
    if idade >= 55 and tempo >= 30:
        print('Pode se aposentar.')
    else:
        print('Não tem o direito ainda.')

while True:
    print('_______________________________')
    print('1 - MULHER   2 - HOMEM - 3 SAIR')
    print('-------------------------------')
    genero = int(input('Qual o gênero? '))
    if genero == 3:
        print('Saindo...')
        break
    if genero == 1:
        idade = int(input('Qual a sua idade? '))
        tempo = int(input('Quantos anos de contribuição? '))
        calcula_aposentadoria_mulher(tempo, idade)
        break
    if genero == 2:
        idade = int(input('Qual a sua idade? '))
        tempo = int(input('Quantos anos de contribuição? '))
        calcula_aposentadoria_homem(tempo, idade)
        break