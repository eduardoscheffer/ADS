# Algoritmo que recebe 1 valor em R$ e me diga quantas notas ou moedas eu preciso.
numero = float(input('Qual o valor em Reais? '))

nota_100 = numero // 100 # 120
numero = numero % 100 #20

nota_cinquenta = int(numero / 50)
numero = numero % 50

nota_vinte = int(numero / 20)
numero = numero % 20

nota_dez = int(numero / 10)
numero = numero % 10

nota_cinco = int(numero / 5)
numero = numero % 5

nota_dois = int(numero / 2)
numero = numero % 2

nota_um = int(numero / 1)
numero = numero % 1

cinquenta_centavos = int(numero / 0.5)
numero = numero % 0.5

vinte_cinco_centavos = int(numero / 0.25)
numero = numero % 0.25

dez_centavos = int(numero / 0.10)
numero = numero % 0.10

um_centavo = int(numero / 0.01)
numero = numero % 0.01

print(f'Vai precisa de {nota_100} notas de cem')
print(f'Vai precisa de {nota_cinquenta} notas de cinquenta')
print(f'Vai precisa de {nota_vinte} notas de vinte')
print(f'Vai precisa de {nota_dez} notas de dez')
print(f'Vai precisa de {nota_cinco} notas de cinco')
print(f'Vai precisa de {nota_dois} notas de dois')
print(f'Vai precisa de {nota_um} notas de um')
print(f'Vai precisa de {cinquenta_centavos} de moeda de cinquenta')
print(f'Vai precisa de {vinte_cinco_centavos} de moeda de vinte e cinco centavos')
print(f'Vai precisa de {dez_centavos} de moeda de dez centavos')
print(f'Vai precisa de {um_centavo} de moeda de um centavo')