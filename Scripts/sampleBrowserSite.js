var slider1 = null, slider2 = null, oldthemepath = null, SamplesList = null, editcontrolpath = null, selthemecolor = null, cssheight = null; window.theme = "saffron", minScrollerHeight = 550;
window.themecolor = ""; window.themestyle = ""; window.themevarient = "",removeGroup=false;
var subdata = [];
var themes = {
    "flat": "/Content/ejthemes/default-theme/ej.theme.min.css",
    "flatdark": "/Content/ejthemes/flat-azure-dark/ej.theme.min.css",
    "azure": "/Content/ejthemes/default-theme/ej.theme.min.css",
    "azuredark": "/Content/ejthemes/flat-azure-dark/ej.theme.min.css",
    "lime": "/Content/ejthemes/flat-lime/ej.theme.min.css",
    "limedark": "/Content/ejthemes/flat-lime-dark/ej.theme.min.css",
    "saffron": "/Content/ejthemes/flat-saffron/ej.theme.min.css",
    "saffrondark": "/Content/ejthemes/flat-saffron-dark/ej.theme.min.css",
    "gradient": "/Content/ejthemes/gradient-azure/ej.theme.min.css",
    "gradientdark": "/Content/ejthemes/gradient-azure-dark/ej.theme.min.css",
    "gradientazure": "/Content/ejthemes/gradient-azure/ej.theme.min.css",
    "gradientazuredark": "/Content/ejthemes/gradient-azure-dark/ej.theme.min.css",
    "gradientlime": "/Content/ejthemes/gradient-lime/ej.theme.min.css",
    "gradientlimedark": "/Content/ejthemes/gradient-lime-dark/ej.theme.min.css",
    "gradientsaffron": "/Content/ejthemes/gradient-saffron/ej.theme.min.css",
    "gradientsaffrondark": "/Content/ejthemes/gradient-saffron-dark/ej.theme.min.css",
    "bootstrap": "/Content/ejthemes/bootstrap-theme/ej.theme.min.css",
    "bootstrap": "/Content/ejthemes/bootstrap-theme/ej.theme.min.css",
    "high-contrast-01": "/Content/ejthemes/high-contrast-01/ej.theme.min.css",
    "high-contrast-02": "/Content/ejthemes/high-contrast-02/ej.theme.min.css",
    "material": "/Content/ejthemes/material/ej.theme.min.css",
    "office-365": "/Content/ejthemes/office-365/ej.theme.min.css"
};
var core = {
    "bootstrap": "/Content/ejthemes/",
    "material": "/Content/ejthemes/",
    "office-365": "/Content/ejthemes/"
};
var rptDesignerThemes = {
    "flat": "/Content/ejthemes/default-theme/ej.reportdesigner.theme.min.css",
    "flatdark": "/Content/ejthemes/flat-azure-dark/ej.reportdesigner.theme.min.css",
    "azure": "/Content/ejthemes/default-theme/ej.reportdesigner.theme.min.css",
    "azuredark": "/Content/ejthemes/flat-azure-dark/ej.reportdesigner.theme.min.css",
    "lime": "/Content/ejthemes/flat-lime/ej.reportdesigner.theme.min.css",
    "limedark": "/Content/ejthemes/flat-lime-dark/ej.reportdesigner.theme.min.css",
    "saffron": "/Content/ejthemes/flat-saffron/ej.reportdesigner.theme.min.css",
    "saffrondark": "/Content/ejthemes/flat-saffron-dark/ej.reportdesigner.theme.min.css",
    "gradient": "/Content/ejthemes/gradient-azure/ej.reportdesigner.theme.min.css",
    "gradientdark": "/Content/ejthemes/gradient-azure-dark/ej.reportdesigner.theme.min.css",
    "gradientazure": "/Content/ejthemes/gradient-azure/ej.reportdesigner.theme.min.css",
    "gradientazuredark": "/Content/ejthemes/gradient-azure-dark/ej.reportdesigner.theme.min.css",
    "gradientlime": "/Content/ejthemes/gradient-lime/ej.reportdesigner.theme.min.css",
    "gradientlimedark": "/Content/ejthemes/gradient-lime-dark/ej.reportdesigner.theme.min.css",
    "gradientsaffron": "/Content/ejthemes/gradient-saffron/ej.reportdesigner.theme.min.css",
    "gradientsaffrondark": "/Content/ejthemes/gradient-saffron-dark/ej.reportdesigner.theme.min.css",
    "bootstrap": "/Content/ejthemes/bootstrap-theme/ej.reportdesigner.theme.min.css",
    "high-contrast-01": "/Content/ejthemes/high-contrast-01/ej.reportdesigner.theme.min.css",
    "high-contrast-02": "/Content/ejthemes/high-contrast-02/ej.reportdesigner.theme.min.css",
    "material": "/Content/ejthemes/material/ej.reportdesigner.theme.min.css",
    "office-365": "/Content/ejthemes/office-365/ej.reportdesigner.theme.min.css"
};
if ((readCookie('themeName') != null) && (readCookie('themeName') != ""))
    window.theme = readCookie('themeName');
