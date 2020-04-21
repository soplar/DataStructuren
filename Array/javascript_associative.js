// javascript heeft geen associatieve arrays
// arrays gebruiken altijd genummerde index
var person = [];
person[0] = "John";
person[1] = "Doe";
person[2] = 46;
var x = person.length;     // person.length geeft 3
var y = person[0];         // person[0] geeft "John"
// check of je met array te maken hebt
console.log(Array.isArray(person));

// als je toch associatief probeert te maken
// dan maakt javascript er een standaard object van
var person2 = [];
person2["firstName"] = "John";
person2["lastName"] = "Doe";
person2["age"] = 46;
var x = person2.length;     // person2.length geeft 0
var y = person2[0];         // person2[0] geeft undefined
console.log(x);

console.log(Array.isArray(person2)); // wordt toch gezien als array
console.log(person2.firstName); // maar het is een object

// Dus gebruik objects als de naam van je element een tekst moet zijn
// gebruik arrays als de naam van je element een getal is
var person3 = {};
person3["firstName"] = "John";
person3["lastName"] = "Doe";
person3["age"] = 46;
console.log(person3.lastName);
console.log(Array.isArray(person3));
console.log(typeof person3 === 'object');
