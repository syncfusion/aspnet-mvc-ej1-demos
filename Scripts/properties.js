

(function ($, ej, undefined) {

    // Example plugin creation code
    // sfSample is the plugin name 
    // "ej.Sample" is "namespace.className" will hold functions and properties

    ej.widget("ejPropertiesPanel", "ej.PropertiesPanel", {
         _rootCSS: "e-prop",
        // default model
        element: null,
        model: null,
        header:"Properties",
        defaults: {
            delayRender: true
        },
		// constructor function
        _init: function () {
            if (ej.browserInfo().name == "msie" && this.model.delayRender) {
                var proxy = this;
                setTimeout(function () { proxy._initialize(); }, 0);
            }
			else this._initialize();
        },
        _initialize: function () {
            this._sfPropertiesPanel = this.element.wrap('<div class="cols-prop-area" />');
            this._sfPropertyTitlebar = ej.buildTag("div.heading").prependTo(this.element);
            ej.buildTag("span", this.header).appendTo(this._sfPropertyTitlebar);          
            this.element.find(".heading").next().addClass("content");
            if (window.theme == "bootstrap") $(".e-prop").addClass("e-bootstrap");
        },
      
        hide: function () {
            var panel = this._sfPropertiesPanel;
            this._setSize();
            this._setPosition();
            panel.css({ display: "none" });
            return this;
        },
        _setModel: function () {
        },
        _setPosition: function () {
            if ($(document).find(".samplesection").length > 0) {
                this._sfPropertiesPanel.appendTo(".samplesection");
            }
            //var x = ($(this._sfPropertiesPanel).prev().width()+25);
            //this._sfPropertiesPanel.css({ left: x });            
        },
        // all events bound using this._on will be unbind automatically
        _destroy: function () {

        }
    });

})(jQuery, Syncfusion);

// For convert widgets
$(function () {
    convertWidgets();	
    if ($(".cols-sample-area").next('div').length==0)
        $(".cols-sample-area").css("width","100%");
});


var theme = window.theme;


//updateThemess(QueryString["theme"]);

