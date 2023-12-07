function alertQuestion(mensaje, btnSuccess, btnCancel) {
    Swal.fire({
        title: mensaje,
        showDenyButton: true,
        confirmButtonText: btnSuccess,
        denyButtonText: btnCancel
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire("Exito!", "", "success");
        } else if (result.isDenied) {
            Swal.fire("Cancelado", "", "info");
        }
    });
}

function getMensajeFromBD() {

    var id = 1
    var jsdata = '{param:' + id + '}';
    console.log(jsdata)
    $.ajax({
        type: "POST",
        url: "Nuevo.aspx/GetResponseFromBD",
        contentType: "application/json; charset=utf-8",
        data: jsdata,
        dataType: "json",
        success: function (response) {
            console.log(response)
            console.log(response.d)

            var respuesta = response.d[0]

            alertQuestion(respuesta.Mensaje, respuesta.BtnPrincipal, respuesta.BtnSecundario)
        }
    });

}

function getMensajeFromInput() {

    var Mensaje = document.getElementById('MainContent_TXT_MENSAJE').value;
    var BtnPrincipal = document.getElementById('MainContent_TXT_PRINCIPAL').value;
    var BtnSecundario = document.getElementById('MainContent_TXT_SECUNDARIO').value;

    var jsdata = `{Mensaje:'${Mensaje}', BtnPrincipal:'${BtnPrincipal}',BtnSecundario:'${BtnSecundario}'}`;
    console.log(jsdata)

    $.ajax({
        type: "POST",
        url: "Nuevo.aspx/GetResponseFromInput",
        contentType: "application/json; charset=utf-8",
        data: jsdata,
        dataType: "json",
        success: function (response) {

            var respuesta = response.d

            alertQuestion(respuesta.Message, respuesta.BtnSuccess, respuesta.BtnCancel)
        }
    });

}

function getStringFromBusiness() {

    var id = 1
    var jsdata = '{param:' + id + '}';

    $.ajax({
        type: "POST",
        url: "Nuevo.aspx/GetResponseTestString",
        contentType: "application/json; charset=utf-8",
        data: jsdata,
        dataType: "json",
        success: function (response) {

            var respuesta = response.d

            Swal.fire(respuesta, "", "success");

        }
    });

}

function GetResponseBool() {
    fetch('Nuevo.aspx/GetResponseTestBool', {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        },
    })
        .then(response => response.json())
        .then(data => {
            console.log(data)
        })
        .catch(error => {
            console.error('Error:', error);
        });
}

function callServer() {
    var someValueToPass = 'Hello server';
    __doPostBack('NombreControl', someValueToPass);
}
