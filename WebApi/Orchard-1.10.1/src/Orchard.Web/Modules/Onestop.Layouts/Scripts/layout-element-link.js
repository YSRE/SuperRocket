﻿(window.layoutPreviewers = window.layoutPreviewers || {})
    .link = function (description, target) {
        var preview = $("<a href=\"#\"/>")
            .html(description.attr("default") || description.attr("title") || "Lorem Ipsum")
            .css({
                "font-family": description.attr("font"),
                "font-size": description.attr("size")
            })
            .addClass(description.attr("class") || "");
        if (typeof description.attr("left") !== "undefined" || typeof description.attr("top") !== "undefined") {
            preview.css({
                position: "absolute",
                top: description.attr("top"),
                left: description.attr("left"),
            });
        }
        target.append(preview);
        return preview;
    };
