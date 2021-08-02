const lines = {
    Red: ['Alwrod','Salah Aldin','Alnzha','Hittin','Qwrtba','KSU','Almalaz','Diplomatic'],
    Blue: ['Alakeek','Alyasmin','Salah Aldin','Rahmanea','Motamrat','Alolya','Almoroj'],
    Green: ['Nmar','PNU','Salah Aldin','Solaymanea','Alamal','Tayba','Alhazem','Alzahra'],
}

console.log('\n/////// Trip in one line forward ////////\n')
console.log(planTrip('Red', 'Almalaz', 'Blue', 'Alyasmin'));
console.log('\n/////// Trip in one line backward ////////\n')
console.log(planTrip('Red', 'Qwrtba', 'Blue', 'Alakeek'));
console.log('\n/////// Trip in two line all forward ////////\n')
console.log(planTrip('Red', 'Salah Aldin', 'Blue', 'Rahmanea'));
console.log('\n/////// Trip in two line all backward ////////\n')
console.log(planTrip('Red', 'KSU', 'Green', 'Nmar'));
console.log('\n/////// Trip in two line forward then backward ////////\n')
console.log(planTrip('Blue', 'Alyasmin', 'Red', 'Hittin'));
console.log('\n/////// Trip in two line backward then forward ////////\n')
console.log(planTrip('Blue', 'Motamrat', 'Green', 'Tayba'));
console.log('\n/////// Invalid line ////////\n')
console.log(planTrip('Green', 'Alamal', 'Red', 'Alyasmeen'));
console.log('\n/////// Invalid stop ////////\n')
console.log(planTrip('Red','Alwrod','Red','Raneen'));

console.log('\n///////////Slack test cases///////////');
console.log(planTrip('Red','Alwrod','Red','Alwrod'));//0
console.log(planTrip('Red','Almalaz','Red','Alwrod'));//6
console.log(planTrip('Red','Alwrod','Red','Diplomatic'));//6
console.log(planTrip('Red','Alwrod','Green','Alzahra'));//7




function planTrip(firstLine, firstStop, lastLine, lastStop) {

    if (!(firstLine in lines) || !(lastLine in lines) || !(lines[firstLine].includes(firstStop)) 
    || !(lines[lastLine].includes(lastStop))) {
        return "Invalid path"
    }
    var firstLineArr = lines[firstLine];
    var firstStopIndex = firstLineArr.indexOf(firstStop);
    var lastLineArr = lines[lastLine];
    var lastStopIndex = lastLineArr.indexOf(lastStop);
    var saFirst = firstLineArr.indexOf('Salah Aldin');
    var saLast = lastLineArr.indexOf('Salah Aldin');
    var message = `\nRider boards the train an travel through the following stops on the ${firstLine} Line:\n`
    var countStops = 0;

    //check if trip is one line or two
    if (firstLine == lastLine) {

        //check if going forward or not: 
        if (firstStopIndex > lastStopIndex) {
            //if not reverse the array 
            firstLineArr = firstLineArr.reverse();
            firstStopIndex = firstLineArr.indexOf(firstStop);
            lastStopIndex = lastLineArr.indexOf(lastStop);

            for (var i = (firstStopIndex + 1); i <= lastStopIndex; i++) {

                if (i == firstLineArr.length - 1) {
                    message += `${firstLineArr[i]}.`
                }
                else {
                    message += `${firstLineArr[i]} ➜ `
                }
                countStops++; //increase stops
            }

            return message += `\n${countStops} stops in total.`;
        }

        //going forward don't reverse the array 
        else {
            for (var i = (firstStopIndex + 1); i <= lastStopIndex; i++) {

                if (i == firstLineArr.length - 1) {
                    message += `${firstLineArr[i]}.`
                }
                else {
                    message += `${firstLineArr[i]} ➜ `
                }
                countStops++; //increase stops
            }

            return message += `\n${countStops} stops in total.`;
        }
    }

    //trip in two lines
    else {

        //check if going forward or backward: 
        if (firstStopIndex > saFirst) {
            //first line backward
            //if not reverse the array 
            firstLineArr = firstLineArr.reverse();
            firstStopIndex = firstLineArr.indexOf(firstStop);
            saFirst = firstLineArr.indexOf('Salah Aldin');
            for (var i = (firstStopIndex + 1); i <= saFirst; i++) {

                if (i == firstLineArr.length - 1) {
                    message += `${firstLineArr[i]}.`
                }
                else {
                    message += `${firstLineArr[i]} ➜ `
                }
                countStops++; //increase stops
            }


        }
        else {
            //first line forward
            for (var i = (firstStopIndex + 1); i <= saFirst; i++) {

                if (i == firstLineArr.length - 1) {
                    message += `${firstLineArr[i]}.`
                }
                else {
                    message += `${firstLineArr[i]} ➜ `
                }
                countStops++; //increase stops
            }
        }

        //go to the second line
        message += `\nRider transfers from ${firstLine} Line To ${lastLine} Line at Salah Aldin\ntravel through the following stops: `

        //check if going forward or backward: 
        if (lastStopIndex < saLast) {
            //second line backward 
            firstLineArr = lastLineArr.reverse();
            lastStopIndex = firstLineArr.indexOf(lastStop);
            saLast = lastLineArr.indexOf('Salah Aldin');
            for (var i = (saLast + 1); i <= lastStopIndex; i++) {

                if (i == lastLineArr.length - 1) {
                    message += `${lastLineArr[i]}.`
                }
                else {
                    message += `${lastLineArr[i]} ➜ `
                }
                countStops++; //increase stops
            }

            return message += `\n${countStops} stops in total.`;
        }
        else {
            //second line forward
            for (var i = (saLast + 1); i <= lastStopIndex; i++) {

                if (i == lastLineArr.length - 1) {
                    message += `${lastLineArr[i]}.`
                }
                else {
                    message += `${lastLineArr[i]} ➜ `
                }
                countStops++; //increase stops
            }

            return message += `\n${countStops} stops in total.`;

        }


    }
}