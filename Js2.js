{
    var colony = [
        { "firstname": "Raju", "lastname": "Parku" },
        { "firstname": "Bhuvanesh", "lastname": "Arveti" },
        { "firstname": "Ankur", "lastname": "Sharma" },
        { "firstname": "Mahesh", "lastname": "Vitta" }
       ]
}
var output = '';
      for (var i = 0; i < colony.length; i++)
      {
          output += '<li>'+"FirstName :  " + colony[i].firstname + ",   Last Name  :  " + colony[i].lastname+'</li>';
      }

      document.getElementById('html2').innerHTML = output;
