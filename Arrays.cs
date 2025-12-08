// -----------------------
// C# Arrays
// -----------------------

// Declare an array
string[] cars;

// Add values, using new
cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// or
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, 
// and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

cars[0] = "Opel";

Console.WriteLine(cars[0]); // "Opel"
Console.WriteLine(cars.Length) // 4

int[] myNum = {10, 20, 30, 40};

// -----------------------
// Multidimensional Arrays
// -----------------------

// The single comma [,] specifies that the array is two-dimensional. 
// A three-dimensional array would have two commas: int[,,].

int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
Console.WriteLine(numbers[0, 2]);  // Outputs 2

numbers[0, 0] = 5;  // Change value to 5
Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

//---------------------------------------------------------------------------------------------------

// -----------------------
// C++ Arrays
// -----------------------

string cars[4];
string cars[4] = {"Volvo", "BMW", "Ford", "Mazda"};
// Outputs Volvo
cout << cars[0];

int myNum[3] = {10, 20, 30};

string cars[] = {"Volvo", "BMW", "Ford"}; // Three array elements
string cars[3] = {"Volvo", "BMW", "Ford"}; // Also three array elements

// The example above only works when you have specified the size of the array.
string cars[5];
cars[0] = "Volvo";
cars[1] = "BMW";
cars[2] = "Ford";
cars[3] = "Mazda";
cars[4] = "Tesla";

// Fixed size arrays

// An array with 3 elements
string cars[3] = {"Volvo", "BMW", "Ford"};

// Trying to add another element (a fourth element) 
// to the cars array will result in an error
cars[3] = "Tesla";

// Vectors

// A vector with 3 elements
vector<string> cars = {"Volvo", "BMW", "Ford"};

// Adding another element to the vector
cars.push_back("Tesla");

int myNumbers[5] = {10, 20, 30, 40, 50};
cout << sizeof(myNumbers); // 20 (4 bytes x 5 elements) = 20 bytes.

// To find out how many elements an array has, 
// you have to divide the size of the array by the size of 
// the first element in the array:
int getArrayLength = sizeof(myNumbers) / sizeof(myNumbers[0]);
cout << getArrayLength; // 5


int myNumbers[5] = {10, 20, 30, 40, 50};
for (int i = 0; i < 5; i++) {
  cout << myNumbers[i] << "\n";
}

int myNumbers[5] = {10, 20, 30, 40, 50};
for (int i = 0; i < sizeof(myNumbers) / sizeof(myNumbers[0]); i++) {
  cout << myNumbers[i] << "\n";
}

// in C++ version 11 (2011), you can also use the "for-each" loop, 
// which is even cleaner and simpler:

int myNumbers[5] = {10, 20, 30, 40, 50};
for (int num : myNumbers) {
  cout << num << "\n";
}

// -----------------------
// Multidimensional Arrays
// -----------------------

string letters[2][4];

string letters[2][4] = {
  { "A", "B", "C", "D" },
  { "E", "F", "G", "H" }
};

cout << letters[0][2];  // Outputs "C"

letters[0][0] = "Z";
cout << letters[0][0];  // Now outputs "Z" instead of "A"

for (int i = 0; i < 2; i++) {
  for (int j = 0; j < 4; j++) {
    cout << letters[i][j] << "\n";
  }
}


string letters[2][2][2] = {
  {
    { "A", "B" },
    { "C", "D" }
  },
  {
    { "E", "F" },
    { "G", "H" }
  }
};

for (int i = 0; i < 2; i++) {
  for (int j = 0; j < 2; j++) {
    for (int k = 0; k < 2; k++) {
      cout << letters[i][j][k] << "\n";
    }
  }
}

// We put "1" to indicate there is a ship.
bool ships[4][4] = {
  { 0, 1, 1, 0 },
  { 0, 0, 0, 0 },
  { 0, 0, 1, 0 },
  { 0, 0, 1, 0 }
};


// Keep track of how many hits the player has and how many turns they have played in these variables
int hits = 0;
int numberOfTurns = 0;

// Allow the player to keep going until they have hit all four ships
while (hits < 4) {
  int row, column;

  cout << "Selecting coordinates\n";

  // Ask the player for a row
  cout << "Choose a row number between 0 and 3: ";
  cin >> row;

  // Ask the player for a column
  cout << "Choose a column number between 0 and 3: ";
  cin >> column;

  // Check if a ship exists in those coordinates
  if (ships[row][column]) {
    // If the player hit a ship, remove it by setting the value to zero.
    ships[row][column] = 0;

    // Increase the hit counter
    hits++;

    // Tell the player that they have hit a ship and how many ships are left
    cout << "Hit! " << (4-hits) << " left.\n\n";
  } else {
    // Tell the player that they missed
    cout << "Miss\n\n";
  }

  // Count how many turns the player has taken
  numberOfTurns++;
}

cout << "Victory!\n";
cout << "You won in " << numberOfTurns << " turns";


//---------------------------------------------------------------------------------------------------

// -----------------------
// JavaScript Arrays
// -----------------------

const cars = [];

const cars = ["Saab", "Volvo", "BMW"];

const cars = new Array("Saab", "Volvo", "BMW");

let car = cars[0];
cars[0] = "Opel";

let last = cars[cars.length - 1]; // BMW

cars.length   // Returns the number of elements
cars.sort()   // Sorts the array


// Arrays are a special type of objects. 
// The typeof operator in JavaScript returns "object" for arrays.
// Arrays use numbers to access its "elements". 
// In this example, person[0] returns John:

const person = ["John", "Doe", 46];

// Objects use names to access its "members". 
// In this example, person.firstName returns John:

const person = { firstName:"John", lastName:"Doe", age:46 };

// -----------------------
// Associative Arrays
// -----------------------

// Arrays with named indexes are called associative arrays (or hashes).
// JavaScript does not support arrays with named indexes.
// In JavaScript, arrays always use numbered indexes. 
// If you use named indexes, JavaScript will redefine the array to an object.
// After that, some array methods and properties will produce incorrect results.

// In JavaScript, arrays use numbered indexes.  
// In JavaScript, objects use named indexes.


const myObj = {
  name: "John",
  age: 30,
  cars: [
    {name:"Ford", models:["Fiesta", "Focus", "Mustang"]},
    {name:"BMW", models:["320", "X3", "X5"]},
    {name:"Fiat", models:["500", "Panda"]}
  ]
}

for (let i in myObj.cars) {
  x += "<h1>" + myObj.cars[i].name + "</h1>";
  for (let j in myObj.cars[i].models) {
    x += myObj.cars[i].models[j];
  }
}

// -----------------------
// Multidimensional Arrays
// -----------------------

// Example of a 2D array (matrix)
const matrix = [
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9]
];

// Accessing an element in a 2D array
let element = matrix[1][2]; // This will access the element '6' (row 1, column 2)
console.log(element); // Output: 6

for (let i = 0; i < matrix.length; i++) {
  for (let j = 0; j < matrix[i].length; j++) {
    console.log(matrix[i][j]);
  }
}

// Example of a 3D array (cube)
const cube = [
  [
    [1, 2],
    [3, 4]
  ],
  [
    [5, 6],
    [7, 8]
  ]
];

// Accessing an element in a 3D array
let cubeElement = cube[0][1][0]; // This will access the element '3' (layer 0, row 1, column 0)
console.log(cubeElement); // Output: 3
