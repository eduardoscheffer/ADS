def print_menu():
    print('----CONVERSOR DE UNIDADES-----')
    print('_______________________________')
    print('1 - Quilômetros para Milhas       2 - Milhas para Quilômetros      3 - Metros para Pés       4 - Pés para Metros     5 - Centímetros para Polegadas      6 - Polegadas para Centímetros      7 - Sair')
    print('-------------------------------')

def get_opcao():
    return int(input("O que deseja fazer? "))


while True:
    print_menu()
    try:
        opcao = get_opcao()
        if (opcao < 1 or opcao > 7):
            print("Opção indisponível")
    except:
        print("Digite um número inteiro válido dentro das opções do menu.")
        continue

    if (opcao == 7):
        print("Saindo...")
        print()
        break
    elif (opcao == 1):
        kilometros = float(input("Digite o valor em Km: "))
        milhas = kilometros * 0.621371
        print(f'{milhas} milhas')
    elif (opcao == 2):
        milhas = float(input("Digite o valor em milhas: "))
        kilometros = milhas * 1.60934
        print(f'{kilometros} Km')
    elif (opcao == 3):
        metros = float(input("Digite o valor em metros: "))
        pes = metros * 3.28084
        print(f'{pes} pés')
    elif (opcao == 4):
        pes = float(input("Digite o valor em pés: "))
        metros = pes * 0.3048
        print(f'{metros} metros')
    elif (opcao == 5):
        centimetros = float(input("Digite o valor em cm: "))
        polegadas = centimetros * 0.393701
        print(f'{polegadas} polegadas')
    elif (opcao == 6):
        polegadas = float(input("Digite o valor em polegadas: "))
        centimetros = polegadas * 2.54
        print(f'{centimetros} cm')
    else:
        print('Digite uma opção válida')