replaceTheme();
preparetheme();
$(function () {
    if (window.location.pathname !== "/" && window.location.pathname !== "") {
        document.getElementById('ej2popup').style.display = 'none';
    }
	if (document.referrer && document.referrer.split('/')[2] != window.location.host) {
            var existingCookieValue = getCookieValue("SampleSiteReferrer");
            var currentUrl = "";
            if (existingCookieValue.indexOf(window.location.host) === -1) {
                currentUrl = "," + window.location.href;
            }
            if (existingCookieValue != "undefined" && existingCookieValue != undefined && existingCookieValue != "") {
                existingCookieValue = existingCookieValue + currentUrl;
                document.cookie = "SampleSiteReferrer" + "=" + existingCookieValue + ";path=/;domain=syncfusion.com";
            }
            else {
                document.cookie = "SampleSiteReferrer" + "=" + document.referrer + currentUrl + ";path=/;domain=syncfusion.com";
            }
        }

    var sbModel = new ViewModel(), isloadLeft = false;
    this.PathLoc = null, this.themeonchange=false;
    window.theme = "saffron";
    window.isTransitionSupported = "transition" in document.body.style;
    //debugger
    if ((readCookie('themeColor') != null) && (readCookie('themeColor') != ""))
        window.themecolor = readCookie('themeColor');
    $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + window.themecolor);
    if ((readCookie('themeStyle') != null) && (readCookie('themeStyle') != ""))
        window.themestyle = readCookie('themeStyle');
    if ((readCookie('themeVarient') != null) && (readCookie('themeVarient') != ""))
        window.themevarient = readCookie('themeVarient');
    if (window.themevarient == 'dark') $("body").attr("class", window.themevarient + "theme"); else $("body").attr("class", "");
    $(function () {
        var control = "", categories = [], currentSample, theme = "";
        var urlread = window.location.toString().toLowerCase(), cur_sample = "";

        for (i = 0; i < window.SampleControls.length; i++) {
            if (urlread.indexOf("/" + window.SampleControls[i].name.toLowerCase() + "/") >= 0) {
                control = window.SampleControls[i].name.toLowerCase();
                if (urlread.indexOf("?") >= 0) {
                    var data = urlread.substr(urlread.lastIndexOf("/") + 1, urlread.length);
                    cur_sample = data.substr(0, data.indexOf("?")); 
                } else {
                    cur_sample = urlread.substr(urlread.lastIndexOf("/") + 1, urlread.length);
                }
                if (cur_sample == control)
                    cur_sample = window.SamplesList.filter(function (e) { if (e.id == control) return e })[0].action
                break;
            }
        }

        categories.push(cur_sample);
        isloadLeft = true;
        currentSample = categories.pop();
        control !== "" ? (loadSamplePage(control, currentSample, categories), $('.control_ref').removeClass('hidepage')) : (showTooltipbox(), $('.control_ref').addClass('hidepage'));
        updateSBTheme();
        updateTheme(window.theme); 
        $("#buybutton").attr("title", "Download");
        $("#themebutton").attr("title", "Select Theme");
        $("#res_themebutton").attr("title", "Select Theme");
        $("#themestudio").attr("title", "Essential Theme Studio");
    });

    $('.control_ref .ref_options >a').on('click', function () {
        window.open($(this).attr('href'));
        return false;
    });
    $.views.converters("ensureURL", function (val) {
        if (val != null) return val.toLowerCase(); else return val;
    });
    $.views.converters("Upperstring", function (val) {
        return val.toUpperCase();
    });
    $.views.converters("RemoveWhiteSpace", function(val) {
        return val.replace(/ /g, "") ;
    });
    var updateSBTheme = function () {
        $("#themebutton >li >a > .e-icon:first").removeClass('lime').removeClass('azure').removeClass('saffron');
        $("#res_themebutton >li >a > .e-icon:first").removeClass('lime').removeClass('azure').removeClass('saffron');
        if (window.theme.indexOf("lime") != -1) {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "lime");
            $("#themebutton >li >a > .e-icon:first").addClass("lime");
            $("#res_themebutton >li >a > .e-icon:first").addClass("lime");
        }
        else if (window.theme.indexOf("saffron") != -1) {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "saffron");
            $("#themebutton >li >a > .e-icon:first").addClass("saffron");
            $("#res_themebutton >li >a > .e-icon:first").addClass("saffron");
        }
        else if (window.location.hash.indexOf("bootstrap") != -1) {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "azure");
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }else {
            $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + "azure");
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }
    };
    var loadSamplePage = function (control, currentSample, categories) {
        if (control == null) {
            $("#samplesDiv").css("display", "none");
            $(".samples").css("display", "none");
            self.loadSBMainPage(null);
            return;
        }

        var sample = findSample(control, currentSample, categories), name = sample, parentId = null;

        while (!ej.isNullOrUndefined(name) && name.samples) {
            if (name.samples) {
                parentId = parseInt(name.id) ? name.id : null;
                name = name.samples[0];
                if( !ej.isNullOrUndefined(name) && name.hasOwnProperty('action'))
                    currentSample = name.action;
            } else
                break;
        }


        if ($("#sbtooltipbox").data("ejDialog"))
            $("#sbtooltipbox").ejDialog("close");

        if (isloadLeft || Number(name.id) <= 1)
            self.loadLeftTab(control, currentSample);
        var sampleurl = "/" + control + "/" + currentSample;
        if(!ej.isNullOrUndefined(name))
            self.loadSamplePage(sampleurl, control, currentSample, parentId, name.id);
        $('#ref_document').attr('href', sample.ugurl ? sample.ugurl : 'https://help.syncfusion.com/aspnetmvc');
        $('#ref_forums').attr('href', sample.forumurl ? sample.forumurl : 'https://www.syncfusion.com/forums/aspnetmvc');
        $('#ref_kb').attr('href', sample.kburl ? sample.kburl : 'https://www.syncfusion.com/kb/aspnetmvc');
    };

    resizeMenu = function () {
        menu = window.innerWidth < 981 ? $("#res_themebutton ul") : $("#themebutton ul");
        menu.css("overflow-y", "auto");
        var height = window.innerHeight - $(".header").outerHeight();
        height > 520 ? menu.height("auto") : menu.height(height - 55);
    }

    var findSample = function (control, currentSample, categories) {
        var currentcontrollist = null, subcontrollist = null;
        $(SamplesList).each(function () {
            if ($(this)[0].controller.toString().toLowerCase() == control.toLowerCase()) {
                currentcontrollist = $(this);
            }

        });

        $($(currentcontrollist)[0].samples).each(function () {
            if ($(this)[0].samples) {
                for (var i = 0; i < $(this)[0].samples.length; i++) {
                    if ($(this)[0].samples[i].action.toLowerCase() == currentSample.toLowerCase()) {
                        categories.push($(this)[0].name);
                        break;
                    }
                }
            }

        });

        var sample = ej.Query().using(ej.DataManager(SamplesList)).where("controller", "==", control, true), current = sample, res;

        for (var k = 0; k < categories.length; k++) {
            current.hierarchy((current = ej.Query("samples").where("name", "==", categories[k], true)));
        }

        if (currentSample)
            current.hierarchy(ej.Query("samples").where("action", "==", currentSample, true));

        res = sample.executeLocal();

        if (res.length) res = res[0];
        return res;
    };
    //$("#Res-prodnav").on("click", function (e) {
    //    if ($(window).width() < 900 && !($(this).hasClass("selectIt")) && $(".product-naviation").hasClass("hideIt"))
    //        $(this).addClass("selectIt");
    //    else if (!$(".product-naviation").hasClass("hideIt"))
    //        $(".product-naviation").removeClass("hideIt");
    //});
    $("#scrollcontainer").on("click", ".secondlevelload, .anchorclass", function (e) {
        var hashvalue = $(e.currentTarget).attr('hashbang');
        var categorieslist = hashvalue.slice(1, hashvalue.lastIndexOf("/"));
        eraseCookie("catalog");
        createCookies('catalog', categorieslist, 1);
        var viewportWidth = $(window).width();
        if (viewportWidth < 981) {
            $('.content-container-fluid .row > .navigation').addClass('collapsePanel');
            $('.accordion-panel').removeClass("expandPanel");
        }
    });
    var browser = navigator.userAgent.match(/(msie) ([\w.]+)/i);
    $("#themebutton").ejMenu({
        fields: { dataSource: menuData },
        openOnClick: true,
		isResponsive:false,
        width: 62,
        titleText:"",
        cssClass: "e-custom-theme",
        click: "themebtnClick"
    });
    $("#res_themebutton").ejMenu({
        fields: { dataSource: menuData },
        openOnClick: true,
		isResponsive:false,
        width: 35,
        cssClass: "e-custom-theme",
        click: "themebtnClick"
    });
    $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
    $("#themebutton >li >a > .e-icon:first").addClass("azure");
    if (!ej.isNullOrUndefined(browser) && browser[1].toLowerCase() == "msie" && browser[2] == 8) $(".res_header .e-custom-theme").addClass('e-hide');
    $("#buybutton").ejButton({
        size: "normal",
        width: "66px",
        height: "50px",
        cssClass: "metroblue",
        contentType: "imageonly",
        prefixIcon: "e-icon e-uiLight e-icon-handup",
        click:"downlinkclick"
    });
	$("#themestudio").ejButton({
        size: "normal",
        width: 165,
        height: 30,
        cssClass: "themestudio",
        showRoundedCorner: true,
        prefixIcon: "e-icon themestudio-logo",
        contentType: "textandimage",
        click: "paintTheme"
    });
    $("#ej2Samples").ejButton({
        size: "normal",
        width: 165,
        height: 30,
        cssClass: "ej2button",
        showRoundedCorner: true,
	    prefixIcon: "e-icon ej2button-logo",
	    contentType: "textandimage",
	    click: "ej2Switch"
	});
