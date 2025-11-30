import math
import matplotlib.pyplot as plt

# Compute point for given X,Y (converted function from BASIC)
def compute(x, y):
    r = math.sqrt(x*x + y*y) * 1.5
    if r == 0:
        f = 90
    else:
        f = abs(90 * math.sin(r) / r)

    a = 10*x + 160 - 5*y
    b = 5*y + 2.5*x + 93

    return a, b - f  # BASIC plots at (A, B - F)

# Store all points
xs = []
ys = []

# BASIC loops:
# FOR Y = -10 TO 10 STEP 0.2
# FOR X = -10 TO 10 STEP 0.3
y = -10
while y <= 10:
    x = -10
    while x <= 10:
        a, b = compute(x, y)
        xs.append(a)
        ys.append(b)
        x += 0.3
    y += 0.2

# Plot using matplotlib
plt.figure(figsize=(8, 5))
plt.scatter(xs, ys, s=1, color='white')
plt.gca().set_facecolor('black')
plt.gca().invert_yaxis()   # Match old graphics screen coordinate direction
plt.title("BASIC Program Output (Matplotlib Version)")
plt.axis("equal")
plt.show()
