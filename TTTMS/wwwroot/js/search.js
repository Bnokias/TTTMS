function searchEmployees() {
    var searchInput = $('#searchInput').val().toLowerCase();
    var employeeTable = $('#employeeTable');

    // Iterate through each row in the table
    employeeTable.find('tbody tr').each(function () {
        var currentRow = $(this);

        // Check if the search input matches any cell in the current row
        var matchFound = currentRow.find('td').filter(function () {
            return $(this).text().toLowerCase().indexOf(searchInput) !== -1;
        }).length > 0;

        // Show or hide the row based on the search result
        currentRow.toggle(matchFound);
    });
}