$("#learnmore").ejButton({
        size: "normal",
        width: 100,
        height: 28,
        cssClass: "learnmore",
        showRoundedCorner: true,
        contentType: "text",
		click: "ej2Switch"
    });
	
	$("#popupclose").ejButton({
        size: "normal",
        width: 20,
        height: 20,
        cssClass: "popupclose",
        showRoundedCorner: true,
        prefixIcon: "e-icon ej2button-logo",
        contentType: "image",
		click: function(evt, args) {
			$("#ej2popup").hide();
		}
    });
    $("#mobileSamples").ejButton({
        size: "normal",
        width: 165,
        height: 30,
        cssClass: "themestudio",
        showRoundedCorner: true,
        prefixIcon: "e-icon mobile-logo",
        contentType: "textandimage",
        click: "ionicSwitch"
    });
    //$(document).on(".product-naviation div", "click", function (e) {
    //    var navText = e.target.textContent || e.target.innerText;
    //    viewdemo({text:navText});
    //	$(".productlogo").removeClass().addClass("productlogo");
    //	$(".productlogo").addClass(navText.toLowerCase()+"logo");
    //});
    $("#sbtooltipbox").ejDialog({ height: "86px", width: "176px", enableResize: false, showOnInit: false, showHeader: false, cssClass: "metroblue", allowKeyboardNavigation :false });
    $("#themeDialog").ejDialog({ height: "160px", enableResize: false, showOnInit: false, showHeader: false, cssClass: "metroblue" });
    themeButtonSelect();
    var eleID = (window.themecolor == "highcontrast01" ||  window.themecolor == "highcontrast02" ||  window.themecolor == "material" ||  window.themecolor == "office365") ? window.themecolor :(window.themestyle == "" ? "flat" : window.themestyle) + window.themecolor + (window.themevarient != "light" ? window.themevarient : "");
    var menuObj = $("#themebutton").ejMenu('instance');
    jQuery.each(menuObj.element.find('li > ul > li'), function (i, val) {
        if ($(val).attr('id') === eleID) $(val).addClass('e-active');
    });
    var metroradio = $("#JobSearch").data("ejMenu");
    var firstlevelsamples = [];

    var isContentPageLoaded = null;
    var index = 0;

    function ViewModel() {
        this.Controls = SamplesList;
        this.controlname = "";
        this.controlName = null;
        this.sampleName = null;

        self.editSubItem = function (id, back) {
            var divid = id;
            removeSelectedItemcss();
            $("#subsamplesDiv").html('');
            $("#" + divid).css("margin-top", "0px");
            $("#subsamplesDiv").hide().css("left", "250px");
            $("#samplesDiv").css("left", "0px").show();
            $("#" + divid).show().css("visibility", "visible");
            $("#" + divid + "_back").css("display", "block");
            $("#" + divid + "_back").addClass("dashboarddiv");
            $("#" + divid).children(".subsamples").find("a >div").removeClass("dashboardhover");
            $("#samplesDiv").find("#" + divid).css("left", "-250px");
            $("#samplesDiv").find("#" + divid).children(".subsamples").show();
            $("#samplesDiv").find("#" + divid).animate({ left: '0px' }, 200);
            var samplename = null, controlname = null;
       
        };

        self.loadLeftTab = function (divid) {
            divid = divid + "_nav";
            if ($("#" + divid).prev().length > 0) {
                $("#" + divid).css("margin-top", "0px");
            }
            $("#accordion2").css("left", "-250px");
            $("#accordion2").prev().css("display", "none");
            $("#accordion2").css("display", "none");
            $("#subsamplesDiv").css("display", "none");
            $(".samples").hide();
            $("#samplesDiv").children("." + divid).css("display", "block");
            $("#samplesDiv").children("." + divid).children(".subsamples").show();
            $("#samplesDiv").children("." + divid).children(".subsamples").find("#subControls").hide();
            $("#" + divid + "_back").css("display", "block");
            $("#" + divid + "_header").css("display", "block");
            if ($("#currentheader").length > 0)
                $("#currentheader").remove();
            var element = $("#" + divid + "_back").clone();
            $(element).appendTo("#dashboardheader>a").attr("id", "currentheader");
            $("#" + divid + "_back").css("display", "none");
            if ($("#dashboardheader .current_control").length > 0)
                $("#dashboardheader .current_control").remove();
            $($("#" + divid + "_header").clone()).insertAfter("#dashboardheader>a").addClass("current_control").attr("id", "current_control");
            $("#" + divid + "_header").hide();
            $("#sbdashboard").hide();
            $("#samplesDiv").css("display", "block");
            $("#samplesDiv").css("margin-top", "0px");
            $("#samplesDiv").animate({ left: '0px' }, 0);
            $('html, body').animate({
                scrollTop: 0
            }, 0);
            $("#sbdashboard").hide();
            //$(".accordion-panel").height($(".accordion-panel")[0].scrollHeight);
            refreshScroller();
        };


        self.findSample = function (ctrlname, samplename, subchild, currentsampleid) {
            var query = ej.Query().using(ej.DataManager(SamplesList))
                .where("id", "==", ctrlname, true), curr = query, res;

            if (subchild)
                query.hierarchy(
                    curr = ej.Query("samples")
                          .where("id", "==", subchild, true));

            curr.hierarchy(
                ej.Query("samples")
                    .where("id", "==", currentsampleid, true)
            );

            res = query.executeLocal();

            if (res.length) res = res[0];
            return res;

        },
        self.loadSamplePage = function (url, ctrlname, samplename, subchild, currentsampleid) {
            currentSamplepage = url;
            window.currentSamplepage = url;
            var sample = self.findSample(ctrlname, samplename, subchild, currentsampleid), sampleTitle = "",samplePath="";
            if ($("#auto").data("ejAutocomplete"))
                $("#auto").ejAutocomplete("clearText");
            $(".sampleheadingtext").empty();
            
            while (sample) {
                if (sampleTitle)
                    sampleTitle += " / ";

                sampleTitle += sample.name;

                sample = sample.samples && sample.samples[0];
            }

            var names = sampleTitle.split("/"), _samplename = names.pop();
            var _halfTitle = names.join("/") + "/ ";
            var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
            var serverconfig = links[0].href.substr(0, links[0].href.indexOf("Content") - 1);
            var sampletitleobj = ej.buildTag("h1.samplename sbsamplename");
            ej.buildTag("span.controlname", _halfTitle).appendTo(sampletitleobj);
            ej.buildTag("span.sampletitle", _samplename).appendTo(sampletitleobj);
            var navigation = ej.buildTag("span.navigation-btn");
            var paclk = prevnext(ctrlname, samplename, 'prev');
            var ancprev = ej.buildTag("a.navprev", "", {}, { href:serverconfig+ paclk }).appendTo(navigation);
            var naclk = prevnext(ctrlname, samplename, 'next');
            var ancnext = ej.buildTag("a.navprev", "", {}, { href: serverconfig+naclk }).appendTo(navigation);
            var prevState = ej.buildTag("span.prev", "Prev").appendTo(ancprev);
            var nextstate = ej.buildTag("span.next", "Next ").appendTo(ancnext);
            navigation.appendTo(sampletitleobj);
            $(".sampleheadingtext:first").html(sampletitleobj);
            editcontrolpath = "/" + samplename;
            document.title = "Essential Studio for ASP.NET MVC : " + sampleTitle.replace(/\//g, "-") + " Demo";
            index = 0;
            $(".res_header .producttitle").hide();
            $(".res_header .sampleheadingtext").show();
            $(".prev").ejButton({
                size: "mini",
                cssClass: "metroblue",
                contentType: "imageonly",
                prefixIcon: "e-icon e-rarrowleft-2x"
            });
            $(".next").ejButton({
                size: "mini",
                cssClass: "metroblue",
                contentType: "imageonly",
                prefixIcon: "e-icon e-rarrowright-2x"
            });

            var curr = $("#samplesDiv").children("." + ctrlname + "_nav").find("div[action='" + samplename + "']");
            if (curr) {
                curr.children('span.anchor').addClass("itemselected");
                curr.addClass("highlighttextbg");
                curr.addClass("selecteddashboard");
            }
            if (curr.length == 1) {
                var scrollercontrol = $("#scrollcontainer").ejScroller("instance");
                scrollercontrol.model.scrollTop = (curr.offset().top - $("#scrollcontainer>div:first-child").offset().top);
                scrollercontrol.refresh();
            }
          
        };


        self.loadSBMainPage = function (divid) {
            $(".samplesection").hide();
            if (divid != null) {
                $("#" + divid).css("visibility", "hidden");
                $("#" + divid + "_back").css("display", "none");
            }
            self.loadSBPage(divid);
            $(".accordion-panel").height($(".accordion-panel")[0].scrollHeight);
        };
        self.loadSBPage = function (divid) {
            $("#accordion2").prev().css("display", "block");
            $("#accordion2>a>.dashboardhover").removeClass("dashboardhover");
            $(".sourcecodetab").hide();
            if (divid != null)
                $("#" + divid).hide();
            $("#accordion2").show();
            $("#samplesDiv").css("left", "250px");
            $("#accordion2").animate({ left: 0 }, 200, function () {
                //self.setVisibility("cols-iframe", "productpage");
                $(".res_header .sampleheadingtext").hide();
                $(".res_header .producttitle").show();
            });
            $(".accordion-panel").height($(".content-container-fluid").height() - ($(".htmljssamplebrowser>.header").height() + 5));
            $('html, body').animate({
                scrollTop: 0
            }, 0);
            $(".accordion-panel").height($(".accordion-panel")[0].scruollHeight);
        };

        self.setVisibility = function (oldpage, newpage) {
            $("." + newpage).show();
            $("." + oldpage).hide();
        };
        this.getCssClass = function (item) {
            var value = Number(item.childcount);

            if (value >= 1) {
                return 'arrow';
            }
            return;
        };
        this.getCssVisibility = function (item) {
            var value = Number(item.id);

            if (value != 1) {
                return 'hideParent';
            }
            return 'dashboard';
        };
        self.removeSelectedItemcss = function (ctrlname, controlid) {
            var obj = $(".itemselected");
            obj.each(function () {
                $(obj).removeClass('itemselected');
                $(obj).parent().removeClass('highlighttextbg');
            });
            $(".selecteddashboard").removeClass("selecteddashboard");
        };
    }
    var Mainlist = [];

    $(GroupingList).each(function () {
        Mainlist[this] = [];
    });
    
    var samplesdetails = SamplesList;
    $(samplesdetails).each(function (index1, sampleslist) {
        var smpls = {}, secsamples = [];
        smpls["id"] = sampleslist.id;
        smpls["name"] = sampleslist.name;
        smpls["controller"] = sampleslist.controller;
        smpls["action"] = sampleslist.action;
        smpls["childcount"] = sampleslist.childcount;
        smpls["type"] = sampleslist.type;
        smpls["isResponsive"] = sampleslist.isResponsive;
        $(sampleslist.samples).each(function (ind, subsampleslist) {
            var subsmpls = {};
            subsmpls["id"] = subsampleslist.id;
            subsmpls["name"] = subsampleslist.name;
            subsmpls["controller"] = subsampleslist.controller;
            subsmpls["action"] = subsampleslist.action;
            subsmpls["childcount"] = subsampleslist.childcount;
            if (subsampleslist.isResponsive)
                subsmpls["isResponsive"] = subsampleslist.isResponsive;
            else
                subsmpls["isResponsive"] = smpls["isResponsive"];
            subsmpls["url"] = SamplesList[index1].samples[ind]["url"] = subsampleslist.name.split(" ").join("");
            subsmpls["type"] = subsampleslist.type;
            if (subsampleslist.childcount == 1)
                subsmpls["arrowclass"] = "arrow";
            else
                subsmpls["arrowclass"] = "";
            subsmpls["samples"] = subsampleslist.samples;
            secsamples.push(subsmpls);
        });
        smpls["samples"] = secsamples;
        var temp = this;
        $(GroupingList).each(function () {
            if (temp["Group"] == this.toString()) {
                Mainlist[this.toString()].push(smpls);
                return false;
            }
        });
    });
    $("#accordion2").html($("#accordionGroupTmpl").render(GroupingList));	
    $(GroupingList).each(function () {
        var content = $("#accordionTmpl").render(Mainlist[this]);
        if ($.trim(content) != ""){
            $(".SB-group." + this.toString().replace(/ /g, "")).html(content);
            $(Mainlist[this.toString()]).each(function () {
                firstlevelsamples.push(this);
            });
        }
        else
            $(".SB-group." + this.toString().replace(/ /g, "")).hide().prev().hide();
    });

    $("#samplesDiv").html($("#accordionTmplchild").render(firstlevelsamples));
    $("#scrollcontainer").ejScroller({ buttonSize: 0, scrollerSize: 9});
    $("#scrollcontainer .e-vhandle").addClass("e-box");
    $("#scrollcontainer .SB-groupIt").click(function () {
        if ($(this).hasClass("downArrow")) {
            $(this).next().hide(300,'linear', function () { refreshScroller() });
            $(this).removeClass("downArrow");
            $(this).addClass("rightArrow");
        }
        else {
            $(this).next().show(300,'linear', function () { refreshScroller() });
            $(this).removeClass("rightArrow");
            $(this).addClass("downArrow");
        }
    });
    RefreshPoductNav();
    refreshScroller();
    refreshContentWindow();    
    $(".product-naviation,.themeswitch").show();
    function refreshScroller() {       
        var controlheight = $("#scrollcontainer").ejScroller("instance");
        var Minheight = ($(window).height()) - ($(".header").outerHeight() + $("#dashboardheader").outerHeight() + $(".search").outerHeight());
        controlheight.model.height = Minheight;
        controlheight.refresh();
    }
    function refreshContentWindow() {
        //resizing for content fluid width 
        $(".scrollit").attr("style", "height:" + (($(window).height() - $(".sbheader").outerHeight())) + "px;");
        $(".control-panel.scrollit > .row").attr("style", "min-height:" + (($(window).height() - $(".sbheader").outerHeight() - $("#footer").outerHeight())) + "px;");
    }
    $('div.firstlevelback').bind('click', function (evt, args) {
        $("#subsamplesDiv").hide().css("left", "250px");
    });
    function RefreshPoductNav()
    {
        $(".header").removeClass("Mobile").removeClass("Desktop");
        if($(window).width()>899)
            $(".header").addClass("Desktop");
        else
            $(".header").addClass("Mobile");
    }	
    $(".dashboard").mouseover(function () {
        if (!$(".vHandle").is(":visible")) {           
            if (window.themevarient.indexOf("dark")!= -1 && !$(this).hasClass("dark-highlighttextbg"))
                $(this).addClass("dark-dashboardhover");
            else
                $(this).addClass("dashboardhover");           
        }
    });
   
		$(".slidemenuicon").click(function(args) {
		$('.accordion-panel').removeClass('accordionHide').addClass("expandPanel");
            $('.control-panel.cols-content-fluid').removeClass('accordionHide').removeClass('center-flow');
            $('.accordion-panel > .navigation').addClass("expandPanel");
            $('.navigation').removeClass("collapsePanel"), move = 0;
            if (parseInt($('.accordion-panel').css('left')) >= 0) {
                $('.accordion-panel').css('left', '-' + $('.accordion-panel').outerWidth() + 'px');
            }
            $('.accordion-panel .navigation').addClass("expandPanel");
            refreshScroller();
            if (!removeGroup) {
				$(".accordion >.SB-group").each (function(i,item) {
				if (item.children.length == $(item).children(".irresponsive").length) 
				$(item.previousElementSibling).addClass("irresponsive");
		
				});
				removeGroup = true;
        }
			args.stopPropagation();
		});
	$("#samplefile").on('load',function(e) {
	$(document.getElementById("samplefile").contentWindow.document.body).click(function(e) { 
        if ($(".navigation").hasClass("expandPanel")) {
			$('.navigation').removeClass("expandPanel");
            $('.control-panel.cols-content-fluid').addClass('center-flow');
			$('.navigation').addClass("collapsePanel");
			$('.accordion-panel').hide(500);
		}	
	});
	});
	
    $(".dashboard").click(function (e) {
        $(".anchor").removeClass("itemselected");
        $(this).find(".anchor").addClass("itemselected");
        $(".dark-dashboard").removeClass("dark-highlighttextbg");
        $(".dashboard").removeClass("highlighttextbg");
        $(this).find(".itemselected").parent().addClass("highlighttextbg");
        $("#sbdashboard").addClass("highlighttextbg");
        if ($(e.target).hasClass("analytics_nav") || $(e.target).parents('.analytics_nav').length > 0) viewdemo({ text: "analytics" });
    });

    $(".dashboard").mouseout(function () {
        if ($(this).hasClass("dashboardhover"))
            $(this).removeClass("dashboardhover");
        else if ($(this).hasClass("dark-dashboardhover"))
            $(this).removeClass("dark-dashboardhover");
    });

    //autocomplete selection list
    var collection = SamplesList;
    var i, j, k;
    for (i = 0; i < collection.length; i++) {
        if (collection[i].samples) {
            for (j = 0; j < collection[i].samples.length; j++) {
                var properties = {}, len;
                var controlName = collection[i].controller;
                if(!collection[i].samples[j].samples)
                {
                    properties["id"] = controlName.toLowerCase() + "/" + collection[i].samples[j].action.toLowerCase();
                    properties["control"] = collection[i].name;
                    properties["text"] = collection[i].samples[j].name;
                    properties["data"] = collection[i].name + " " + collection[i].samples[j].name;
                    properties["isResponsive"] = collection[i].samples[j].isResponsive;
                    if (collection[i].isResponsive == "false") {
                        properties["isResponsive"] = "false";
                    }
                    subdata.push(properties);
                }
                if (collection[i].samples[j].childcount != "0") {
                    if (/msie 8.0/.test(navigator.userAgent.toLowerCase()))
                        len = collection[i].samples[j].samples.length - 1;
                    else
                        len = collection[i].samples[j].samples.length;
                    if (collection[i].samples[j].name == "Selection")
                        var s = true;
                    for (k = 0; k < len; k++) {
                        var subprops = {};
                        var subcontrolName = collection[i].samples[j].name;
                        subprops["id"] = controlName.toLowerCase() + "/" + collection[i].samples[j].samples[k].action.toLowerCase();
                        subprops["control"] = collection[i].name;
                        subprops["isResponsive"] = collection[i].samples[j].isResponsive;
                        subprops["text"] = collection[i].samples[j].name+"/"+collection[i].samples[j].samples[k].name;
                        subprops["data"] = collection[i].name + " " + collection[i].samples[j].name + "/" + collection[i].samples[j].samples[k].name;
                        subdata.push(subprops);
                    }
                }
            }
        }
    }
    $('#auto').ejAutocomplete({
        dataSource: subdata,
        fields: { key: "id", text: "data" },
        popupHeight: "180px"
    });
    //
	if ($(window).width()  < 979) {
			searchObj = $("#auto").data("ejAutocomplete");
			OldData = searchObj.option("dataSource");
			var newData = $.grep(OldData, function(sample) {
				return sample.isResponsive != "false";
			});
			searchObj.option("dataSource",newData);
		}
    var autocompletScroller = $("#auto").data("ejAutocomplete").scrollerObj;
    autocompletScroller.model.buttonSize = 0;
    autocompletScroller.model.scrollerSize = 8;
    
    $(window).bind("resize", function () {
		RefreshPoductNav();
        refreshScroller();
        refreshContentWindow();
        if ($("#sbtooltipbox").ejDialog("isOpened")) showTooltipbox();
        resizeMenu();
        samplelisthide();
    });

    $(window).on("orientationchange", function () {
        resizeMenu();
    });
   
   $(".control-panel").click(function (e) {
        if ($(".accordion-panel").hasClass("expandPanel")) {
            $('.accordion-panel').removeClass("expandPanel");
            $('.control-panel.cols-content-fluid').addClass('center-flow');
            $('.accordion-panel').addClass("collapsePanel");
            $('.accordion-panel').hide(200);
        }
    });
    $(document).click(function (evt) {
        if ($("#sbtooltipbox").ejDialog("isOpened"))
            $("#sbtooltipbox").ejDialog("close");
        var ele = false;
        var chromebrowser = /chrome/.test(navigator.userAgent.toLowerCase());
        var safaribrowser = /safari/.test(navigator.userAgent.toLowerCase());
        if (chromebrowser || safaribrowser)
            if(evt.target && evt.target.parentElement != null && evt.target.parentElement.parentElement != null && evt.target.parentElement.parentElement.id != null && evt.target.parentElement.parentElement.id == "themebutton")
            
            if (evt.target && evt.target.parentElement!=null && evt.target.parentElement.parentElement!=null && evt.target.parentElement.parentElement.id != null && evt.target.parentElement.parentElement.id == "themebutton")
                ele = true;        
        //if ($(window).width() < 900 && $("#Res-prodnav").hasClass("selectIt")) {
        //    $(".product-naviation").removeClass("hideIt");
        //    $("#Res-prodnav").removeClass("selectIt");
        //    $(".product-naviation").attr("style", "margin-left:" + ($(window).width() - 150) + "px;");
        //}
        //else
        //    $(".product-naviation").addClass("hideIt");
        
        if (evt.target.nodeName != "INPUT" && evt.target.nodeName != "BUTTON" && !$(evt.target).hasClass("sbheading") && !$(evt.target).hasClass("slidepanel-nav") && !$(evt.target).parents(".accordion-panel").length) {
            samplelisthide();
        }
    });

    window.setTimeout(function () {
        var waitingPopup = $(".e-waitingpopup.e-js"), timeout;
        if (waitingPopup.length > 0) {
            $(".scrollit").scroll(function () {
                var waitingObj = $(".e-waitingpopup.e-js").data("ejWaitingPopup");
                if (waitingObj && waitingObj.model.showOnInit) {
                    if (timeout) clearTimeout(timeout);
                    timeout = setTimeout(function () { waitingObj.refresh(); }, 20);
                }
            });
        }
    }, 10);

    resizeMenu();
	customizeSample();
      
});


