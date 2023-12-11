// LayoutController.js

document.addEventListener('DOMContentLoaded', function () {
    hideLoadingOverlay(); // Hide the loading overlay when the DOM is fully loaded
});

function showLoadingOverlay() {
    closeSideMenu(); // Close the side menu when loading starts
    var loadingOverlay = document.getElementById("loadingOverlay");
    loadingOverlay.style.display = "block";
}

function hideLoadingOverlay() {
    var loadingOverlay = document.getElementById("loadingOverlay");
    loadingOverlay.style.display = "none";
}

// Hook into the navigation events to show/hide the loading overlay
document.addEventListener('click', function (event) {
    var targetElement = event.target || event.srcElement;

    // Check if the clicked element is a link
    if (targetElement.tagName === 'A') {
        showLoadingOverlay();
    }
});

document.addEventListener('readystatechange', function () {
    if (document.readyState === 'complete') {
        hideLoadingOverlay();
    }
});

function openSideMenu() {
    var sideMenu = document.getElementById("sideMenu");
    var content = document.getElementById("content");

    // Open the side menu
    sideMenu.style.width = "250px";

    // Resize the content area
    content.style.marginLeft = "250px";

    // Hide loading overlay when side menu is opened
    hideLoadingOverlay();
}

function closeSideMenu() {
    var sideMenu = document.getElementById("sideMenu");
    var content = document.getElementById("content");

    // Close the side menu
    sideMenu.style.width = "0";

    // Restore the original content size
    content.style.marginLeft = "40px";
}
