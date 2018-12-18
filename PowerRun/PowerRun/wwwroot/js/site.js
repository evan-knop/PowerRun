// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

AddRun = new function () {
    this.FillPace = function () { 
        var time = $('#Time').val()
        var distance = $('#Distance').val();

        var timeArray = time.split(':', 3);
        console.log(timeArray[0]);
        console.log(timeArray[1]);
        console.log(timeArray[2]);

        var timeInSeconds = (Number((timeArray[0]) * 3600) + Number((timeArray[1]) * 60) + Number((timeArray[2])));
        timeInSeconds = timeInSeconds / distance;

        var paceHours = (timeInSeconds / 3600);
        var paceMins = ((timeInSeconds / 60) % 60);
        var paceSecs = (timeInSeconds % 60);

        paceHours = parseInt(paceHours);
        paceMins = parseInt(paceMins);
        paceSecs = parseInt(paceSecs);


        console.log(paceHours + " - Pace Hours");
        console.log(paceMins + " - Pace Mins");
        console.log(paceSecs + " - Pace Secs");

        $('#Pace').val(paceHours+":"+paceMins+":"+paceSecs);
    }
}