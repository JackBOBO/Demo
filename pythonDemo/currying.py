
def curring(y):
    return lambda x: x + y

print(curring(5)(2))




# def curring(y):
#     return lambda x: x + y

# func = curring(5)

# func(2)