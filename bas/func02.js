/*
100 FOR Y=-10 TO 10 STEP 0.2
110 FOR X=-10 TO 10 STEP 0.3
120 R=SQR(X*X+Y*Y)*1.5
130 IF R=0 THEN F=90 : GOTO 130
140 F=ABS(90*SIN(R)/R)
150 A=INT(10*X+160-5*Y)
160 B=INT(5*Y+2.5*X+93)
170 IF A < 279 THEN HPLOT A, B-F
180 NEXT X
190 NEXT Y
*/
let result = [];
for (let y = -10; y <= 10; y += 0.2) {
  for (let x = -10; x <= 10; x += 0.3) {
    const r = Math.sqrt(x * x + y * y) * 1.5;
    let f=90;
    if (f !== 0) {
        f = Math.abs(90 * Math.sin(r) / r);
    }
    const a = Math.trunc(10 * x + 160 - 5 * y);
    const b = Math.trunc(5 * y + 2.5 * x + 93);
    const c = Math.trunc(b-f);
    result.push([a, b, c, f]);
  }
}
console.table(result);