function preparetheme() {
    var themename = "";
    if (window.theme.indexOf('dark') != -1 && window.themevarient != 'light')
        window.themevarient = "dark";
    if (window.theme.indexOf('gradient') != -1 && window.themestyle != 'flat')
        window.themestyle = "gradient";
    if (window.themevarient == "dark") {
        if (window.themestyle == "gradient")
            themename = window.themestyle + window.themecolor + window.themevarient;
        else
            themename = (window.themecolor != "") ? window.themecolor + window.themevarient : window.themestyle + window.themevarient;

    }
    else {
        if (window.themestyle == "gradient")
            themename = window.themestyle + window.themecolor;
        else
            themename = (window.themecolor != "") ? window.themecolor : window.themestyle;
    }
    if (window.theme.indexOf("bootstrap") >= 0) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "light";
    }
    if (window.theme.indexOf("high-contrast-01") >= 0) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "dark";
    }
    if (window.theme.indexOf("high-contrast-02") >= 0) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "dark";
    }
    if (window.theme.indexOf("material") >= 0) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "light";
    }
    if (window.theme.indexOf("office-365") >= 0) {
        themename = window.theme;
        window.themestyle = "flat";
        window.themevarient = "light";
    }
    window.theme = themename;
}

function updateTheme(selcolor) {
    replacebg(window.themevarient == "dark");
    replaceTheme();
}
function refreshdata() {
    var Mainlist = [];
    var mulsamples = [];

    $(GroupingList).each(function () {
        Mainlist[this] = [];
    });

    $(SamplesList).each(function (index1, sampleslist) {
        var temp = this;
        $(GroupingList).each(function () {
            if (temp["Group"] == this.toString()) {
                Mainlist[this.toString()].push(temp);
                return false;
            }
        });

    });
    $(GroupingList).each(function () {
        $(Mainlist[this]).each(function () {
            mulsamples.push(this);
        });
    });
    return mulsamples;
}
function replaceTheme() {
    if ((window.theme.indexOf("lime") != -1) || (window.theme.indexOf('lime') != -1 && window.themecolor != 'azure' && window.themecolor != "saffron"))
        window.themecolor = 'lime';
    else if ((window.theme.indexOf('saffron') != -1) || (window.theme.indexOf('saffron') != -1 && window.themecolor != 'azure' && window.themecolor != 'lime'))
        window.themecolor = 'saffron';
    else if ((window.theme.indexOf('high-contrast-01') != -1))
        window.themecolor = 'high-contrast-01';
    else if ((window.theme.indexOf('high-contrast-02') != -1))
        window.themecolor = 'high-contrast-02';
    else if ((window.theme.indexOf('material') != -1))
        window.themecolor = 'material';
    else if ((window.theme.indexOf('office-365') != -1))
        window.themecolor = 'office-365';
    else if (window.theme.indexOf('bootstrap') != -1)
        window.themecolor = "bootstrap";
    else
        window.themecolor = "azure";
    var selcolor = (window.themecolor == "") ? "saffron" : window.themecolor;

    $(".htmljssamplebrowser").attr("class", "htmljssamplebrowser " + selcolor);
    var urlread = window.location.toString();
    var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
    for (var i = 0; i < links.length; i++) {
        if (links[i].href.indexOf("ej.theme.min.css") != -1) {
            var cssref = links[i].href,serverconfig = cssref.substr(0, cssref.indexOf("Content")-1),
			fileref = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + themes[theme] + '" />');
            if (window.theme == "bootstrap") {
                var corefile = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + core[theme] + "ej.widgets.core.bootstrap.min.css" + '" />');
                $(corefile).insertBefore(links[i]);
                if ($(".e-prop").length) $(".e-prop").addClass("e-bootstrap");
            }
            else {
                if (links[i-1].href.indexOf("ej.widgets.core.bootstrap.min.css") != -1)
                    $(links[i - 1]).remove();
                if ($(".e-prop").length && $(".e-prop").hasClass("e-bootstrap")) $(".e-prop").removeClass("e-bootstrap");
            }
            if (window.theme == "material") {
				if (links[i - 1].href.indexOf("ej.widgets.core.min.css") != -1 || links[i - 1].href.indexOf("ej.widgets.core.office-365.min.css") != -1 || links[i - 1].href.indexOf("ej.widgets.core.bootstrap.min.css") != -1 )
                    $(links[i - 1])[0].href = serverconfig +'/Content/ejthemes/ej.widgets.core.material.min.css';
                if ($(".e-prop").length) $(".e-prop").addClass("e-material");
				$("body").addClass("material");
            }
            else {
                if (links[i - 1].href.indexOf("ej.widgets.core.material.min.css") != -1 )
                    $(links[i - 1])[0].href = serverconfig +'/Content/ejthemes/ej.widgets.core.min.css';
                if ($(".e-prop").length && $(".e-prop").hasClass("e-material")) $(".e-prop").removeClass("e-material");
				$("body").removeClass("material");
            }
            if (window.theme == "office-365") {
                if (links[i - 1].href.indexOf("ej.widgets.core.min.css") != -1 || links[i - 1].href.indexOf("ej.widgets.core.material.min.css") != -1 || links[i - 1].href.indexOf("ej.widgets.core.bootstrap.min.css") != -1 )
                    $(links[i - 1])[0].href = serverconfig +'/Content/ejthemes/ej.widgets.core.office-365.min.css';
                if ($(".e-prop").length) $(".e-prop").addClass("e-ofice-365");
				$("body").addClass("office-365");
            }
            else {
                if (links[i - 1].href.indexOf("ej.widgets.core.office-365.min.css") != -1)
                    $(links[i - 1])[0].href = serverconfig +'/Content/ejthemes/ej.widgets.core.min.css';
                if ($(".e-prop").length && $(".e-prop").hasClass("e-office-365")) $(".e-prop").removeClass("e-office-365");
				$("body").removeClass("office-365");
            }
            $(fileref).insertAfter(links[i]);
            $(links[i]).remove();
        }
        else if (links[i].href.indexOf("ej.reportdesigner.theme.min.css") != -1) {
            var cssref = links[i].href, serverconfig = cssref.substr(0, cssref.indexOf("Content") - 1),
			fileref = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + rptDesignerThemes[theme] + '" />');
            if (window.theme == "bootstrap") {
                var corefile = $('<link rel="stylesheet" type="text/css" href="' + serverconfig + core[theme] + "ej.reportdesigner.core.bootstrap.min.css" + '" />');
                $(corefile).insertBefore(links[i]);
                if ($(".e-prop").length) $(".e-prop").addClass("e-bootstrap");
            }
            else {
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.bootstrap.min.css") != -1)
                    $(links[i - 1]).remove();
                if ($(".e-prop").length && $(".e-prop").hasClass("e-bootstrap")) $(".e-prop").removeClass("e-bootstrap");
            }
            if (window.theme == "material") {
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.min.css") != -1 || links[i - 1].href.indexOf("ej.reportdesigner.core.office-365.min.css") != -1 || links[i - 1].href.indexOf("ej.reportdesigner.core.bootstrap.min.css") != -1)
                    $(links[i - 1])[0].href = serverconfig + '/Content/ejthemes/ej.reportdesigner.core.material.min.css';
                if ($(".e-prop").length) $(".e-prop").addClass("e-material");
                $("body").addClass("material");
            }
            else {
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.material.min.css") != -1)
                    $(links[i - 1])[0].href = serverconfig + '/Content/ejthemes/ej.reportdesigner.core.min.css';
                if ($(".e-prop").length && $(".e-prop").hasClass("e-material")) $(".e-prop").removeClass("e-material");
                $("body").removeClass("material");
            }
            if (window.theme == "office-365") {
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.min.css") != -1 || links[i - 1].href.indexOf("ej.reportdesigner.core.material.min.css") != -1 || links[i - 1].href.indexOf("ej.reportdesigner.core.bootstrap.min.css") != -1)
                    $(links[i - 1])[0].href = serverconfig + '/Content/ejthemes/ej.reportdesigner.core.office-365.min.css';
                if ($(".e-prop").length) $(".e-prop").addClass("e-ofice-365");
                $("body").addClass("office-365");
            }
            else {
                if (links[i - 1].href.indexOf("ej.reportdesigner.core.office-365.min.css") != -1)
                    $(links[i - 1])[0].href = serverconfig + '/Content/ejthemes/ej.reportdesigner.core.min.css';
                if ($(".e-prop").length && $(".e-prop").hasClass("e-office-365")) $(".e-prop").removeClass("e-office-365");
                $("body").removeClass("office-365");
            }
            $(fileref).insertAfter(links[i]);
            $(links[i]).remove();
        }
    }
        window.setTimeout(function () {
            if ($(".cols-sample-area").find(".e-rte.e-js").length) $(".cols-sample-area").find(".e-rte.e-js").data("ejRTE")._setIframeHeight();
            if ($(".cols-sample-area").find(".e-fileexplorer.e-js").length) $(".cols-sample-area").find(".e-fileexplorer.e-js").data("ejFileExplorer").adjustSize();
            if ($(".cols-sample-area").find(".e-schedule.e-js").length) $(".cols-sample-area").find(".e-schedule.e-js").data("ejSchedule").refresh();
            var slider = $(".cols-sample-area").find(".e-slider.e-js");
            if (slider.length) {
            for (var i = 0; i < slider.length; i++) {
                var sliderObj = $(slider[i]).data("ejSlider");
                if (sliderObj.model.showScale && !sliderObj.model.showButtons) {
                    sliderObj._destroyScale();
                    sliderObj._renderScale(true);
                }
                if (sliderObj.model.showButtons) {
                    sliderObj.option("showButtons", false);
                    sliderObj.option("showButtons", true);
                }
            }
        }
    }, 500);
    resetCookies();
}
function customizeSample(){
 //gauge chart and others
 var urlread = window.location.toString();
if (urlread.toLowerCase().indexOf("gauge") >= 0) {
        loadGaugeTheme();
    }
    else if ((urlread.indexOf("chart") >= 0) || (urlread.indexOf("Client") >= 0) || (urlread.indexOf("rangenavigator") >= 0)) {
        loadTheme(undefined);
    }
    else if (urlread.indexOf("sunburst") >= 0) {
        loadSunBurstTheme();
    }
    else if (urlread.indexOf("graph") >= 0) {
        loadBulletTheme();
    }
    else if (urlread.indexOf("TreeGrid/Adaptive") >= 0 || urlread.indexOf("treegrid/adaptive") >= 0) {
        loadTreeGridFrameTheme();
    }
    else if (urlread.indexOf("Grid/Adaptive") >= 0 || urlread.indexOf("grid/adaptive") >= 0) {
        loadGridFrameTheme();
    }
    else if (urlread.indexOf("KanbanBoard/Adaptive") >= 0 || urlread.indexOf("kanbanboard/adaptive") >= 0) {
        loadKanbanFrameTheme();
    }
    else if (urlread.indexOf("schedule/adaptive") >= 0) {
        loadScheduleFrameTheme();
    }
    else if (urlread.indexOf("Ribbon/Adaptive") >= 0 || urlread.indexOf("ribbon/adaptive") >= 0) {
        loadRibbonFrameTheme();
    }
    else if (urlread.indexOf("pivotgrid") >= 0) {
        loadPivotGridFrameTheme();
	}
	else if (urlread.indexOf("pivotclient") >= 0) {
        loadPivotClientFrameTheme();
    } 
	
}
function replacebg(enable) {
    if (enable)
        $("body").addClass("darktheme");
    else
        $("body").removeClass("darktheme");
}