function loadTheme(sender) {
    if (!ej.util.isNullOrUndefined(window.orientation) && sender && ($('.e-datavisualization-chart').length > 0)) {    	//to modify chart properties for mobile view
		var model = sender.model,
		seriesLength = model.series.length;
		model.title.enableTrim = true;
		model.elementSpacing = 5;
		model.legend.visible = false;
		model.size.height = null;
		model.size.width = null;
		for (var i=0; i< seriesLength; i++){
			if (!model.series[i].marker)
				model.series[i].marker = {};
            if (!model.series[i].marker.size)
				model.series[i].marker.size = {};							
			model.series[i].marker.size.width = 6;
			model.series[i].marker.size.height = 6;
		}
		model.primaryXAxis.labelIntersectAction = "rotate45";
		if (model.primaryXAxis.title)
		    model.primaryXAxis.title.text = "";
		model.primaryXAxis.edgeLabelPlacement = "hide";
		model.primaryYAxis.labelIntersectAction = "rotate45";
		if (model.primaryYAxis.title)
		    model.primaryYAxis.title.text = "";
		model.primaryYAxis.edgeLabelPlacement = "hide";			
		if (model.axes) {
			for (var j=0; j< model.axes.length; j++){
				model.axes[j].labelIntersectAction = "rotate45";
				if (model.axes[j].title)
				   model.axes[j].title.text = "";
				model.axes[j].edgeLabelPlacement = "hide";
			}
		}
	}
	
    var theme = window.theme;
    if (theme) {
        switch (theme) {
            case "flatdark":
            case "azuredark":
            case "limedark":
            case "saffrondark":
                theme = "flatdark";
                break;
            case "gradient":
            case "gradientazure":
            case "gradientlime":
            case "gradientsaffron":
                theme = "gradientlight";
                break;
            case "gradientdark":
            case "gradientazuredark":
            case "gradientlimedark":
            case "gradientsaffrondark":
                theme = "gradientdark";
                break;
			case "high-contrast-01":
			case "high-contrast-02":
				theme = "highcontrast01";
				break;
			case "material":
				theme = "material";
				break;
			case "office-365":
				theme = "office-365"
				break;	
            default:
                theme = "flatlight";
                break;
        }
        if (sender)
        sender.model.theme = theme;
        else {
            if ($('.e-datavisualization-chart').length != 0) {
                $('.e-datavisualization-chart').ejChart("option", { "theme": theme });
            }
            var length = $('.e-datavisualization-rangenavigator').length;
            if (length != 0) {
                if (length <= 1) {
                    if ($('.e-datavisualization-rangenavigator')[0].id == "rangecustomtheme") {
                        var rangeObj = $('.e-datavisualization-rangenavigator').data("ejRangeNavigator");
                        rangeObj.renderNavigator();
                    } else {
                        $('.e-datavisualization-rangenavigator').ejRangeNavigator("option", { "theme": theme });

                    }
                } else {
                    var rangeObj = $('#rangecustomtheme').data("ejRangeNavigator");
                    var rangeObj1 = $('#rangecustomtheme2').data("ejRangeNavigator");
                    rangeObj.renderNavigator();
                    rangeObj1.renderNavigator();
                }
            }
        }
    }

}
//Load Bullet theme
function loadBulletTheme() {
    var bulletTheme = window.theme;
    if (bulletTheme) {
        switch (bulletTheme) {
            case "flatdark":
            case "azuredark":
            case "limedark":
            case "saffrondark":
            case "gradientdark":
            case "gradientazuredark":
            case "gradientlimedark":
            case "gradientsaffrondark":
            case "high-contrast-01":
            case "high-contrast-02":
                bulletTheme = "flatdark";
                break;
            default:
                bulletTheme = "flatlight";
                break;
        }
        if ($('.e-datavisualization-bulletgraph ').length != 0) {
            if (ej.isNullOrUndefined($('.e-datavisualization-bulletgraph ').data('ejBulletGraph'))) return false;
            var bulletGraphTheme = $('.e-datavisualization-bulletgraph ').ejBulletGraph('instance');
            $('.e-datavisualization-bulletgraph ').ejBulletGraph({ theme: bulletTheme });
            bulletGraphTheme.model.theme = bulletTheme;
        }
    }
}

function loadSunBurstTheme(sender) {   
     var SunBurstTheme = window.theme;
     if (SunBurstTheme.indexOf("dark") > -1 || SunBurstTheme == "high-contrast-01" || SunBurstTheme == "high-contrast-02"  ) 
		SunBurstTheme = "flatdark";
	 else
		SunBurstTheme = "flatlight";               		 			
    if(sender)
	 sender.model.theme = SunBurstTheme;                       
}


function loadPivotGaugeTheme(args) {
    var theme1 = window.theme;
    if (theme1) {
        switch (theme1) {
            case "flatdark":
            case "azuredark":
            case "limedark":
            case "saffrondark":
            case "gradientdark":
            case "gradientazuredark":
            case "gradientlimedark":
            case "gradientsaffrondark":
                themeab = "flatdark";
                break;
            default:
                themeab = "flatlight";
                break;
        }
        if ($(".e-pivotgauge").length > 0 && $(".e-circulargauge").length > 0) {
            var gaugeElem = $(".e-circulargauge");
            for (var j = 0; j < gaugeElem.length; j++) {
                var gaugeObj = $(gaugeElem[j]).data("ejCircularGauge");
                !ej.isNullOrUndefined(gaugeObj) && $('.e-circulargauge').ejCircularGauge({ theme: themeab });
                gaugeObj.model.theme = themeab;
                updateGuageTheme(theme1, gaugeObj._id);
            }
        }
        var oGaugeObj = $(args.element).data("ejPivotGauge");
        oGaugeObj._wireEvents();
        //args._wireEvents();
    }
}

