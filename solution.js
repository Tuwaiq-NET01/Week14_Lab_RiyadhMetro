subwayLines = {
    Red: ["Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic"],
    Blue: ["Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj"],
    Green: ["Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra"],


    // Your solution here
    planTrip: function (initialLine, initialStop, finalLine, finalStop) {
        let trip = [];
        let tripAfterChange = [];
        let stopCount = 0;
        let intersection = "Salah Aldin";
        let startLine = initialLine[0].toUpperCase() + initialLine.slice(1); //To make initialLine NOT case sensetive 
        let endLine = finalLine[0].toUpperCase() + finalLine.slice(1); //To make finalLine NOT case sensetive
        if (startLine === endLine) {  //if trip is on the same line
            if (initialStop === finalStop) { //if initialStop the same as finalStop in the same line
                console.log("No need to travel. You are already at your destination")
                console.log("0 stops in total")
                return;
            } else if (this[startLine].indexOf(initialStop) < this[startLine].indexOf(finalStop)) { // if initialStop is before finalStop
                for (i = this[startLine].indexOf(initialStop) + 1; i < this[startLine].length; i++) {
                    if (this[startLine][i] === finalStop) {
                        trip.push(this[startLine][i]);
                        i = this[startLine].length;
                        stopCount++;
                    } else {
                        trip.push(this[startLine][i]);
                        stopCount++;
                    }
                }
            } else if (this[startLine].indexOf(initialStop) > this[endLine].indexOf(finalStop)) { // if initialStop is after finalStop
                for (i = this[startLine].indexOf(initialStop) - 1; i > this[startLine].indexOf(finalStop) - 1; i--) {
                    if (this[startLine][i] === finalStop) {
                        trip.push(this[startLine][i]);
                        i = this[endLine].indexOf(finalStop) - 1;
                        stopCount++;
                    } else {
                        trip.push(this[startLine][i]);
                        stopCount++;
                    }
                }
            }
            console.log("You must travel through the following stops on the " + startLine + " line: " + trip.join(", ") + ".");
            console.log(stopCount + " stops in total.");
        } else if(this[startLine].includes(initialStop) && this[endLine].includes(finalStop)){    //if initialLine is different than finalLine
            if (this[startLine].indexOf(initialStop) < this[startLine].indexOf(intersection)) { //if initialStop is before intersection
                for (i = this[startLine].indexOf(initialStop) + 1; i < this[startLine].length; i++) {
                    if (this[startLine][i] === intersection) {
                        trip.push(this[startLine][i]);
                        i = this[startLine].length;
                        stopCount++;
                    } else {
                        trip.push(this[startLine][i]);
                        stopCount++;
                    }
                }
            } else if (this[startLine].indexOf(initialStop) > this[startLine].indexOf(intersection)) { // if initialStop is after intersection
                for (i = this[startLine].indexOf(initialStop) - 1; i > this[startLine].indexOf(intersection) - 1; i--) {
                    if (this[startLine][i] === intersection) {
                        trip.push(this[startLine][i]);
                        i = this[startLine].indexOf(intersection) - 1;
                        stopCount++;
                    } else {
                        trip.push(this[startLine][i]);
                        stopCount++;
                    }
                }
            }
            //Reached intersection and changed line
            console.log("You must travel through the following stops on the " + startLine + " line: " + trip.join(", ") + ".");
            console.log("Change at " + intersection);

            if(this[endLine].indexOf(intersection) < this[endLine].indexOf(finalStop)){ //if intersection is before finalStop
                for(i = this[endLine].indexOf(intersection) + 1; i < this[endLine].length; i++){
                    if (this[endLine][i] === finalStop) {
                        tripAfterChange.push(this[endLine][i]);
                        i = this[endLine].length;
                        stopCount++;
                    } else {
                        tripAfterChange.push(this[endLine][i]);
                        stopCount++;
                    }
                }
            } else if(this[endLine].indexOf(intersection) > this[endLine].indexOf(finalStop)){ //if intersection is after finalStop
                for(i = this[endLine].indexOf(intersection) - 1; i > this[endLine].indexOf(finalStop) - 1; i--){
                    if (this[endLine][i] === finalStop) {
                        tripAfterChange.push(this[endLine][i]);
                        i = this[endLine].indexOf(finalStop) - 1;
                        stopCount++;
                    } else {
                        tripAfterChange.push(this[endLine][i]);
                        stopCount++;
                    }
                }
            }
            console.log("Your journey continues through the following stops: " + tripAfterChange.join(", ") + ".");
            console.log(stopCount + " stops in total.");
        }
    }
}
subwayLines.planTrip("Red", "Alwrod", "Red", "Alwrod");
console.log("================================");
subwayLines.planTrip("Red", "Almalaz", "Red", "Alwrod");
console.log("================================");
subwayLines.planTrip("Red", "Alwrod", "Red", "Diplomatic");
console.log("================================");
subwayLines.planTrip("Red", "Salah Aldin", "Green", "Alzahra");
console.log("================================");

