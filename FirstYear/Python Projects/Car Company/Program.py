from car import Car
from carList import CarsList

list_of_cars = CarsList()
list_of_cars.ReadData()
def main():
    
    choice = DisplayOptions()

    while choice != 4:
        ProcessOptions(choice)
        choice = DisplayOptions()

def ProcessOptions(choice):
    if(choice == 1):
        AddCar()
    elif(choice == 2):
        DisplayAvailable()
    elif(choice == 3):
        DisplayAll()
    elif(choice == 4):
        print("Exiting the program...")
    else:
        print("Invalid choice.")


def DisplayOptions():

    print("\nIndicate your choice from the following options, 4 to quit.")
    print("1. Add a car to the list.")
    print("2. Display the registration numbers and prices for all available cars.")
    print("3. Display all the fields for all the cars.")
    print("4. Quit.")
    return int(input("Choice: "))


def AddCar():
    regNum = input("Registration number: ")
    modelName = input("Model name: ")
    year = int(input("Year: "))
    color = input("Color: ")
    price = float(input("Price: "))
    status = input("Status: ")
    newCar = Car(regNum, modelName, year, color, price, status)
    list_of_cars.AddNewCar(newCar)
    print("Car has been added to the list")


def DisplayAvailable():
    list_of_cars.DisplayAvailables()
    
    
def DisplayAll():
    list_of_cars.DisplayAlls()



if __name__ == "__main__":
    main()
