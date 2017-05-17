﻿//$(document).ready(function () {

//    function exportTableToCSV($table, filename) {

//        var $rows = $table.find('tr:has(td)'),


//            tmpColDelim = String.fromCharCode(11), 
//            tmpRowDelim = String.fromCharCode(0), 

//            // actual delimiter characters for CSV format
//            colDelim = '","',
//            rowDelim = '"\r\n"',

//            // Grab text from table into CSV formatted string
//            csv = '"' + $rows.map(function (i, row) {
//                var $row = $(row),
//                    $cols = $row.find('td');

//                return $cols.map(function (j, col) {
//                    var $col = $(col),
//                        text = $col.text();

//                    return text.replace(/"/g, '""'); // escape double quotes

//                }).get().join(tmpColDelim);

//            }).get().join(tmpRowDelim)
//                .split(tmpRowDelim).join(rowDelim)
//                .split(tmpColDelim).join(colDelim) + '"',

//            // Data URI
//            csvData = 'data:application/csv;charset=utf-8,' + encodeURIComponent(csv);

//        $(this)
//            .attr({
//                'download': filename,
//                'href': csvData,
//                'target': '_blank'
//            });
//    }


//    $(".export").on('click', function (event) {
//        // CSV
//        exportTableToCSV.apply(this, [$('#dvData>table'), 'export.csv']);


//    });
//});

$(document).ready(function () {
    $("#btnExport").click(function (e) {
        window.open('data:application/vnd.ms-excel,' + encodeURIComponent($('div[id$=dvData]').html()));
        e.preventDefault();
    });
});