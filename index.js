const lines = {

    "Red": ["Alwrod","Salah Aldin","Alnzha","Hittin","Qwrtba","KSU","Almalaz","Diplomatic"],

    "Blue":[ "Alakeek","Alyasmin","Salah Aldin","Rahmanea","Motamrat","Alolya","Almoroj"],

    "Green": ["Nmar","PNU","Salah Aldin","Solaymanea","Alamal","Tayba","Alhazem","Alzahra"]
}

function stopsBetweenStations(StartLine, StartStation, EndLine, EndStation){
    if(StartLine === EndLine){
        return Math.abs(lines[StartLine].indexOf(StartStation) - lines[EndLine].indexOf(EndStation))
    }
    const firstSteps = Math.abs(lines[StartLine].indexOf(StartStation) - lines[StartLine].indexOf("Salah Aldin"))
    const secondSteps = Math.abs(lines[EndLine].indexOf(EndStation) - lines[EndLine].indexOf("Salah Aldin"))

    return firstSteps + secondSteps
}
// 0 stops
console.log(stopsBetweenStations('Red','Alwrod', 'Red', 'Alwrod')) 
// 7 stops
console.log(stopsBetweenStations('Red','Alwrod', 'Red', 'Diplomatic')) 
// 5 stops
console.log(stopsBetweenStations('Blue','Alyasmin', 'Blue', 'Almoroj')) 

// 6 stops
console.log(stopsBetweenStations('Green', 'Alzahra', 'Red','Alwrod'))
 // 7 stops
console.log(stopsBetweenStations('Red', 'Diplomatic', 'Red','Alwrod'))