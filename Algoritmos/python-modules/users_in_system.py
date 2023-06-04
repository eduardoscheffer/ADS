import psutil # importa psutil pro código (após instalar - pip install psutil - na pasta do projeto)
from threading import Timer # importa a funcao Timer
import math # importa a biblioteca math

# print(psutil.users()[0].name) # printa o nome do usuario connectado no OS
def print_user():
    print(f'Olá, {psutil.users()[0].name}.')

# print(psutil.sensors_battery().percent) printa a porcentagem atual de bateria da maquina
def print_battery_percentage():
    print(f'{psutil.sensors_battery().percent}%')

# print(psutil.sensors_battery().secsleft) printa o tempo (em segundos) restante de bateria
def print_secs_battery_left():
    minutos_restantes = psutil.sensors_battery().secsleft // 60
    
    # cálculo dos segundos restantes de bateria na máquina
    # (valor quebrado - valor inteiro) * 60:
    segundos_restantes = ((psutil.sensors_battery().secsleft / 60) - (psutil.sensors_battery().secsleft // 60)) * 60

    print(f'{minutos_restantes} minutos e {math.trunc(segundos_restantes)} segundos restantes.')

def saindo():
    print('')

while True:
    print('_______________________________')
    print()
    print('1 -> Porcentagem de Bateria   2 -> Tempo restante de bateria 3 -> Usuario(s) conectados(s)   4 -> SAIR')
    print()
    print('-------------------------------')
    opcao = int(input('O que deseja saber? '))
    
    if opcao == 4:
        print('Saindo...')
        t = Timer(2, saindo) # executa a função Timer da threading após 2 segundos
        t.start()
        break
    if opcao == 1:
        print_battery_percentage()
    if opcao == 2:
        print_secs_battery_left()
    if opcao == 3:
        print_user()
