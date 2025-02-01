document.addEventListener("DOMContentLoaded", function () {
    const currentPath = window.location.pathname;

    const navLinks = document.querySelectorAll('.nav-link');

    navLinks.forEach(link => {
        if (link.href === window.location.href) {
            link.classList.add('active');
        }
    });
});


//Get the button
let mybutton = document.getElementById("btn-back-to-top");

// When the user scrolls down 20px from the top of the document, show the button
window.onscroll = function () {
    scrollFunction();
};

function scrollFunction() {
    if (
        document.body.scrollTop > 20 ||
        document.documentElement.scrollTop > 20
    ) {
        mybutton.style.display = "block";
    } else {
        mybutton.style.display = "none";
    }
}
// When the user clicks on the button, scroll to the top of the document
mybutton.addEventListener("click", backToTop);

function backToTop() {
    document.body.scrollTop = 0;
    document.documentElement.scrollTop = 0;
}

//document.addEventListener("contextmenu", function (event) {
//    event.preventDefault();
//});

//document.addEventListener("keydown", function (event) {
//    if (event.key === "F12" || (event.ctrlKey && event.shiftKey && event.key === "I")) {
//        event.preventDefault();
//    }
//});

document.addEventListener("DOMContentLoaded", () => {
    const loader = document.getElementById("globalLoader");
    if (loader) {
        // Add the 'hidden' class to fade out the loader
        loader.classList.add("hidden");

        // After the fade-out transition, completely hide the loader
        setTimeout(() => {
            loader.classList.add("hidden-completely");
        }, 500); // Match the fade-out duration in CSS (0.5s)
    }
});

// Disable keyboard shortcuts (Ctrl + P, Ctrl + S, etc.)
document.addEventListener('keydown', (e) => {
    // Disable PrintScreen key (usually 'PrtScn', 'Print', 'F12' etc.)
    if (e.key === 'PrintScreen' || e.key === 'F12') {
        e.preventDefault();
    }

    // You can block other key combinations like Ctrl+S (for saving a page) as well
    if ((e.ctrlKey && e.key === 'p') || (e.ctrlKey && e.key === 's')) {
        e.preventDefault();
    }
});

document.querySelectorAll('img').forEach(img => {
    img.addEventListener('dragstart', function (e) {
        e.preventDefault();
    });
});

document.addEventListener('keydown', function(e) {
    // Block Ctrl+C, Cmd+C, Ctrl+X (cut), Ctrl+V
    if ((e.ctrlKey || e.metaKey) && (e.key === 'c' || e.key === 'x' || e.key === 'v')) {
        e.preventDefault();
    }
});
// Detect scroll event
window.addEventListener("scroll", function () {
    var navbar = document.querySelector(".navbar.sticky-top");

    // Check if the user has scrolled down
    if (window.scrollY > 50) {  // Adjust this threshold as needed
        navbar.classList.add("scrolled");  // Apply the 'scrolled' class when scrolling
    } else {
        navbar.classList.remove("scrolled");  // Remove the 'scrolled' class when at the top
    }
});


document.addEventListener("DOMContentLoaded", function () {
    const elements = document.querySelectorAll(".animate-on-scroll");

    const observer = new IntersectionObserver(
        (entries) => {
            entries.forEach((entry) => {
                if (entry.isIntersecting) {
                    entry.target.classList.add("visible");
                }
            });
        },
        { threshold: 0.3 } // Trigger animation when 30% of the section is visible
    );

    elements.forEach((el) => observer.observe(el));
});
