a = "hello"
b = 'hello'
print(a, b)
print(a[0]) # strings are just an array of characters
a += '!' # adds an !
print(a)

escapeChar = "\n \t \' \" \\" # new line, tab, single quote, double quote, double \\
print(escapeChar)

name = "Tom"
c = f"Hello {name}!" # interpolated string
print(c)

name = name.lower() # lower case
print(name)
name = name.upper() # upper case
print(name)

name = "I like turtles"
does = name.__contains__('like') # wrapper method to check if a string contains a word
print(does)

if 'like' in name:
    print(does)