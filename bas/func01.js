'use strict';

const fs = require('node:fs');

function compute(x, y) {
  // R = SQR(X*X+Y*Y)*1.5
  const r = Math.sqrt(x * x + y * y) * 1.5;

  // IF R=0 THEN F=90 ELSE F=ABS(90*SIN(R)/R)
  let f;
  if (Math.abs(r) < 1e-9) {
	f = 90;
  } else {
	f = Math.abs(90 * Math.sin(r) / r);
  }

  // A = INT(10*X + 160 - 5*Y)
  // B = INT(5*Y + 2.5*X + 93)
  const a = Math.trunc(10 * x + 160 - 5 * y);
  const b = Math.trunc(5 * y + 2.5 * x + 93);

  return { a, b, f };
}
let points = [];
let content = ""

// FOR Y=-10 TO 10 STEP 0.2
// FOR X=-10 TO 10 STEP 0.3
for (let y = -10; y <= 10 + 1e-9; y += 0.2) {
  for (let x = -10; x <= 10 + 1e-9; x += 0.3) {
	const { a, b, f } = compute(x, y);

	// BASIC: PSET (A, B - F), 15
	const px = a;
	const py = Math.trunc(b - f);

	// Clip to canvas bounds (SCREEN 7 is 320x200)
	if (px >= 0 && px < 320 && py >= 0 && py < 200) {
	  //console.log(px, py);
	  //points.push([px, py]);
	  content += `${px}, ${py}\n`
	}
  }
}
console.log("points", points.length);

fs.writeFile('./points.txt', content, err => {
  if (err) {
    console.error(err);
  } else {
    // file written successfully
  }
});
