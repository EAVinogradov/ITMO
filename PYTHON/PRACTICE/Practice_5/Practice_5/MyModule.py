from random import randint
import time
import statistics
igrok_1=str(0)
igrok_2=str(0)
igroki=str(0)
broski=int(0)
def vvod_imeni():
    global igrok_1
    global igrok_2
    global igroki
    igrok_1=input('Введите имя 1-го игрока: ')
    igrok_2=input('Введите имя 2-го игрока: ')
    igroki=igrok_1 + igrok_2
    print ('В игру вступают: ',igrok_1,' и ',igrok_2)

def broski_kubika():
    global broski
    global igrok_1
    global igrok_2
    broski=int(input('Введите количество бросков кубика за партию: '))
    print ('Партия состоит из ', broski, 'бросков кубика.')
    print('Кубик бросает',igrok_1)
    time.sleep(2)
    n1=[randint(1,6) for i in range (broski)]
    print('Выпавшие числа:', n1)
    print('Сумма выпавших чисел ', statistics.fsum (n1))
    print('Кубик бросает',igrok_2)
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