//Load Gauge Theme
function loadGaugeTheme() {
    var gaugeTheme = "", theme1 = window.theme;
    if (theme1) {
        switch (theme1) {
            case "flatdark":
            case "azuredark":
            case "limedark":
            case "saffrondark":
            case "gradientdark":
            case "gradientazuredark":
            case "gradientlimedark":
            case "gradientsaffrondark":
            case "high-contrast-01":
            case "high-contrast-02":
                gaugeTheme = "flatdark";
                break;           
            default:
                gaugeTheme = "flatlight";
                break;
        }
        if ($(".e-pivotgauge").length > 0 && $(".e-circulargauge").length > 0) {
            var gaugeElem = $(".e-circulargauge");
            for (var j = 0; j < gaugeElem.length; j++) {
                var gaugeObj = $(gaugeElem[j]).data("ejCircularGauge");
                !ej.isNullOrUndefined(gaugeObj) && $('.e-circulargauge').ejCircularGauge({ theme: gaugeTheme });
                gaugeObj.model.theme = gaugeTheme;
                updateGuageTheme(theme1, gaugeObj._id);
            }
        }
        else if ($('.e-circulargauge').length != 0) {
            if (ej.isNullOrUndefined($('.e-circulargauge').data('ejCircularGauge'))) return false; 
            var cGauge = $('.e-circulargauge').ejCircularGauge('instance');
            !ej.isNullOrUndefined(cGauge) && $('.e-circulargauge').ejCircularGauge({ theme: gaugeTheme });
            cGauge.model.theme = gaugeTheme;
            updateGuageTheme(theme1, cGauge._id);
        }
        else if (($('.e-lineargauge').length != 0)) {
            if (ej.isNullOrUndefined($('.e-lineargauge').data('ejLinearGauge'))) return false; 
            var lGauge = $('.e-lineargauge').ejLinearGauge('instance');
            !ej.isNullOrUndefined(lGauge) && $('.e-lineargauge').ejLinearGauge({ theme: gaugeTheme });
            lGauge.model.theme = gaugeTheme;
            updateGuageTheme(theme1, lGauge._id);
        }
        else if (($('.e-digitalgauge').length != 0)) {
            if (ej.isNullOrUndefined($('.e-digitalgauge').data('ejDigitalGauge'))) return false; 
            var dGauge = $('.e-digitalgauge').ejDigitalGauge('instance');
            !ej.isNullOrUndefined(dGauge) && $('.e-digitalgauge').ejDigitalGauge({ theme: gaugeTheme });
            dGauge.model.theme = gaugeTheme;
            updateGuageTheme(theme1, dGauge._id);
        }
        var OGauge = $(".e-pivotgauge").data("ejPivotGauge");
        if (OGauge)
            OGauge._wireEvents();

    }
}

function updateGuageTheme(themestyle,id) {
    var clsname = "";
    if ($(".e-circulargauge").length > 0) {
        clsname = "e-circulargauge";
    }
    else if ($(".e-lineargauge").length > 0) {
        clsname = "e-lineargauge";
    }
    else if ($(".e-digitalgauge").length > 0) {
        clsname = "e-digitalgauge";
    }

    clsname && updateThemeforGauge(clsname, themestyle,id);
}
function updateThemeforGauge(clsname, themestyle, gaugeid) {   
    var themecolor = themestyle.indexOf("dark") == -1 ? "light" : "dark";
    var skin = "metro" + themecolor;
    switch (clsname) {
        case "e-circulargauge":           
            replaceframesforGauge(gaugeid, themecolor, themestyle, "circular");
            break;
        case "e-lineargauge":           
            replaceframesforGauge(gaugeid, themecolor, themestyle, "linear");
            break;
        case "e-digitalgauge":           
            replaceframesforGauge(gaugeid, themecolor, themestyle, "digital");
            break;
    }
}

