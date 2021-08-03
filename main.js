  
var lines = {
    "Red": ["Alwrod","Salah Aldin","Alnzha","Hittin","Qwrtba","KSU","Almalaz","Diplomatic"],
    "Blue": [ "Alakeek","Alyasmin","Salah Aldin","Rahmanea","Motamrat","Alolya","Almoroj"],
    "Green": ["Nmar","PNU","Salah Aldin","Solaymanea","Alamal","Tayba","Alhazem","Alzahra"]
  }

  function stopsBetweenStations(startLine, startpoint, stopLine, stoppoint) {
    var Count = 0;
    var s = "";
    var s2 = "";
  
    if (startLine === stopLine) {
     
      if (lines[startLine].indexOf(startpoint)  < lines[stopLine].indexOf(stoppoint)) { 
        for (var i = lines[startLine].indexOf(startpoint) +1 ; i <= lines[stopLine].indexOf(stoppoint); i++) {
          s += lines[startLine][i] + ", ";
          Count++;
        }
      } else { 
        for (var i = lines[startLine].indexOf(startpoint) -1 ; i >= lines[stopLine].indexOf(stoppoint); i--) {
          s += lines[startLine][i] + ", ";
          Count++;
        }
      }
      console.log("You must travel through the following stops on the " + startLine + " line: " + s + ".")
      console.log(Count + " stops in total.")
      console.log("=====================================")
    } else {
      // Trip 1 
     
     
        if (lines[startLine].indexOf(startpoint) < lines[startLine].indexOf("Salah Aldin")) { 
          for (var i = lines[startLine].indexOf(startpoint) +1 ; i <= lines[startLine].indexOf("Salah Aldin"); i++) {
            s += lines[startLine][i] + ", ";
            Count++;
          }
        } else { 
          for (var i = lines[startLine].indexOf(startpoint)-1; i >= lines[startLine].indexOf("Salah Aldin"); i--) {
            s += lines[startLine][i] + ", ";
            Count++;
          }
        }
      console.log("You must travel through the following stops on the " + startLine + " line: " + s + ".")
  
  
      // Trip 2 
      
     
     
        if (lines[stopLine].indexOf("Salah Aldin") < lines[stopLine].indexOf(stoppoint)) { 
          for (var i = lines[stopLine].indexOf("Salah Aldin")+1 ; i <= lines[stopLine].indexOf(stoppoint); i++) {
            s2 += lines[stopLine][i] + ", ";
            Count++;
          }
        } else { 
          for (var i = lines[stopLine].indexOf("Salah Aldin")-1; i >= lines[stopLine].indexOf(stoppoint); i--) {
            s2 += lines[stopLine][i] + ", ";
            Count++;
          }
        }
        console.log("Change at Salah Aldin.");
        
        console.log("Your journey continues through the following stops: " + s2 + ".")
  
    console.log(Count + " stops in total.")

    console.log("=====================================")
  

  }
}


stopsBetweenStations('Red','Alwrod', 'Red', 'Alwrod') // 0 stops
stopsBetweenStations('Red','Alwrod', 'Red', 'Diplomatic') // 7 stops
stopsBetweenStations('Red','Alwrod', 'Green', 'Alzahra') // 6 stops

