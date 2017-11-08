var root = 'https://jsonplaceholder.typicode.com';

$(function () { 
    loadUsers();

    //11. Listen for the "save" button to get clicked
    $("#save").on("click", saveButtonClick);
});

//12. Create the saveButtonClick function
function saveButtonClick(e) {

    //13. Get the field values
    var id = $("#id").val();
    var name = $("#name").val();
    var username = $("#username").val();
    var email = $("#email").val();

    //14. Send the PUT request
    $.ajax({
        url: root + '/users/' + id,
        method: 'PUT',
        data: {
            id: id,
            name: name,
            username: username,
            email: email
        }
    }).then(function (data) {
        //15. Hide the modal window (after response)
        $("#myModal").modal('hide'); //<-- bootstrap modal
        console.log(data);
    });

    
}

//1. Create the loadUsers function
function loadUsers() {
    //console.log('loading users...');
    //2. Make a Javascript request to load users
    $.ajax({
        url: root + '/users',
        method: 'GET'
    }).then(function (data) {
        console.log(data);

        //3. Find the table and clear it
        $("tbody").empty();
        for (var i = 0; i < data.length; i++) {
            //4. Create a table row and td for each
            //   piece of data we want to display

            var row = $("<tr>");
            var idCell = $(`<td>${data[i].id}</td>`);
            var nameCell = $(`<td>${data[i].name}</td>`);
            var usernameCell = $(`<td>${data[i].username}</td>`);
            var emailCell = $(`<td>${data[i].email}</td>`);

            //5. Append the td cell to the row
            row.append(idCell);
            row.append(nameCell);
            row.append(usernameCell);
            row.append(emailCell);

            //7. Attach a event handler for this row to 
            //   listen for "click" and call rowClick
            row.on("click", rowClick);

            //6. Append the row to the tbody
            $("tbody").append(row);
        }
    });
}

//8. Write the function to detect
//   which row was clicked and show the modal
function rowClick(e) {

    //9. Populate the fields
    var id = $(this).children().eq(0).text();
    var name = $(this).children().eq(1).text();
    var username = $(this).children().eq(2).text();
    var email = $(this).children().eq(3).text();

    //10. Populate the form fields with the values from above
    $("#id").val(id);
    $("#name").val(name);
    $("#username").val(username);
    $("#email").val(email);

    $("#myModal").modal();
}