function replaceframesforGauge(gaugeid, themecolor, themestyle, frameclass) {
    var lGauge, 
        oirentation,
	     framestyle;
    if (themestyle.indexOf("gradient") != -1) {
	     if (($(".e-lineargauge").length > 0)){
	         lGauge = $(".e-lineargauge").ejLinearGauge('instance');
	         oirentation = lGauge.model.orientation.toLowerCase();
	         framestyle = themecolor == "light" ? (oirentation == "vertical") ? "lightgradient" : "lightgradient1" : (oirentation == "vertical" ) ? "darkgradient" : "darkgradient1";
	     }
		else if(($(".e-circulargauge").length > 0)){
            CGauge = $(".e-circulargauge").ejCircularGauge('instance');
			frameType = CGauge.model.frame.frameType.toLowerCase();
			framestyle = themecolor == "light" ? (frameType == "fullcircle") ? "lightgradient" : "lightgradientsemi" : "darkgradient" ;			  
		}
	    else
            framestyle = themecolor == "light" ? "lightgradient" : "darkgradient";
		
        if ($("#" + gaugeid).parent().hasClass(frameclass + "lightgradient"))
            $("#" + gaugeid).parent().removeClass(frameclass + "lightgradient");
	     else if ($("#" + gaugeid).parent().hasClass(frameclass + "lightgradient1"))
           $("#" + gaugeid).parent().removeClass(frameclass + "lightgradient1");
        else if ($("#" + gaugeid).parent().hasClass(frameclass + "darkgradient"))
            $("#" + gaugeid).parent().removeClass(frameclass + "darkgradient");
		 else if ($("#" + gaugeid).parent().hasClass(frameclass + "darkgradient1"))
            $("#" + gaugeid).parent().removeClass(frameclass + "darkgradient1");
        frameclass = gaugeid == "thermoLinear" ? "thermo" : frameclass;
        $("#" + gaugeid).parent().addClass(frameclass + framestyle);
    } 
    else
        $("#" + gaugeid).parent()[0].className = "";
}

function convertWidgets() {
    // declaration
    $(".cols-prop-area .e-btn").ejButton();
    $(".cols-prop-area .e-togglebtn").ejToggleButton();
    $(".cols-prop-area .e-chkbox").ejCheckBox();
    $(".cols-prop-area .e-radiobutton").ejRadioButton();
    $(".cols-prop-area .e-ddl").ejDropDownList({ watermarkText: "Select" });
}

// Event Trace popup 

function adjustpopupposition(args) {
    var offset = $("#selectControls_input_dropdown").offset();
    var height = $("#selectControls_input_wrapper").height();
    $("#selectControls_input_popup").css("top", (offset.top + height + 14) + "px");
    var left = $("#selectControls_input_popup").width() + offset.left;
    if (left > $(".content-container-fluid").width())
        left = (offset.left + $("#selectControls_input_dropdown").width()) - $("#selectControls_input_popup").width() - 12;
    $("#selectControls_input_popup_list_wrapper").css("left", left + "px");
}

// For event tracer
jQuery.addEventLog = function (eventLog) {

    var divEvtTrace = null;
    if (!$(".sf-event-panel").length > 0) {
        divEvtTrace = ej.buildTag("div.divEventTrace sf-event-panel");
    }
    else {
        divEvtTrace = $(".sf-event-panel");
    }
    $("#EventLog").append(divEvtTrace);
    var eventHtml = "<span class='eventLog'>" + eventLog + "</span><hr>";
    $(eventHtml).prependTo($("div.divEventTrace")).slideDown(300, "easeOutQuad");
    if ($('input[name=themevarient]:checked').length>0 && $('input[name=themevarient]:checked')[0].id == "darktext")
        $(".eventtracesection hr").addClass("dark-hr");
    else
        $(".eventtracesection hr").removeClass("dark-hr");
};

jQuery.clearEventLog = function () {
    $("div.divEventTrace").html("");
}