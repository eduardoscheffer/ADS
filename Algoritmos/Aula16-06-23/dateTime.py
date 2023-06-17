import datetime as dt
dataAtual = dt.datetime.now()

# print(dataAtual) # 2023-06-16 19:43:35.455563

anoAtual = dataAtual.year
# print(anoAtual) # 2023
# print(dataAtual.strftime("%A")) # Friday
weekDay = dataAtual.strftime("%A")
# print(dataAtual.strftime("%d")) # 16
dayNumber = dataAtual.strftime("%d")
# print(dataAtual.strftime("%B")) # June
month = dataAtual.strftime("%B")
horaAtual = dataAtual.strftime("%X")

print(f'Torres, {weekDay}, {dayNumber} de {month} de {anoAtual}. Hora: {horaAtual}') # Torres, Friday, 16 de June de 2023. Hora: 20:05:16
print(dataAtual.ctime()) # Fri Jun 16 20:05:16 2023

