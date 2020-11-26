// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
//url: @Url.Action("GetByDate", "Invoices", new {dt}),
//url: 'https://localhost:44328/invoices/GetByDate/' + dt,
// Write your JavaScript code.
//$(document).ready(function () {

    
//    $("#form").submit(function () {
//        alert("Invoice successfully created");
//    });
    
//    $("#filterDate").datepicker({
        
//        onSelect: function () {


            

//            var filterString = new Date($("#filterDate").val());
//            var filterDate = filterString.toISOString();
//            alert(filterDate);
//            if (filterDate != null) {
//                var dt = filterDate;
//            }

           


//            $.ajax({
//                type: 'GET',
//                url: 'https://localhost:44328/invoice/GetByDate/' + { dt },
//                data: dt,
//                success: function (response) {
//                    $("#table").html(response);

//                },
//                error: function () {
//                    alert("failed");
//                }

//            })
//        }

//    })
    


//});
















// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
//url: @Url.Action("GetByDate", "Invoices", new {dt}),
//url: 'https://localhost:44328/invoices/GetByDate/' + dt,
// Write your JavaScript code.
$(document).ready(function () {

    //$("#filterDate").mouseup(function () {

    //    $("#filterDate").datepicker('setDate', new Date());
    //    alert("works");
    //});

    $("#filterDate").datepicker({

        onSelect: function () {



            var filterString = new Date($("#filterDate").val());
            var filterDate = filterString.toISOString();
            if (filterDate != null) {
                var dt = filterDate;
            }


            

            $.ajax({
                type: 'GET',
                url: 'https://localhost:44328/invoiceApp/GetByDate/' + filterDate,
                data: filterDate,
                success: function (response) {
                    $("#table").html(response);

                },
                error: function () {
                    alert("failed");
                }

            })


            // alert(date);
            //alert("hi");
            //  $("#filterDate").datepicker('setDate', new Date());
            //  alert($("#filterDate").datepicker('getDate'));

            //  var filterDate = $("#filterDate").datepicker('getDate');

            //  if (filterDate != null) {
            //      var dt = filterDate.toISOString();
            //  }

            ////  console.log($("#filterDate").datepicker('getDate').toISOString());


            //  $.ajax({
            //      type: 'GET',
            //      url: 'https://localhost:44328/invoices/GetByDate/' + dt,
            //      data: dt,
            //      success: function (response) {
            //          $("#table").html(response);

            //      },
            //      error: function () {
            //          alert("failed");
            //      }

            //  })



            //26/11/2020
            //2020-11-27T08:00:00.000Z
            // alert(dt+'gfd')
            // alert(date+'ju')
        }






        //$("#test").keyUp(function () {
        //    $.ajax({
        //            type: 'POST',
        //            url: 'https://localhost:44328/invoices/GetByDate',
        //            data: $("#test").val(),
        //            success: function () {
        //                alert("success")
        //            },
        //            error: function () {
        //                alert("failed");
        //            }

        //        })
        //});

    })//.on("change", function () {

    //    $("#filterDate").datepicker('setDate');
    //    alert($("#filterDate").datepicker('getDate'));

    //    var filterDate = $("#filterDate").datepicker('getDate');

    //    if (filterDate != null) {
    //        var dt = filterDate.toISOString();
    //    }

    //    //  console.log($("#filterDate").datepicker('getDate').toISOString());


    //    $.ajax({
    //        type: 'GET',
    //        url: 'https://localhost:44328/invoices/GetByDate/' + dt,
    //        data: dt,
    //        success: function (response) {
    //            $("#table").html(response);

    //        },
    //        error: function () {
    //            alert("failed");
    //        }

    //    })
    //    //26/11/2020
    //    //2020-11-27T08:00:00.000Z
    //    // alert(dt+'gfd')
    //    // alert(date+'ju')

    //});


    //$("#filterDate").click(function () {
    //    //alert("hello1");

    //    $("#filterDate").valueAsDate = new Date();
    //    $("#filterDate").blur(function () {
    //        alert($("#filterDate").val());
    //       // alert("hello")
    //    });
    //})



});