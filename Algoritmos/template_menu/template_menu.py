def print_menu():
    print('_______________________________')
    print('1 - OPCAO1       2 - OPCAO2      3 - SAIR')
    print('-------------------------------')

def get_opcao():
    return int(input("O que deseja fazer? "))


while True:
    print_menu()
    try:
        opcao = get_opcao()
        if (opcao < 1 or opcao > 3):
            print("Opção indisponível")
    except:
        print("Digite um número inteiro válido dentro das opções do menu.")
        continue

    if (opcao == 3):
        print("Saindo...")
        print();
        break
    else:
        continue