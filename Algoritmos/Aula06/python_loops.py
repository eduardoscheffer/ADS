# No entanto, muitas vezes queremos propositalmente um loop infinito, e
# para sairmos dele em algum momento, utilizamos a instrução break, a qual
# pode ser usada sempre que quisermos interromper um loop:
while True:
    resposta = input("Qual a capital do Canadá?")
    if resposta == "Ottawa":
        print("Acertou!")
        break
    else:
        print("Tente novamente")
###################################################################
# O continue é utilizado para voltar ao início do loop, mesmo antes de
# chegar a última linha dele. O continue força a volta para o início do loop
while True:
    resposta = input('Qual a capital do Canadá?')
    while resposta != "Ottawa":
        print('Tente novamente!')
        resposta = input('Qual a capital do Canadá?')
    print('Acertou!')
    break
###################################################################
# for loops:
planetas = ["Mercúrio", "Vênus", "Terra", "Marte", "Júpiter", "Saturno", "Urano","Netuno"]
for i in range(len(planetas)):
	print(i, planetas[i])
# 0 Mercúrio
# 1 Vênus
# 2 Terra
# 3 Marte
# 4 Júpiter
# 5 Saturno
# 6 Urano
# 7 Netuno
# 8 Plutão
# Uma solução mais elegante que a do exemplo anterior é utilizar a função
# enumerate
for key, value in enumerate(planetas):
	print(key, value)
# 0 Mercúrio
# 1 Vênus
# 2 Terra
# 3 Marte
# 4 Júpiter
# 5 Saturno
# 6 Urano
# 7 Netuno
# 8 Plutão

for planeta in planetas:
	print(planeta)
# Mercúrio
# Vênus
# Terra
# Marte
# Júpiter
# Saturno
# Urano
# Netuno
###################################################################
#Iterando sobre objetos:
skills = {"velocidade":8, "sabedoria":7, "carisma":9}
for k in skills:
	print(k)
# velocidade
# sabedoria
# carisma
for k, v in skills.items():
	print(k, v)
# velocidade 8
# sabedoria 7
# carisma 9

###################################################################
# Determinar a maior nota de uma turma:
notas = [1 ,6, 4, 10, 3 ,2, 0, 7]
maior_nota = 0
for n in notas:
	if n > maior_nota:
		maior_nota = n
print(maior_nota) # 10
#Calculando a média das notas:
total = 0
for n in notas:
	total += n # soma dos valores das notas
media = total / len(notas)
print(total) # 33
print(media) # 4.125