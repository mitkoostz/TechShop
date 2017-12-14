

function NameValidation(name) {

    var mass = name.trim().split(' ');
    if (mass.length < 2 ) {
        return false;
    }
    return true;
};

function phonenumberValidation(inputtxt) {
    var phoneno = /^\d{10}$/;
    if (inputtxt.match(phoneno))  
        {  
        return true;
    }  
      else  
    {
        return false;
    }
}

function Validation() {

    var name = $("#fullName").val();
    var phonenumber = $("#mobilePhone").val();

    if (!phonenumberValidation(phonenumber) || !NameValidation(name)) {

        return false;
    }

    return true;
}

$("#Purchase_Finish_btn").click(function () {

   
    var nameFieldValue = $("#fullName").val();

    if ($("#fullName").val() == "") {
        $("#nameValidation").text("field is absolutly required!");
        $("#nameValidation").css("visibility", "visible");
    }

    if (!NameValidation(nameFieldValue) && $("#fullName").val() != "" ) {
        $("#nameValidation").text("Incorrect Name");
        $("#nameValidation").css("visibility", "visible");
    }
    if (NameValidation(nameFieldValue)) {
        $("#nameValidation").css("visibility", "hidden");
    }

    var phone = $("#mobilePhone").val();
    if (!phonenumberValidation(phone)) {
        $("#phoneValidation").text("Incorrect phone number");
        $("#phoneValidation").css("visibility", "visible");
    } else
    {
        $("#phoneValidation").css("visibility", "hidden");

    }


    


});

