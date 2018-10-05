var output = '';
var j = 1;

var houses = JSON5.parse(houses);

for (var i = 0; i < houses.length; i++)
{
    output += j + ". Name  :  " + houses[i].plot + ",     cost   :  " + houses[i].cost + '<br>';
    j++;
}
document.getElementsByName('houses').innerHTML = output;