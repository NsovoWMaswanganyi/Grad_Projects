class Car:
    #This is like a constructor in languages such as C#
    def __init__(self,regNum,modelName,year,color,price,status):
        self.regNum = regNum
        self.modelName = modelName
        self.year = year
        self.color = color
        self.price = price
        self.status = status

    #This is like a getter in c#
    @property
    def Status(self):
        return self.status

    @Status.setter
    def Status(self,new_status):
        self.status= new_status

    def DisplayCar(self):
        print(f"Registration: {self.regNum} ,  Price: R{self.price:,.2f}")




