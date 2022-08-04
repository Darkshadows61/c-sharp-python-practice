# Init Variables
name =""
programmer = ""
what = ""
profession = ["","","",""]
tough = ""
# Get Input From User
print("Welcome User")
print("Let's play a sad game of Mad Libs")
name = input("Please share with me your name?\n")

print('Ok {name}.')
programmer = input("What job would you like to do?\n")



# Init Story
madStory = (
            f"Why do you want to be a {programmer}? " +
            f"Well, it all goes back to when I was {what} " +
            f". I was told I couldn't be {profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}, " +
            f"It was a {tough} time."
)
# Print Story
print(madStory)