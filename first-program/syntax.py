# Init Variables
name =""
programmer = ""
what = ""
profession = ["","","",""]
tough = ""
# Get Input From User
print(f"Welcome User")
print(f"Let's play a sad game of Mad Libs")
name = input("Please share with me your name?\n")

print(f'Ok {name}.')
programmer = input("What job would you like to do?\n")

print(f"Ok {name}, now I need 4 professions you cannot do")
for i in range(len(profession)):
    profession[i] = input(f"profession {i + 1} / {len(profession)}")

# Init Story
madStory = (
            f"Why do you want to be a {programmer}? " +
            f"Well, it all goes back to when I was {what} " +
            f". I was told I couldn't be {profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}, " +
            f"It was a {tough} time."
)
# Print Story
print(madStory)
input()