function themebtnClick(args) {
    var color;
    if (args.ID == 1) {
        var $btnelement = $(window).width() <= 979 ? $("#res_themebutton") : $("#themebutton");
        var pos = $btnelement.offset();
        var left = $btnelement.width() - $(".e-custom-theme .e-horizontal .e-list>ul").width();
        $(".e-custom-theme .e-horizontal .e-list>ul").css('left', left);
    } else {        
        this.element.find('li.e-active').removeClass('e-active');
        $("#themebutton >li >a > .e-icon:first").removeClass('azure').removeClass('lime').removeClass('saffron');
        $("#res_themebutton >li >a > .e-icon:first").removeClass('azure').removeClass('lime').removeClass('saffron');
        if ((args.text).toLowerCase().indexOf("bootstrap") !== -1) {
            window.themecolor = "azure";
            window.theme = "bootstrap";
            window.themevarient = "light"
            color = window.theme;
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }
        else if ((args.text).toLowerCase().indexOf("office-365") !== -1) {
            window.themecolor = "office-365";
            window.theme = "office-365";
            window.themevarient = "light"
            color = window.theme;
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }
        else if ((args.text).toLowerCase().indexOf("material") !== -1) {
            window.themecolor = "material";
            window.theme = "material";
            window.themevarient = "light"
            color = window.theme;
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }
        else if ((args.text).toLowerCase().indexOf("high-contrast-02") !== -1) {
            window.themecolor = "high-contrast-02";
            window.theme = "high-contrast-02";
            window.themevarient = "dark"
            color = window.theme;
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }
        else if ((args.text).toLowerCase().indexOf("high-contrast-01") !== -1) {
            window.themecolor = "high-contrast-01";
            window.theme = "high-contrast-01";
            window.themevarient = "dark"
            color = window.theme;
            $("#themebutton >li >a > .e-icon:first").addClass("azure");
            $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
        }
        else {
            if ((args.text.toLowerCase().indexOf("gradient") !== -1)) window.themestyle = "gradient";
            else window.themestyle = "flat";
            if ((args.text).toLowerCase().indexOf("dark") !== -1) window.themevarient = "dark";
            else window.themevarient = "light";
            if ((args.text).toLowerCase().indexOf("azure") !== -1) {
                window.themecolor = window.theme = "azure";
                $("#themebutton >li >a > .e-icon:first").addClass("azure");
                $("#res_themebutton >li >a > .e-icon:first").addClass("azure");
            }
            else if ((args.text).toLowerCase().indexOf("lime") !== -1) {
                window.themecolor = window.theme = "lime";
                $("#themebutton >li >a > .e-icon:first").addClass("lime");
                $("#res_themebutton >li >a > .e-icon:first").addClass("lime");
            }
            else if ((args.text).toLowerCase().indexOf("saffron") !== -1) {
                window.themecolor = window.theme = "saffron";
                $("#themebutton >li >a > .e-icon:first").addClass("saffron");
                $("#res_themebutton >li >a > .e-icon:first").addClass("saffron");
            }
            color = window.themecolor;
        }
        preparetheme();
        resetCookies();
		location.reload();  
        $(args.element).addClass("e-active");
    }
}

