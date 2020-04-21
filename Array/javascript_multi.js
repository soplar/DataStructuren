// https://www.javascripttutorial.net/javascript-multidimensional-array/
// https://www.geeksforgeeks.org/multidimensional-array-in-javascript/
var eredivisie =[
    ['eindhoven', 'psv'],
    ['amsterdam', 'ajax'],
    ['rotterdam', 'feyenoord']
];
console.log(eredivisie);
console.log('----------------------');
// eentje erbij (onderaan)
eredivisie.push(['alkmaar', 'AZ']);
console.log(eredivisie);
console.log('----------------------');
// specifiek
console.log(eredivisie[0][1]); //psv
console.log('----------------------');
// en een club degradeert
// pop met nr verwijdert enkel het item in sub array
// eredivisie[1].pop();
// delete verwijdert sub array maar laat ruimte bestaan
// delete eredivisie[1];
// pop verwijdert altijd de laatste
eredivisie.pop();
console.log(eredivisie.length);
console.log(eredivisie);
console.log('----------------------');
// met filter maken we een nieuwe array met de gewenste sub arrays
var eredivisie2 = eredivisie.filter(function(item){ return item[1] != 'ajax' });
console.log(eredivisie2);
console.log('----------------------');
