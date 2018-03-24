#这是一个正常的递归
def recsum(x):
    if x == 0:
        return x
    else:
        return x + recsum(x)

#running process
# recsum(5)
# 5 + recsum(4)
# 5 + (4 + recsum(3))
# 5 + (4 + (3 + recsum(2)))
# 5 + (4 + (3 + (2 + recsum(1))))
# 5 + (4 + (3 + (2 + 1)))
# 5 + (4 + (3 + 3))
# 5 + (4 + 6)
# 5 + 10
# 15

#这是一个普通的迭代
def sum(x):
    for i in range(6):
        sum += i


#这是一个普通的尾递归
def tailrecsum(x,running_total =0):
    if x == 0:
        return running_total
    else:
        return tailrecsum(x -1,running_total + x)

# tailrecsum(5,0)
# tailrecsum(4,5)
# tailrecsum(3,9)
# tailrecsum(2,12)
# tailrecsum(1,14)
# tailrecsum(0,15)
    
                

