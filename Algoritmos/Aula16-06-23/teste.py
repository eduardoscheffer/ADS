lista = []

while (True):
    
    numero = int(input("Adicione um numero: "))
    if (numero % 2 != 0):
        lista.append(numero)

    if (len(lista) >= 10):
        break
    
listaEven = list(filter(lambda x: x % 2 != 0, lista))
print(listaEven)