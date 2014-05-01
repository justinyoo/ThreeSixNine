;"use strict";

(function ($) {
    $(document).ready(function () {
        getSha(); // #1
    });

    // Gets the latest commit ID of the gh-pages branch.
    var getSha = function() {
        var url = "https://api.github.com/repos/justinyoo/ThreeSixNine/git/refs/heads/gh-pages"; // #2
        $.ajax({
                type: "GET",
                url: url,
                dataType: "json"
            })
            .done(function(data) {
                getImages(data.object.sha); // #3
            });
    };

    // Gets the list of image files and put them into HTML elements.
    var getImages = function(sha) {
        var url = "https://api.github.com/repos/justinyoo/ThreeSixNine/git/trees/" + sha; // #4
        $.ajax({
                type: "GET",
                url: url,
                data: { "recursive": 1 },
                dataType: "json"
            })
            .done(function(data) {
                var ul = $("<ul></ul>");

                Enumerable.From(data.tree) // #5
                    .Where("$.type == 'blob'")
                    .OrderByDescending("$.path")
                    .Select("$.path")
                    .Where(function(p) {
                        return p.match(/^images\/.+\.png$/i) // #6
                    })
                    .ForEach(function(image, index) { // #7
                        $(ul).append(
                            $("<li></li>").append(
                                $("<img />").attr("src", image)
                        ));
                    });

                $("#main_content").append(ul); // #8
            });
    };
})(jQuery);
