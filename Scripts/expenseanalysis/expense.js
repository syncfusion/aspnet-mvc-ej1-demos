function changeMonth(sender) {
        $(".add-filter-panel").ejWaitingPopup();
        $(".add-filter-panel").ejWaitingPopup("show");
        UpdateGridChart(sender.selectedText);    
}

$(function () {
    $(document).ready(function () {
        $('#selectMonth').data("ejDropDownList").selectItemByText("January");
    });
});

$(document).on("click", ".add-image", function () {
    var gridObj = $("#grid").ejGrid("instance");
    gridObj.addRecord(); //adding new record in grid 
	$("#grid_dialogEdit").ejDialog({isResponsive:true});	
});

// Updating the grid and chart contents
function UpdateGridChart(month) {
    var dataManger = ej.DataManager({
        url: "http://js.syncfusion.com/ejServices/api/expense/get?month=" + month,
        offline: true,
        requiresFormat: false, crossDomain: true
    });
    dataManger.ready.done(function (e) {
        $("#grid").ejGrid({
            dataSource: e.result[1]
        });

        $("#chart").ejChart({
            series: [{
                dataSource: e.result[0],
                type: 'pie',
                name: "ExpenseChart",
                enableAnimation: true,
                labelPosition: 'outside',
                marker: { connectorLine: { height: 20 }, dataLabel: { visible: true, } },
                border: { width: 1 },
                explode: true,
                xName: "ExpenseCategory",
                yName: "Amount"
            }]
        });
        $('.pos-amt').html("$" + formatNumber(parseInt(e.result[5])));
        $('.neg-amt').html("$" + formatNumber(parseInt(e.result[6])));
        $('.bal-amt').html("$" + formatNumber(parseInt(e.result[7])));
        $('.most-spent-amt').html(e.result[2]);
        $('.least-spent-amt').html(e.result[3]);
        $('.avg-spent-amt').html(e.result[4]);
        $('.pos-transc').html(e.result[8] + " Transactions");
        $('.neg-transc').html(e.result[9] + " Transactions");
        window.chartDS = e.result[0];
        window.Home = e.result[10];
        window.DailyLiving = e.result[11];
        window.Entertainment = e.result[12];
        window.Health = e.result[13];
        window.Transportation = e.result[14];
        window.Personal = e.result[15];
        $(".add-filter-panel").ejWaitingPopup("hide");
    });
}

function formatNumber(number) {
    return ej.format(number, "n0"); //formating numbers  for spent amounts
}
function seriesRender(e) {
    //Adding text to the series points to chart     
    $.each(e.model.series[0].points, function () {
        this.text = this.x + "- $" + formatNumber(parseInt((this.YValues)));         
    });   
}
function btnClick(sender) {
    $("#chart").ejChart("option", { "drilldown": pieSeries() });
    $("#btnBack").hide();
}
function onClick(sender) {
    var isIe8 = ej.browserInfo().name == "msie" && parseInt(ej.browserInfo().version) == 8;
    //Rendering drilldown dhart based on the points clicked
    if (sender.model.AnimationComplete || isIe8) {
        var index = sender.data.region.Region.PointIndex;
        var name = sender.model.series[0].points[index].x;
        if (sender.model.series[0].name == "ExpenseChart")
            $("#chart").ejChart("option", { "drilldown": pieSeries(name) });
        if (isIe8)
            $("#btnBack").show();
    }
}   

function completeAnimation(sender) {
    //show or hide back button based on the series name
    if (sender.model.series[0].name != "ExpenseChart")
        $("#btnBack").show();
    else
        $("#btnBack").hide();
}
function genarateSeries(sName) {
    var seriesData = {
        series: [{
            dataSource: window[sName],
            xName: "ExpenseCategory",
            yName: "Amount",
            type: 'pie',
            labelPosition: 'outside',
            pieCoefficient: 0.8,
            enableAnimation: true,
            explode: false,
            marker: {
                dataLabel: {
                    visible: true,
                    shape: 'none',
                    connectorLine: { color: 'black', width: 0.5 },
                    font: { fontFamily: 'Segoe UI', fontStyle: 'Normal ', fontWeight: 'Regular', size: '12px', color: '#707070', opacity: 1 }
                }
            }

        }],
        legend: { visible: false },
    }
    return seriesData;
}

function pieSeries(seriesName) {
    //Choosing the series points based on the series name to drilldown chart
    switch (seriesName) {
    case "Home":
        return genarateSeries(seriesName);
        break;
    case "Entertainment":
        window.Entertainment[1].Amount = 45;
        return genarateSeries(seriesName);
        break;
    case "Daily Living":
        return genarateSeries("DailyLiving");
        break;
    case "Health":
        return genarateSeries(seriesName);
        break;
    case "Transportation":
        return genarateSeries(seriesName);
        break;
    case "Personal":
        return genarateSeries(seriesName);
        break;
    default:
    {
        return {
            series: [
                {
                    name: "ExpenseChart",
                    dataSource: window.chartDS,
                    xName: "ExpenseCategory",
                    yName: "Amount",
                    type: 'pie',
                    labelPosition: 'outside',
                    pieCoefficient: 0.8,
                    explode: true,
                    explodeOffset: 25,
                    enableAnimation: true,
                    AnimationComplete: false,
                    marker: {
                        dataLabel: {
                            visible: true,
                            shape: 'none',
                            connectorLine: { color: null, width: 0.5 },
                            font: { fontFamily: 'Segoe UI', fontStyle: 'Normal ', fontWeight: 'Regular', size: '12px', color: '#707070', opacity: 1 }
                        }
                    }
                }
            ],
            legend: { visible: false },
            AnimationComplete: false
        };
    }
    }
}
