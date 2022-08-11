from xml.etree.ElementTree import PI


def ABC():
    print('Pizza')

inv1 = "empty"
inv2 = "empty"
inv3 = "empty"
pickup1 = "pizza"
pickup2 = "candy"


def PickupPizzaI1():
    global inv1
    if inv1 == "empty":
        inv1 = pickup1
        # UI
        # VFX
        # Update Slot 1
        # Update Slot 2

def PickupCandyI3():
    global inv3
    if inv3 == "empty":
        inv3 = pickup2
        # UI
        # VFX
        # Update Slot 1
        # Update Slot 2

PickupPizzaI1()
PickupCandyI3()
print(inv1, inv2, inv3)