$("#samplefile").on('load',function (e) {
    $(document.getElementById("samplefile").contentWindow.document).click(function (e) {
        samplelisthide();
    });
});

function samplelisthide() {
    if ($(window).width() < 979) {
        if (window.isTransitionSupported) $('.accordion-panel').css({ left: '-250px' });
        else $(".accordion-panel").animate({ "left": "-250px" }, 350);
    } else { 
		if (window.isTransitionSupported) $('.accordion-panel').css({ left: '0px' });
        else $(".accordion-panel").animate({ "left": "0px" }, 350);
	}
}
function showTooltipbox() {
    var $btnelement = $(window).width() <= 979 ? $("#res_themebutton") : $("#themebutton");
    var pos = $btnelement.offset();
    var left = $("#sbtooltipbox_wrapper").width() + pos.left;
    if (($(".samplecontainerparent").length==0) || left > $(".samplecontainerparent").width())
        left = (pos.left + ($btnelement.width() / 2)) - $("#sbtooltipbox_wrapper").width();
    else
        left = pos.left;
    $("#sbtooltipbox").ejDialog("option", "position", { X: left + 10, Y: pos.top + $btnelement.height() + 7 });
    $("#sbtooltipbox").ejDialog("open");
    setTimeout(function () {
        $("#sbtooltipbox").ejDialog("close");
    }, 3000);
}

