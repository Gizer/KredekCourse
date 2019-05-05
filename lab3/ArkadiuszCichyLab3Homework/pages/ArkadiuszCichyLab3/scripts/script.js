var howManyTrials = 5;
var reactionTimes = [];
var trialStart = 0;
var trialEnd = 0;
var trialCounter = 0;
var randomTimer = 0;

function ResetTimes() {
    for (var i = 0; i < howManyTrials; i++) {
        reactionTimes[i] = 0;
    }
}

function StartIdle() {
    document.getElementById("button").src = "images/buttonBlue.png";
    document.getElementById("button").onclick = function () {
        FalseStart();
    };
    if (trialCounter > howManyTrials - 1) {
        ResetTimes();
        trialCounter = 0;
        UpdateTable(0);
    }
    trialCounter++;
    randomTimer = Math.floor(Math.random() * 1000 + 500);
    setTimeout(StartTimer, randomTimer);
}

function StartTimer() {
    document.getElementById("button").src = "images/buttonGreen.png";
    document.getElementById("button").onclick = function () {
        StopTimer();
    };
    trialStart = new Date().getTime();
}

function FalseStart() {
    trialStart = new Date().getTime() - 1000;
    StopTimer();
}

function StopTimer() {
    document.getElementById("button").src = "images/buttonRed.png";
    document.getElementById("button").onclick = function () {
        StartIdle();
    };
    var average = 0;
    trialEnd = new Date().getTime() - trialStart;
    reactionTimes[trialCounter - 1] = trialEnd;

    UpdateTable(average);
    if (trialCounter > howManyTrials - 1) {
        for (var i = 0; i < trialCounter; i++) {
            average += reactionTimes[i];
        }
        average = Math.round(average / howManyTrials);
        UpdateTable(average);
        alert("Your average reaction time: " + average + " ms");
    }
}

function UpdateTable(average) {
    document.getElementById("timesTable").innerHTML = "";
    document.getElementById("timesTable").innerHTML +=
        '<tr>' +
        '<th> Attempt No. </th>' +
        '<th Reaction time </th>' +
        '</tr>';
    for (var i = 0; i < howManyTrials; i++) {
        document.getElementById("timesTable").innerHTML +=
            '<tr>' +
            '<td> Attempt ' + (i + 1) + ' </td>' +
            '<td>' +
            reactionTimes[i] + ' ms</td>' +
            '</tr>';
    }
    document.getElementById("timesTable").innerHTML +=
        '<tr>' +
        '<td> Average </td>' +
        '<td> ' + average + ' ms</td>' +
        '</tr>';
}