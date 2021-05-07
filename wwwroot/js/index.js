"use strict";

function uploadFile() {
    if (window.FormData !== undefined) {

        var fileUpload = $("#fileToUpload").get(0);
        var files = fileUpload.files;
        var fileData = new FormData();
 
        for (var i = 0; i < files.length; i++) {
            fileData.append(files[i].name, files[i]);
        }

        $.ajax({
            url: '/NormalUser/Home/FormPost',
            type: "POST",
            contentType: false,   
            processData: false, 
            data: fileData,
            success: function (result) {
                if (result.success) {
                    alert("File uploaded successfully..");
                }
                else {
                    alert(result.errorMessage);
                }
            }
        });
    } else {
        alert("FormData is not supported.");
    }  
}