function themeButtonSelect() {
    //
    if ((readCookie('themeName') != null) && (readCookie('themeName') != ""))
        window.theme = readCookie('themeName');
    if ((readCookie('themeColor') != null) && (readCookie('themeColor') != ""))
        window.themecolor = readCookie('themeColor');
    if ((readCookie('themeStyle') != null) && (readCookie('themeStyle') != ""))
        window.themestyle = readCookie('themeStyle');
    if ((readCookie('themeVarient') != null) && (readCookie('themeVarient') != ""))
        window.themevarient = readCookie('themeVarient');
    if ((window.theme.indexOf("lime") != -1) || (window.theme.indexOf('lime') != -1)) window.themecolor = 'lime';    
    else if ((window.theme.indexOf("saffron") != -1) || (window.theme.indexOf('saffron') != -1)) window.themecolor = 'saffron';
    else if ((window.theme.indexOf("bootstrap") != -1) || (window.location.hash.indexOf('bootstrap') != -1)) window.themecolor = 'bootstrap';
	else if ((window.theme.indexOf("high-contrast-01") != -1) || (window.theme.indexOf('high-contrast-01') != -1)) 
        window.themecolor = 'highcontrast01';
	else if ((window.theme.indexOf("high-contrast-02") != -1) || (window.theme.indexOf('high-contrast-02') != -1)) 
        window.themecolor = 'highcontrast02';
	else if ((window.theme.indexOf("office-365") != -1) || (window.theme.indexOf('office-365') != -1)) 
        window.themecolor = 'office365';
	else if ((window.theme.indexOf("material") != -1) || (window.theme.indexOf('material') != -1)) 
        window.themecolor = 'material';
    else window.themecolor = 'azure';
}

