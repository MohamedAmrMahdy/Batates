$(document).ready(function () {
    document.querySelector('body').addEventListener('mousemove', moveEyes);
});

function moveEyes(event) {
    console.log(event)
    const eyes = document.querySelectorAll(".eye");
    eyes.forEach((eye) => {
        let x = (eye.getBoundingClientRect().left) + (eye.clientWidth / 2);
        let y = (eye.getBoundingClientRect().top) + (eye.clientWidth / 2);

        let radian = Math.atan2(event.pageX - x, event.pageY - y);
        let rotaion = (radian * (180 / Math.PI) * -1) + 270;
        eye.style.transform = "rotate(" + rotaion + "deg)";
    });
}