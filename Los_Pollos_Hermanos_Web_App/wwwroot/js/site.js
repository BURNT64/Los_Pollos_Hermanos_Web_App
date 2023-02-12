// Get the search input element and the search filter value
// Get the menu list and its items
// Loop through all list items and hide those that don't match the search query
 //the scripts at the bottom are for jQuery and Bootstrap

<>
    <script>
        function myFunction() { }
        var input, filter, ul, li, a, i;
        input = document.getElementById("mySearch");
        filter = input.value.toUpperCase();
        ul = document.getElementById("myMenu");
        li = ul.getElementsByTagName("li");
        for (i = 0; i <li.length />; i++) {a = li[i].getElementsByTagName("a")[0]};
        if (a.innerHTML.toUpperCase().indexOf(filter) > -1) {li[i].style.display = ""};
    } else {li[i].style.display = "none"};
    }
  }
}
    </script>

    <script src="~/lib/jquery/dist/jquery.min.js"></script>
    <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
    <script src="~/js/site.js" asp-append-version="true"></script></>