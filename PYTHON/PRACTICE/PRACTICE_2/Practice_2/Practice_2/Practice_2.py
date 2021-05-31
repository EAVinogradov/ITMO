print("Работа сос троками")
string_1="THIS IS A STRING.    "
string_2="   This is another string.   "
string_3=string_1+string_2
print(string_1)
print(string_2)
print(string_3)
print(len(string_1))
print(string_2.title())
print(string_1.lower())
print(string_2.upper())
print(string_1.rstrip())
print(string_2.lstrip())
print(string_2.strip())
print(string_1.strip('T'))
print("------------------")

print("Извлечение символов и подстрок")
d="qwerty"
ch=d[2]
print(d)
chm=d[1:3]
print(chm)
chm=d[1:]
print(chm)
chm=d[:3]
print(chm)
chm=d[:]
print(chm)
chm=d[1:5:2]
print(chm)
print("------------------")

print("Работа с числами")
num_1=5
num_2=12
print(num_2/num_1)
print(num_2%num_1)
print(num_1**3)
#param="string"+15
#print(param)
param="string"+str(15)
print(param)
print("------------------")

print("Преобразование данных")
param="string"+str(15)
print(param)
n1=input("Enter the first number: ")
n2=input("Enter the second number: ")
n3=float(n1)+float(n2)
print(n1+"+"+n2+"=",n3)
print("------------------")

print("Форматирование строк")
a=1/3
print("{:7.3f}".format(a))
a=2/3
b=2/9
print("{:7.3f}{:7.3f}".format(a,b))
print("{:10.3e}{:10.3e}".format(a,b))

n1=input("Enter the first number: ")
n2=input("Enter the second number: ")
n3=float(n1)+float(n2)
print(n1+"+"+n2+"=","{:4.2f}".format(n3))
print("------------------")

print("Списки")
list1=[89,23,754,17,94,1,45,2,11,123]
print(dir(list))
help(list.insert)
help(list.append)
help(list.sort)
help(list.remove)
help(list.reverse)
help(list.pop)
print(list1)
list1[0]=234
list1.append(1000)
list1.insert(0,1000000)
print(list1)
list1.pop(0)
list1.pop()
print(list1)
print("------------------")

print("Сортировка элементов списка")
list1.sort()
list1.reverse()
print(list1)
list2=[45,2,76,34,1,5,254]
lis=sorted(list2)
print(list2)
print(lis)
print("------------------")

print("Кортежи")
print(dir(tuple))
help(tuple.index)
help(tuple.count)
seq=(42,54,5843,3,36784,21,332,2,568,2)
print(seq)
print(seq.count(2))
print(seq.index(3))
print(type(seq))
listseq=list(seq)
print(listseq,type(listseq))
