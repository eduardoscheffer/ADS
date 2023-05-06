lista = [1, 2, 3, 4, 5]
lista_alfabetica = ['a', 'b', 'c', 'd', 'e']

# print(lista[-1]) # 5
# print(lista_alfabetica[-1]) # e
# for i in range(3):
#     print(i)

import os
def limpar():
    if os.name == 'nt':
        os.system('cls') # limpa o terminal em windows
    else:
        os.system('clear') # limpa o terminal em Linux