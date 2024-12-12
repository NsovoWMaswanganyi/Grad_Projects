
from car import Car

class CarsList:
    def __init__(self):
        self.CarList = []
        
    def ReadData(self):
        with open("carData.txt", "r") as file:
            for line in file:
                fields = line.strip().split(',')
                reg_num = fields[0]
                model_Name = fields[1]
                year = int(fields[2])
                color = fields[3]
                price = float(fields[4])
                status = fields[5]
                newCar = Car(reg_num,model_Name,year,color,price,status)
                self.CarList.append(newCar)

    def AddNewCar(self,newCar):
        self.CarList.append(newCar)

    def DisplayAvailables(self):
        for car in self.CarList:
            if car.Status == "available":
                car.DisplayCar()

    def DisplayAlls(self):
        for car in self.CarList:
            car.DisplayCar()

            


    
          






