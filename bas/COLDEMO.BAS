10 SCREEN 0 : COLOR 15,4,13
15 WIDTH 80 : CLS
20 FOR BG = 0 TO 7    ' Background
30   FOR FG = 0 TO 15 ' Foreground
40     COLOR FG,BG
50     PRINT "Maker Space! ";
60   NEXT FG
70 NEXT BG
80 COLOR 15,4