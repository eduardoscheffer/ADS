# Eduardo Mengue Scheffer 30/06/2023
# AS - Algoritmos

# printa o menu
def print_menu():
    print('----CALCULADORA DA APROVAÇÃO----')
    print('________________________________')
    print('1 - VERIFICAR APROVAÇÃO      0 - SAIR')
    print('-------------------------------')

# pega opcao 
def get_opcao():
    return int(input("O que deseja fazer? "))

# calcula aprovacao
def calcula_aprovacao(media, num_presencas, nome):
    faltas = 24 - num_presencas
    
    if (faltas > 5):
        print(f'Infelizmente {nome}, você foi reprovado por faltas.')
        return

    if (media >= 6 and faltas <= 5):
        print(f'Parabéns {nome}, você foi aprovado.')
        return
    elif (media < 6 and faltas <= 5):
        print(f'{nome}, você deve fazer a Avaliação Final (AF).')
        return

# programa em si
while True:
    print_menu()
    try:
        opcao = get_opcao()
        if (opcao < 0 or opcao > 1):
            print("Opção indisponível")
    except:
        print("Digite um número inteiro válido dentro das opções do menu.")
        continue

    if (opcao == 0):
        print("Saindo...")
        print();
        break
    elif (opcao == 1):
        nome = input('Digite o seu nome: ')
        aP1 = float(input("Digite a nota da AP1: "))
        aP2 = float(input("Digite a nota da AP2: "))
        aS = float(input("Digite a nota da AS: "))
        num_presencas = int(input("Digite o número de presenças: "))

        media = (aP1 + aP2 + aS) / 3

        calcula_aprovacao(media, num_presencas, nome)
        print('')
    else:
        print('Digite uma opção válida.')
        
        


    
        