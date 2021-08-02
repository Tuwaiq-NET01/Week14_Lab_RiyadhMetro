const subway = {
    Red: [ 'Alwrod', 'Salah Aldin', 'Alnzha', 'Hittin', 'Qwrtba', 'KSU', 'Almalaz', 'Diplomatic'],
    Blue: ['Alakeek', 'Alyasmin', 'Salah Aldin', 'Rahmanea', 'Motamrat', 'Alolya', 'Almoroj' ],
    Green: ['Nmar', 'PNU', 'Salah Aldin', 'Solaymanea', 'Alamal', 'Tayba', 'Alhazem', 'Alzahra'],
}

const stopsBetweenStations = function(StartLine, StartStation, EndLine, EndStation) {

    let startIndex = subway[StartLine].indexOf(StartStation)
    let endIndex = subway[EndLine].indexOf(EndStation)
   
   if (StartLine === EndLine) {
    return Math.abs(startIndex - endIndex)+ ' ' + 'stops';
    
   }
   else{
   const startSalahAldinIndex = subway[StartLine].indexOf('Salah Aldin')
   const toSalahAldin = Math.abs(startIndex - startSalahAldinIndex)
   const endSalahAldinIndex = subway[EndLine].indexOf('Salah Aldin')
   const fromSalahAldin= Math.abs(endIndex - endSalahAldinIndex)

   const total= toSalahAldin + fromSalahAldin
      return total + ' ' + 'stops'
      }
   }
//Test the result
   console.log(stopsBetweenStations('Red','Alwrod', 'Red', 'Alwrod'));// 0 stops
   console.log(stopsBetweenStations('Red','Alwrod', 'Red', 'Diplomatic'));// 7 stops
   console.log(stopsBetweenStations('Red','Alwrod', 'Green', 'Alzahra')); // 6 stops
  