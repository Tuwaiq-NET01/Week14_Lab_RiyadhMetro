const RiyadhMetro = {
    Red: ['Alwrod', 'Salah Aldin', 'Alnzha', 'Hittin', 'Qwrtba', 'KSU', 'Almalaz', 'Diplomatic'],
    Blue: ['Alakeek', 'Alyasmin', 'Salah Aldin', 'Rahmanea', 'Motamrat', 'Alolya', 'Almoroj'],
    Green: ['Nmar', 'PNU', 'Salah Aldin', 'Solaymanea', 'Alamal', 'Tayba', 'Alhazem', 'Alzahra'],
}
const stopsBetweenStations = function (startLine, startStation, endLine, endStation) {
    var stops;
    if (RiyadhMetro[startLine[startStation]] == "Saleh Aldin" && RiyadhMetro[endLine[endStation]] == "Saleh Aldin") {
        stops = 0;
    }
    if (startLine == endLine) {
        stops =  RiyadhMetro[endLine].indexOf(endStation) - RiyadhMetro[startLine].indexOf(startStation);
    }
    else {
        stops = RiyadhMetro[startLine].indexOf(startStation);
        stops += RiyadhMetro[endLine].indexOf("Saleh Aldin") + RiyadhMetro[endLine].indexOf(endStation);
    }
    console.log(Math.abs(stops));
}
stopsBetweenStations('Red', 'Alwrod', 'Red', 'Alwrod') // 0 stops
stopsBetweenStations('Red', 'Alwrod', 'Red', 'Diplomatic') // 7 stops
stopsBetweenStations('Red', 'Alwrod', 'Green', 'Alzahra') // 6 stops