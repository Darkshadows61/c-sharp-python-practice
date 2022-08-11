MyNumb = 9

def Function(x):
    x *= 2
    print(x)

Function(MyNumb)

name = ["Johnny", "Carla", "Zack"]

def Surname(ind, sur):
    name[ind] = sur + name[ind]
    print(name[ind])

Surname(0, "Mr. ")
Surname(1, "Mrs. ")
Surname(2, "Mr. ")