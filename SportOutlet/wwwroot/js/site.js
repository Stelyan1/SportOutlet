// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

<script>
    document.querySelectorAll(".size-btn").forEach(btn => {
        btn.addEventListener("click", function () {
            document.querySelectorAll(".size-btn").forEach(b => b.classList.remove("active"));
            this.classList.add("active");
        });
    });
</script>
