const metros = {

    "Red": [
        "Alwrod",
        "Salah Aldin",
        "Alnzha",
        "Hittin",
        "Qwrtba",
        "KSU",
        "Almalaz",
        "Diplomatic"
    ],

    "Blue":[
        "Alakeek",
        "Alyasmin",
        "Salah Aldin",
        "Rahmanea",
        "Motamrat",
        "Alolya",
        "Almoroj"
    ],

    "Green": [
        "Nmar",
        "PNU",
        "Salah Aldin",
        "Solaymanea",
        "Alamal",
        "Tayba",
        "Alhazem",
        "Alzahra"
    ]
}

function stopsBetweenStations(StartLine, StartStation, EndLine, EndStation){
    if(StartLine === EndLine){
        return Math.abs(metros[StartLine].indexOf(StartStation) - metros[EndLine].indexOf(EndStation))
    }
    const firstSteps = Math.abs(metros[StartLine].indexOf(StartStation) - metros[StartLine].indexOf("Salah Aldin"))
    const secondSteps = Math.abs(metros[EndLine].indexOf(EndStation) - metros[EndLine].indexOf("Salah Aldin"))

    return firstSteps + secondSteps
}

console.log(stopsBetweenStations('Red','Alwrod', 'Red', 'Alwrod')) // 0 stops
console.log(stopsBetweenStations('Red','Alwrod', 'Red', 'Diplomatic')) // 7 stops
console.log(stopsBetweenStations('Red','Alwrod', 'Green', 'Alzahra')) // 6 stops
