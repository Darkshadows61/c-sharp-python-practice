myHP=10
enemyHP = 30
money = 0
hitLegs = True
hitArms = True
hitHead = True
            
def hitEvent():
    global enemyHP, money, myHP
    enemyHP -=1
    money += 5
    myHP += 2

if hitLegs:
    hitEvent()

if hitArms:
    hitEvent()

if hitHead:
    hitEvent()

print(enemyHP, myHP, money)