const mainMenu = document.querySelector("#nav-list");
const toggler = document.querySelector("#toggle");
const hamburgerIcon = document.querySelector(".fa-bars");

toggler.addEventListener("click", function () {
    mainMenu.classList.toggle("active");

    if (hamburgerIcon.classList.contains("fa-bars")) {
        hamburgerIcon.classList.replace("fa-bars", "fa-times")
    } else {
        hamburgerIcon.classList.replace("fa-times", "fa-bars")
    }
})