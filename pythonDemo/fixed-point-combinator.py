def func(x, f):
	if x <= 1:
		return 1
	else:
		return x * f(x-1)

def fix(f):
	return lambda x: f(x, fix(f))

fact = fix(func)

print(fact(5))