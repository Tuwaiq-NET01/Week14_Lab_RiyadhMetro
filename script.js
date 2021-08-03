const MetroRiyadh = {
    Red: ['Alwrod', 'Salah Aldin', 'Alnzha', 'Hittin', 'Qwrtba', 'KSU', 'Almalaz', 'Diplomatic'],
    Blue: ['Alakeek', 'Alyasmin', 'Salah Aldin', 'Rahmanea', 'Motamrat', 'Alolya', 'Almoroj'],
    Green: ['Nmar', 'PNU', 'Salah Aldin', 'Solaymanea', 'Alamal', 'Tayba', 'Alhazem', 'Alzahra'],
}
const stopsBetweenStations = function (startLine, startStation, endLine, endStation) {
    var stops;
    if (MetroRiyadh[startLine[startStation]] == "Saleh Aldin" && MetroRiyadh[endLine[endStation]] == "Saleh Aldin") {
        stops = 0;
    }
    if (startLine == endLine) {
        stops =  MetroRiyadh[endLine].indexOf(endStation) - MetroRiyadh[startLine].indexOf(startStation);
    }
    else {
        stops = MetroRiyadh[startLine].indexOf(startStation);
        stops += MetroRiyadh[endLine].indexOf("Saleh Aldin") + MetroRiyadh[endLine].indexOf(endStation);
    }
    console.log(Math.abs(stops));
}
stopsBetweenStations('Red', 'Alwrod', 'Red', 'Alwrod') 
stopsBetweenStations('Red', 'Alwrod', 'Red', 'Diplomatic') 
stopsBetweenStations('Red', 'Alwrod', 'Green', 'Alzahra')
