/// <reference path="/Scripts/canvas-vsdoc.js" />
/// <reference path="/Scripts/canvas-utils.js" />
(function () {
    var canvas = document.getElementById('circle'),
                 ctx = canvas.getContext('2d'),
                 x = 10,
                 y = 100,
                 radius = 10,
                 width = canvas.width,
                 height = canvas.height,
                 updateX = 5,
                 updateY = 5,
                 dir = 'DR';
    
    function draw() {
        ctx.clearRect(0, 0, 500, 300);
        ctx.beginPath();
        ctx.fillStyle = '#ff0000';
        ctx.arc(x, y, radius, 0, 2 * Math.PI);
        ctx.fill();
        ctx.closePath();

        if (dir == 'DR') {
            x += updateX;
            y += updateY;

            if (y === height - radius) {
                dir = 'UR';
                updateY *= -1;
            }

            if (x === width - radius) {
                dir = 'DL';
                updateX *= -1;
            }
        }
        else if (dir == 'UR') {
            x += updateX;
            y += updateY;

            if (y === radius) {
                dir = 'DR';
                updateY *= -1;
            }

            if (x === width - radius) {
                dir = 'UL';
                updateX *= -1;
            }
        }
        else if (dir == 'DL') {
            x += updateX;
            y += updateY;

            if (y === height - radius) {
                dir = 'UL';
                updateY *= -1;
            }

            if (x === radius) {
                dir = 'DR';
                updateX *= -1;
            }
        }
        else if (dir == 'UL') {
            x += updateX;
            y += updateY;

            if (y === radius) {
                dir = 'DL';
                updateY *= -1;
            }

            if (x === radius) {
                dir = 'UR';
                updateX *= -1;
            }
        }
    }

    function animate() {
        setInterval(draw, 20);
    }

    animate();
}())