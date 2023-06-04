import psutil

# print(psutil.users()[0].name) # printa o nome do usuario connectado no OS

print(psutil.sensors_battery().percent)