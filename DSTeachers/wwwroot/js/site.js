// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let playing = '';

function toggleAudio(id) {
    audio = document.getElementById('audio' + id);
    icone = document.getElementById('icone' + id);
    if ((playing != '') && (id != playing)) {
        stop(playing);
    }
    if (audio.currentTime == 0 || (playing == '')) {
        play(id)
    } else {
        pause(id)
    }
}

function play(id) {
    audio = document.getElementById('audio' + id);
    icone = document.getElementById('icone' + id);
    playing = id;
    icone.classList.remove('bi-play-circle');
    icone.classList.add('bi-pause-circle');
    audio.play();
}

function pause(id) {
    audio = document.getElementById('audio' + id);
    icone = document.getElementById('icone' + id);
    playing = '';
    icone.classList.remove('bi-pause-circle');
    icone.classList.add('bi-play-circle');
    audio.pause();
}

function stop(id) {
    pause(id);
    audio = document.getElementById('audio' + id);
    audio.currentTime = 0;
}