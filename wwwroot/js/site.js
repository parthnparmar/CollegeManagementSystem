// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Global site scripts
document.addEventListener("DOMContentLoaded", () => {
    console.log("Site scripts loaded");
});

// Simple sidebar toggle
const sidebarToggle = document.getElementById("sidebarToggle");
if (sidebarToggle) {
    sidebarToggle.addEventListener("click", () => {
        document.body.classList.toggle("sidebar-collapsed");
    });
}
