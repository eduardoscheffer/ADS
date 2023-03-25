nome = input('Qual o seu nome? ')
peso = float(input('Qual o seu peso? '))
altura = float(input('Qual a sua altura? '))

imc = peso / altura ** 2
resultado = ''
if imc <= 18.5:
    resultado = 'Abaixo do peso normal'
    print(f'{nome}, seu IMC está classificado como {resultado}')
elif imc > 18.5 and imc < 24.9:
    resultado = 'Peso normal'
    print(f'{nome}, seu IMC está classificado como {resultado}')
elif imc > 25 and imc < 29.9:
    resultado = 'Excesso de peso'
    print(f'{nome}, seu IMC está classificado como {resultado}')
elif imc > 30.0 and imc < 34.9:
    resultado = 'Obesidade classe I'
    print(f'{nome}, seu IMC está classificado como {resultado}')
elif imc > 35.0 and imc < 39.9:
    resultado = 'Obesidade classe II'
    print(f'{nome}, seu IMC está classificado como {resultado}')
else:
    resultado = 'Obesidade classe III'
    print(f'{nome}, seu IMC está classificado como {resultado}')