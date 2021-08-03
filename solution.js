subwayLines = {
    Red: ["Alwrod", "Salah Aldin", "Alnzha", "Hittin", "Qwrtba", "KSU", "Almalaz", "Diplomatic"],
    Blue: ["Alakeek", "Alyasmin", "Salah Aldin", "Rahmanea", "Motamrat", "Alolya", "Almoroj"],
    Green: ["Nmar", "PNU", "Salah Aldin", "Solaymanea", "Alamal", "Tayba", "Alhazem", "Alzahra"],
    
    prevStops: [],
    nextStops: [],
    finalPath: [],
    firstFinalPath: [],
    secondFinalPath: [],
    lineChanged: false,
    initialStopIndex: null,
    finalStopIndex: null,
    ChangeStopIndex: function(line){
        return subwayLines[line].indexOf("Salah Aldin")
    },
    printFinalPath: function(path){
            return path.join(" > ")
    },

    // Your solution here
    planTrip: function(initialLine, initialStop, finalLine, finalStop) {
        if((initialLine === "Red" || initialLine === "Blue" || initialLine === "Green") && (finalLine === "Red" || finalLine === "Blue" || finalLine === "Green")){
            if((subwayLines[initialLine].includes(initialStop) && subwayLines[finalLine].includes(finalStop))){
        initialStopIndex = this[initialLine].indexOf(initialStop);
        finalStopIndex = this[finalLine].indexOf(finalStop);
        if(initialLine === finalLine){
            lineChanged = false;
        }else{
            lineChanged =true;
        } 
        

        if(lineChanged){
            if(initialStopIndex<subwayLines[initialLine].indexOf("Salah Aldin")){
                for (let i = initialStopIndex; i<=subwayLines[initialLine].indexOf("Salah Aldin");i++) {
                    this.firstFinalPath.push(subwayLines[initialLine][i])
                }
            }else{
                for (let i = initialStopIndex; i>=subwayLines[initialLine].indexOf("Salah Aldin");i--) {
                    this.firstFinalPath.push(subwayLines[initialLine][i])
                }
            }
            if(finalStopIndex<subwayLines[finalLine].indexOf("Salah Aldin")){
                for (let i = subwayLines[finalLine].indexOf("Salah Aldin")-1; i>=finalStopIndex;i--) {
                    this.secondFinalPath.push(subwayLines[finalLine][i])
                }
            }else{
                for (let i = subwayLines[finalLine].indexOf("Salah Aldin")+1; i<=finalStopIndex;i++) {
                    this.secondFinalPath.push(subwayLines[finalLine][i])
                }
            }
            console.log("You must travel through the following stops on the "+initialLine+" line: "+this.printFinalPath(this.firstFinalPath))
            console.log("Change at Salah Aldin.")
            console.log("Your journey continues through the following stops: "+this.printFinalPath(this.secondFinalPath))
            console.log((this.firstFinalPath.length+this.secondFinalPath.length)-1+" stops in total.")
        }else{
            if(finalStopIndex<initialStopIndex){
                for (let i = initialStopIndex; i>=finalStopIndex;i--) {
                    this.finalPath.push(subwayLines[initialLine][i])
                }
            }else{
                for (let i = initialStopIndex; i<=finalStopIndex;i++) {
                    this.finalPath.push(subwayLines[initialLine][i])
                }
            }
            console.log("You must travel through the following stops on the "+initialLine+" line: "+this.printFinalPath(this.finalPath))
            console.log((this.finalPath.length)-1+" stops in total.")
        }



    }else
    console.log("Wrong input")
}else
console.log("Wrong input")
    }
}
console.log('====================================');
subwayLines.planTrip('Red','Alwrod','Red','Alwrod')
subwayLines.planTrip('Red','Almalaz','Red','Alwrod')
subwayLines.planTrip('Red','Alwrod','Red','Diplomatic')
subwayLines.planTrip('Red','Alwrod','Green','Alzahra')
console.log('====================================');
