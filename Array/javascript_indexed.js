// https://www.w3schools.com/js/js_arrays.asp
var cars = ["Saab", "Volvo", "BMW"];
// of var cars = new Array("Saab", "Volvo", "BMW");
var name = cars[0];
console.log(name);
// tonen in html
// document.getElementById("demo").innerHTML = cars[0];

// Arrays zijn een speciaal type van objecten.
// Array elementen kunnen objecten zijn.
function myFunction(){
    console.log('een boodschap vanuit de functie...');
    return 'en nog wat tekst';
}

var myArray = [];
myArray[0] = Date.now;
myArray[1] = myFunction;
myArray[2] = cars;

console.log(myArray[0]);
console.log(myArray[0]());
console.log(myArray[1]);
console.log(myArray[1]());
console.log(myArray[2]);

// je kunt allerlei properties en methods gebruiken bijv:
var number_of_cars = cars.length;
console.log(number_of_cars);