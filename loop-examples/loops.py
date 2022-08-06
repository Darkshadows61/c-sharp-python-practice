for i in range(10):
    print(i)
    # (int, condition, command)

def ReadData(read):
    return f"candy data from {read}\n"

fileName = [None]*700
masterData =""

for i in range(len(fileName)):
    fileName[i] = f"candy Data {i + 1}.txt \n"
    masterData += ReadData(fileName[i])

print(masterData)

# while
while True:
    pass # passes the following code while is true
print("reached?")