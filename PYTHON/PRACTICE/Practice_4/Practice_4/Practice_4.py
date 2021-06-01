from random import randint
import time
import statistics
igrok_1=input('Введите имя 1-го игрока: ')
igrok_2=input('Введите имя 2-го игрока: ')
broski=int(input('Введите количетсво бросков кубика: '))
print('Кубик просает',igrok_1)
time.sleep(2)
n1=[randint(1,6) for i in range (broski)]
print('Выпавшие числа:', n1)
print('Сумма выпавших чисел ', statistics.fsum (n1))
print('Кубик просает',igrok_2)
time.sleep(2)
n2=[randint(1,6) for i in range (broski)]
print('Выпавшие числа:', n2)
print('Сумма выпавших чисел ', statistics.fsum (n2))
if n1>n2:
    print('Выйграл',igrok_1)
elif n1<n2:
    print('Выйграл',igrok_2)
else:
    print('Ничья')
