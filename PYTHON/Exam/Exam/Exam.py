import csv
def funcReadByDate (FILENAME):
    try:
        d = str(input('Введите дату\n'))
        with open(FILENAME, 'r') as file:
            reader = csv.DictReader(file)
            for row in reader:
                print(row['Date'])
                if row['Date'] == d:
                    print(row['Category'] + '\t' + row['Product'] + '\t' + row['Price'] + "\t" + row['Quantity'] + '\t' + row['Date'])
    except IOError as err:
        print(err)

def funcWrite (FILENAME):
    d = str(input("Введите дату\n"))
    c = str(input("Введите категорию товара\n"))
    p = str(input("Введите товар\n"))
    pr = float(input("Введите цену\n"))
    q = float(input("Введите количество\n"))
    bar = {'Category': c, 'Product': p, 'Price': pr, 'Quantity': q, 'Date': d}
    columns = ["Category", "Product", "Price", "Quantity", "Date"]
    try:
        with open(FILENAME, 'a+', newline="") as file:
            writer = csv.DictWriter(file, fieldnames=columns)
            writer.writerow(bar)
    except IOError as err:
        print(err)

def funcReadByCategory (FILENAME):
      try:
        d = str(input('Категория товара\n'))
        with open(FILENAME, 'r') as file:
            reader = csv.DictReader(file)
            for row in reader:
                if row['Category'] == d:
                    print(row['Category'] + '\t' + row['Product'] + '\t' + row['Price'] + "\t" + row['Quantity'] + '\t' + row['Date'])
      except IOError as err:
          print(err)

def funcSortByPrice (FILENAME):
    lis = []
    with open(FILENAME, 'r') as file:
        reader = csv.DictReader(file)
        for row in reader:
            lis.append(row['Price'])
    print(lis)
    lis.sort()
    print(lis)

def funcDelAll (FILENAME):
       try:
            with open(FILENAME, 'w', newline="") as file:
                columns = ['Category', 'Product', 'Price', 'Quantity', 'Date']
                writer = csv.DictWriter(file, fieldnames=columns)
                writer.writeheader()
       except IOError as err:
                print(err)

def funcReadAll (FILENAME):
     with open(FILENAME, 'r', newline='') as file:
         reader = csv.reader(file)
         print('\n')
         for row in reader:
             print(row[0] + '\t' + row[1] + '\t'  + row[2] + '\t'  + row[3] + '\t'  + row[4])
         print('\n')

while True:

    step = int(input("Для добавления данных нажмите\t 1\nДля вывода всех данных нажмите\t 2\nДля поиска по дате нажмите\t 3\nДля поиска по категории продукта введите 4\nДля очистки файла введите 5\nДля сортировки по цене нажмите 6\nДля выхода из программы нажмите 7\n"))

    if step == 1:
        funcWrite("Base.csv")
    elif step == 2:
        funcReadAll("Base.csv")
    elif step == 3:
        funcReadByDate("Base.csv")
    elif step == 4:
        funcReadByCategory("Base.csv")
    elif step == 5:
        funcDelAll("Base.csv")
    elif step == 6:
        funcSortByPrice("Base.csv")
    elif step == 7:
        break
    else:
        print('Вы ввели некорректное число')
