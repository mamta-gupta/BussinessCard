/// <reference path="C:\BussinessCard\BussinessCard.Web\Scripts/jquery-1.10.2.min.js" />


function testRow(rowID) {
    alert(rowID);
}


$(function () {
    var myData = [{
        id: "10",
        invdate: "2015-10-01",
        name: "test",
        amount: ""
    }, {
        id: "20",
        invdate: "2015-09-01",
        name: "test2",
        amount: "300.00",
        tax: "20.00",
        closed: false,
        ship_via: "FE",
        total: "320.00"
    }, {
        id: "30",
        invdate: "2015-09-01",
        name: "test3",
        amount: "400.00",
        tax: "30.00",
        closed: false,
        ship_via: "FE",
        total: "430.00"
    }, {
        id: "40",
        invdate: "2015-10-04",
        name: "test4",
        amount: "200.00",
        tax: "10.00",
        closed: true,
        ship_via: "TN",
        total: "210.00"
    }, {
        id: "50",
        invdate: "2015-10-31",
        name: "test5 this is some dummay data",
        amount: "300.00",
        tax: "20.00",
        closed: false,
        ship_via: "FE",
        total: "320.00"
    }, {
        id: "60",
        invdate: "2015-09-06",
        name: "test6",
        amount: "400.00",
        tax: "30.00",
        closed: false,
        ship_via: "FE",
        total: "430.00"
    }, {
        id: "70",
        invdate: "2015-10-04",
        name: "test7",
        amount: "200.00",
        tax: "10.00",
        closed: true,
        ship_via: "TN",
        total: "210.00"
    }, {
        id: "80",
        invdate: "2015-10-03",
        name: "test8",
        amount: "300.00",
        tax: "20.00",
        closed: false,
        ship_via: "FE",
        total: "320.00"
    }, {
        id: "90",
        invdate: "2015-09-01",
        name: "test9",
        amount: "400.00",
        tax: "30.00",
        closed: false,
        ship_via: "TN",
        total: "430.00"
    }, {
        id: "100",
        invdate: "2015-09-08",
        name: "test10",
        amount: "500.00",
        tax: "30.00",
        closed: true,
        ship_via: "TN",
        total: "530.00"
    }, {
        id: "110",
        invdate: "2015-09-08",
        name: "test11",
        amount: "500.00",
        tax: "30.00",
        closed: false,
        ship_via: "FE",
        total: "530.00"
    }, {
        id: "120",
        invdate: "2015-09-10",
        name: "test12",
        amount: "500.00",
        tax: "30.00",
        closed: false,
        ship_via: "FE",
        total: "530.00"
    }]

    var myColModel = [{
        name: "name",
        label: "Client",
        width: 53
    }, {
        name: "invdate",
        label: "Date",
        width: 75,
        align: "center",
        sorttype: "date",
        formatter: "date",
        formatoptions: {
            newformat: "d-M-Y"
        }
    }, {
        name: "amount",
        label: "Amount",
        width: 65,
        template: "number"
    }, {
        name: "tax",
        label: "Tax",
        width: 55,
        formatter: "currency",
        formatoptions: { decimalSeparator: ",", thousandsSeparator: ",", decimalPlaces: 2, prefix: "$ " },
        template: "number"
    }, {
        name: "total",
        label: "Total",
        width: 51,
        template: "number"
    }, {
        name: "closed",
        label: "Closed",
        width: 59,
        template: "booleanCheckboxFa",
        firstsortorder: "desc"
    }, {
        name: "ship_via",
        label: "Shipped via",
        width: 87,
        align: "center",
        editable: true,
        formatter: "select",
        edittype: "select",

        editoptions: {
            value: "FE:FedEx;TN:TNT;DH:DHL",
            defaultValue: "DH"
        }
    },
     {
         name: "",
         label: "Shop",
         width: 50,
         align: "center",
         template: "string",
         editable: false,
         formatter: function (cellvalue, options, rowObject) {

             var optionsRowId = options.rowId;
             return "<input type='button' style=\"background-color:lightgreen;color:black\" value='+'   onclick=\"javascript:testRow('" + rowObject.ship_via + "')\" \>";
         }
     },
     {
         name: "",
         label: "Edit Currency/Quantity",
         width: 87,
         align: "center",
         formatter: "actions",
         formatoptions: {
             keys: true,
             editformbutton: false //Determines if popup should open or not
         }
     }]


    $("#tblBusinessCardDetails").jqGrid({

        colModel: myColModel,
        gridview: true,
        'cellEdit': false,
        editable: false,
        height: 'auto',
        data: myData,
        pageable: true,
        autorowheight: true,
        autoheight: true,
        altrows: true,
        edit: {
            recreateFrom: true
        },
        rowNum: 7,
        rowList: [3, 6],
        pager: "#businessCardJqGridPager",
        rownumbers: true,
        sortname: "invdate",

        sortorder: "desc",
        caption: "My Caption",
        loadComplete: function () {
        }
    });
});
