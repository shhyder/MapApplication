

function OnReset() {
    jQuery(".headerArrow").html("");
    jQuery(".hidOrder").val("0");
    jQuery("input[type='text']").val("");
    GetList(1);
}


function checkClick(element) {
    hidVal = jQuery(element).find(".hidOrder").val();
    eleID = "." + jQuery(element).attr("id");
    switch (hidVal) {
        case "0":
            jQuery(eleID).find(".headerArrow").html("<img alt='right'  src='/images/asc.gif' />");
            jQuery(eleID).find(".hidOrder").val("1");
            break;
        case "1":
            jQuery(eleID).find(".headerArrow").html("<img alt='right'  src='/images/desc.gif' />");
            jQuery(eleID).find(".hidOrder").val("2");
            break;
        case "2":
            jQuery(eleID).find(".headerArrow").html("<img alt='right'  src='/images/asc.gif' />");
            jQuery(eleID).find(".hidOrder").val("1");
            break;
    }
    GetList(1);
}


function searchChange(element) {

    val = jQuery(element).val();
    eleID = "." + jQuery(element).attr("id");
    jQuery(eleID).val(val);
    GetList(1);
}

function searchChangeNumeric(evt, target, element) {
    var charCode = (evt.which) ? evt.which : evt.keyCode;
    var isnum = true;
    if (!evt.ctrlKey && charCode > 31 && (charCode < 48 || charCode > 57)) {
        isnum = false;
        if (evt.which) {
            evt.preventDefault();

        }
        else
            evt.returnValue = false;
    }
    return fireDefault(evt, target) && isnum;
}

function searchCheckedChange(element) {
    val = jQuery(element).attr("checked");
    eleID = "." + jQuery(element).attr("id");
    if (val) {
        jQuery(eleID).attr('checked', 'checked');
    }
    else {
        jQuery(eleID).removeAttr('checked');
    }
    GetList(1);
}




$(function() {
    //$(".mainTable").stickyTableHeaders();
});

/*! Copyright (c) 2011 by Jonas Mosbech - https://github.com/jmosbech/StickyTableHeaders 
MIT license info: https://github.com/jmosbech/StickyTableHeaders/blob/master/license.txt */

(function($) {
    $.StickyTableHeaders = function(el, options) {
        // To avoid scope issues, use 'base' instead of 'this'
        // to reference this class from internal events and functions.
        var base = this;

        // Access to jQuery and DOM versions of element
        base.$el = $(el);
        base.el = el;

        // Add a reverse reference to the DOM object
        base.$el.data('StickyTableHeaders', base);

        base.init = function() {
            base.options = $.extend({}, $.StickyTableHeaders.defaultOptions, options);

            base.$el.each(function() {
                var $this = $(this);
                $this.wrap('<div class="divTableWithFloatingHeader" style="position:relative"></div>');

                var originalHeader = $('thead:first', this);
                var clonedHeader = originalHeader.clone()

                clonedHeader.addClass('tableFloatingHeader');
                clonedHeader.css({
                    'position': 'fixed',
                    'top': 0,
                    'left': $this.css('margin-left'),
                    'display': 'none'
                });

                originalHeader.addClass('tableFloatingHeaderOriginal');

                originalHeader.before(clonedHeader);

                // enabling support for jquery.tablesorter plugin
                // forward clicks on clone to original
                $('th', clonedHeader).click(function(e) {
                    var index = $('th', clonedHeader).index(this);
                    $('th', originalHeader).eq(index).click();
                });
                $this.bind('sortEnd', function(e) { base.updateCloneFromOriginal(originalHeader, clonedHeader); });
            });

            base.updateTableHeaders();
            $(window).scroll(base.updateTableHeaders);
            $(window).resize(base.updateTableHeaders);
        };

        base.updateTableHeaders = function() {
            base.$el.each(function() {
                var $this = $(this);
                var $window = $(window);

                var fixedHeaderHeight = isNaN(base.options.fixedOffset) ? base.options.fixedOffset.height() : base.options.fixedOffset;

                var originalHeader = $('.tableFloatingHeaderOriginal', this);
                var floatingHeader = $('.tableFloatingHeader', this);
                var offset = $this.offset();
                var scrollTop = $window.scrollTop() + fixedHeaderHeight;
                var scrollLeft = $window.scrollLeft();

                if ((scrollTop > offset.top) && (scrollTop < offset.top + $this.height())) {
                    floatingHeader.css({
                        'top': fixedHeaderHeight,
                        'margin-top': 0,
                        'left': offset.left - scrollLeft,
                        'display': 'block'
                    });

                    base.updateCloneFromOriginal(originalHeader, floatingHeader);
                }
                else {
                    floatingHeader.css('display', 'none');
                }
            });
        };

        base.updateCloneFromOriginal = function(originalHeader, floatingHeader) {
            // Copy cell widths and classes from original header
            $('th', floatingHeader).each(function(index) {
                var $this = $(this);
                var origCell = $('th', originalHeader).eq(index);
                $this.removeClass().addClass(origCell.attr('class'));
                $this.css('width', origCell.width());
            });

            // Copy row width from whole table
            floatingHeader.css('width', originalHeader.width());
        };

        // Run initializer
        base.init();
    };

    $.StickyTableHeaders.defaultOptions = {
        fixedOffset: 0
    };

    $.fn.stickyTableHeaders = function(options) {
        return this.each(function() {
            (new $.StickyTableHeaders(this, options));
        });
    };

})(jQuery);


//]]>




jQuery(document).ready(function() {
        jQuery("#map-pane").ajaxStart(function() {
            var width = jQuery(this).width();
            var height = screen.height + (document.body.scrollTop * 2); //jQuery(this).height()
            jQuery("#map-loading").css({
                top: ((height / 2) - 25),
                left: ((width / 2) - 50)
            }).fadeIn(200);    // fast fade in of 200 mili-seconds
        }).ajaxStop(function() {
            jQuery("#map-loading", this).fadeOut(1000);    // slow fade out of 1 second
        });

        jQuery("#footer").pinFooter();
       
        jQuery(".mainTable").stickyTableHeaders();
});


//jQuery(window).load(function() {
//    jQuery("#footer").pinFooter();
//});

jQuery(window).resize(function() {
    jQuery("#footer").pinFooter();
});