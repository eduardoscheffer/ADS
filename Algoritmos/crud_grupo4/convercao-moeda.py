import requests

requisicao = requests.get('https://economia.awesomeapi.com.br/json/last/USD-BRL,EUR-BRL,BTC-BRL')

requisicao = requisicao.json()
dolar_atual = float(requisicao['USDBRL']['bid']) #4.993 float
euro_atual = float(requisicao['EURBRL']['bid']) # 5.3508 float
btn_atual = float(requisicao['BTCBRL']['bid']) # 134400 float

def brl_to_dol():
    brl = float(input('Digite o valor em reais: '))
    print(f'R${brl} equivalem a ${round(brl / dolar_atual, 2)}.')

def brl_to_eur():
    brl = float(input('Digite o valor em reais: '))
    print(f'R${brl} equivalem a EUR {round(brl / euro_atual, 2)}.')

def brl_to_btn():
    brl = float(input('Digite o valor em reais: '))
    print(f'R${brl} equivalem a BTN {brl / btn_atual}.')

while True:
    print('_______________________________')
    print()
    print('1 BRL -> DOL   2 BRL -> EUR   3 BRL -> BTN   4 SAIR')
    print()
    print('-------------------------------')
    opcao = int(input('Qual conversão deseja fazer? '))
    
    if opcao == 4:
        print('Saindo...')
        break
    if opcao == 1:
        brl_to_dol()
    if opcao == 2:
        brl_to_eur()
    if opcao == 3:
        brl_to_btn()