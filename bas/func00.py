from PIL import Image
import math

# Image settings (based on SCREEN 7 resolution: 320x200)
width, height = 320, 200
img = Image.new("RGB", (width, height), "black")
pixels = img.load()

def compute(x, y):
    r = math.sqrt(x*x + y*y) * 1.5
    if r == 0:
        f = 90
    else:
        f = abs(90 * math.sin(r) / r)

    a = int(10*x + 160 - 5*y)
    b = int(5*y + 2.5*x + 93)

    print(a, b, f)
    return a, b, f

for y in [i * 0.2 - 10 for i in range(int(20/0.2) + 1)]:
    for x in [i * 0.3 - 10 for i in range(int(20/0.3) + 1)]:
        a, b, f = compute(x, y)

        # BASIC: PSET(A, B - F), 15   where color 15 is white
        px = int(a)
        py = int(b - f)

        if 0 <= px < width and 0 <= py < height:
            pixels[px, py] = (255, 255, 255)  # color 15 → white

# Save the output
img.save("output.png")
img.show()


# 0 SCREEN 7 : GOTO 10
# 1 R=SQR(X*X+Y*Y)*1.5 : IF R=0 THEN F=90: GOTO 3
# 2 F=ABS(90*SIN(R)/R)
# 3 A=INT(10*X+160-5*Y)
# 4 B=INT(5*Y+2.5*X+93)
# 5 RETURN
# 10 FOR Y=-10 TO 10 STEP 0.2
# 30 FOR X=-10 TO 10 STEP 0.3
# 40 GOSUB 1
# 46 if A < 279 then HPLOT A, B-F
# 50 NEXT X
# 60 NEXT Y