//next previous location
function prevnext(name, cursample, navloc) {
    var cursampitem, prevsampitem, nextsampitem, cursamplist, prevsamplist, nextsamplist, chx, tempsample, cursampquery, anchref, newlist = refreshdata();
    for (i = 0; i < newlist.length; i++) {
        chx = newlist[i].id;
        if (chx.toLowerCase() == name.toLowerCase()) {
            cursampitem = newlist[i];
            prevsampitem = newlist[i - 1];
            nextsampitem = newlist[i + 1];
            break;
        }
    }
    cursamplist = retrivesamplkist(cursampitem);
    prevsamplist = retrivesamplkist(prevsampitem);
    nextsamplist = retrivesamplkist(nextsampitem);
    if (navloc == "next") {
        for (i = 0; i < cursamplist.length; i++) {
            if (cursamplist[i].action == cursample) {
                if (i == cursamplist.length - 1) {
                    if (nextsamplist.length == 0) {
                        anchref = "/Introduction/Index";
                    }
                    else {
                        anchref = "/" + nextsamplist[0].controller + "/" + nextsamplist[0].action;
                    }
                }
                else if (i < cursamplist.length - 1) {
                    anchref = "/" + cursamplist[i + 1].controller + "/" + cursamplist[i + 1].action;
                }
                break;
            }
        }
    }
    else if (navloc == "prev") {
        for (i = 0; i < cursamplist.length; i++) {
            if (cursamplist[i].action == cursample) {
                if (i == 0) {
                    if (prevsamplist.length == 0) {
                        anchref = "/Introduction/Index";
                    }
                    else {
                        anchref = "/" + prevsamplist[prevsamplist.length - 1].controller + "/" + prevsamplist[prevsamplist.length - 1].action;
                    }
                }
                else if (i > 0 && i < cursamplist.length) {
                    anchref = "/" + cursamplist[i - 1].controller + "/" + cursamplist[i - 1].action;
                }
                break;
            }
        }
    }
    return anchref.toLowerCase();
}
function retrivesamplkist(cursampitem) {
    var cursamplist = [];
    if (cursampitem && !ej.isNullOrUndefined(cursampitem.samples)) {
        for (i = 0; i < cursampitem.samples.length; i++) {
            if (cursampitem.samples[i].childcount == "0") {
                cursamplist.push(cursampitem.samples[i]);
            }
            else if (cursampitem.samples[i].samples.length != 0) {
                for (j = 0; j < cursampitem.samples[i].samples.length; j++) {
                    if (cursampitem.samples[i].samples[j].childcount == "0")
                        cursamplist.push(cursampitem.samples[i].samples[j]);
                }
            }
        }
    }
    return cursamplist;
}
//cookies
function createCookies(name, value, days) {
    var expires;

    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (3 * 60 * 1000));
        expires = "; expires=" + date.toGMTString();
    } else {
        expires = "";
    }
    document.cookie = escape(name) + "=" + escape(value) + expires + "; path=/";
}

function readCookie(name) {
    var nameEQ = escape(name) + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) === ' ') c = c.substring(1, c.length);
        if (c.indexOf(nameEQ) === 0) return unescape(c.substring(nameEQ.length, c.length));
    }
    return null;
}

function eraseCookie(name) {
    createCookies(name, "", -1);
}




/* Launching Other Products*/
function viewdemo(args) {
    var text = 'Handler/StartDevServer.ashx', product = $.trim(args.text).toLowerCase(), prot = window.location.protocol, hostname = window.location.host;
    var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
    var serverconfig = links[0].href.substr(0, links[0].href.indexOf("Content") - 1);
    if (typeof (iisPrefixLink) != "undefined" && iisPrefixLink != null) {
        if (product == "ionic")  window.open("http://localhost:" + window.location.port + "/sfionicjssamplebrowser","_blank");
        else return false;
    }
    else if (product == "ionic") {
        var path = "JavaScript\\ionic app";
        $.ajax({
            async: false,
            url: serverconfig + "/" + text + "?product=" + product + "&path=" + path,
            success: function (data) {
                if (product == "ionic") window.open(data + "/index.html?platform=mvc", "_blank");
            }
        });
    }
}
//autocomplete
function onSelectSearchItem(args) {
    var links = $(document.head || document.getElementsByTagName('head')[0]).find("link");
    var serverconfig = links[0].href.substr(0, links[0].href.indexOf("Content") - 1);
    var url = serverconfig+ "/" + args.key;
    window.location = url.toString().toLowerCase();
    if (window.width < 981) {
		
		setTimeout(function(){
			if ($('.accordion-panel').css("display")=="block") {
			$('.content-container-fluid .row > .navigation').addClass('collapsePanel');
            $('.accordion-panel').removeClass("expandPanel");
			$('.accordion-panel').css("display","none !important");
			}

		},500);
	}
}

function resetCookies() {
    eraseCookie("themeName");
    createCookies('themeName', window.theme, 1);
    eraseCookie("themeColor");
    createCookies('themeColor', window.themecolor, 1);
    eraseCookie("themeStyle");
    createCookies('themeStyle', window.themestyle, 1);
    eraseCookie("themeVarient");
    createCookies('themeVarient', window.themevarient, 1);
}

//Downlink function 
function downlinkclick(e){
	window.open("https://www.syncfusion.com/downloads/aspnetmvc","_blank");
}

//themestudio function 
function paintTheme(e){
	window.open("https://js.syncfusion.com/themestudio/","_blank");
}

//EJ2 Sample 
function ej2Switch(e){
    document.getElementById('ej2popup').style.display = 'none';
	window.open("https://ej2.syncfusion.com/home/aspnetmvc.html?utm_source=ej1&utm_medium=banner&utm_campaign=migrate","_blank");
}

function goToSyncfusion(e) {
    window.open("https://www.syncfusion.com", "_blank");
}

function ShowPanelClick(args) {
    if (!removeGroup) {
        $(".accordion >.SB-group").each(function (i, item) {
            if (item.children.length == $(item).children(".responsive-viewable").length)
                $(item.previousElementSibling).addClass("responsive-viewable");

        });
        removeGroup = true;
    }
    if (isTransitionSupported) $('.accordion-panel').css("left", "0px");
    else $(".accordion-panel").animate({ "left": "0px" }, 350);
}
function ionicSwitch(args) {
    //viewdemo({ text: "ionic" });
    window.open("https://js.syncfusion.com/demos/mobile/", "_blank");
}
window.menuData = [{ id: 1, text: "", parentId: null, spriteCssClass: "e-icon" },
                   { id: "flatazure", text: "Flat-Azure", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/flat_azure.png" },
                   { id: "flatazuredark", text: "Flat-Azure-Dark", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/flat_azure_dark.png" },
                   { id: "flatlime", text: "Flat-Lime", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/flat_lime.png" },
                   { id: "flatlimedark", text: "Flat-Lime-Dark", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/flat_lime_dark.png" },
                   { id: "flatsaffron", text: "Flat-Saffron", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/flat_saffron.png" },
                   { id: "flatsaffrondark", text: "Flat-Saffron-Dark", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/flat_saffron_dark.png" },
                   { id: "gradientazure", text: "Gradient-Azure", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/gradient_azure.png" },
                   { id: "gradientazuredark", text: "Gradient-Azure-Dark", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/gradient_azure_dark.png" },
                   { id: "gradientlime", text: "Gradient-Lime", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/gradient_lime.png" },
                   { id: "gradientlimedark", text: "Gradient-Lime-Dark", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/gradient_lime_dark.png" },
                   { id: "gradientsaffron", text: "Gradient-Saffron", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/gradient_saffron.png" },
                   { id: "gradientsaffrondark", text: "Gradient-Saffron-Dark", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/gradient_saffron_dark.png" },
                   { id: "flatbootstrap", text: "Bootstrap", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/bootstrap.png" },
                   { id: "highcontrast01", text: "High-Contrast-01", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/high-contrast-01.png" },
                   { id: "highcontrast02", text: "High-Contrast-02", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/high-Contrast-02.png" },
                   { id: "material", text: "Material", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/material.png" },
                   { id: "office365", text: "Office-365", parentId: 1, imageUrl: getAbsoluteURL() + "Content/images/themeicon/office-365.png" }
];
// To get cookie value
function getCookieValue(cookieName) {
	var name = cookieName + "=";
	var decodedCookie = decodeURIComponent(document.cookie);
	var cookieValues = decodedCookie.split(';');
	for (var i = 0; i < cookieValues.length; i++) {
		var cookie = cookieValues[i];
		while (cookie.charAt(0) == ' ') {
			cookie = cookie.substring(1);
		}
		if (cookie.indexOf(name) == 0) {
			return cookie.substring(name.length, cookie.length);
		}
	}
	return "";
}
