let lines = {
    'red': ['Alwrod', 'Salah Aldin', 'Alnzha', 'HittinQwrtba', 'KSU', 'Almalaz', 'Diplomatic'],
    'blue': ['Alakeek', 'Alyasmin', 'Salah Aldin', 'Rahmanea', 'Motamrat', 'Alolya', 'Almoroj'],
    'green': ['Nmar', 'PNU', 'Salah Aldin', 'Solaymanea', 'Alamal', 'Tayba', 'Alhazem', 'Alzahra'],
}


const stopsBetweenStations = (oline, ostart, tline, tstop) => {
    let firarr = lines[oline]
    let lasarr = lines[tline]
    let result = document.getElementById('result')
    let firstindex = firarr.indexOf(ostart)
    if (oline === tline) {
        let lastindex = firarr.indexOf(tstop)
        result.innerText = Math.abs(lastindex - firstindex)
        return Math.abs(lastindex - firstindex)
    } else {
        let tojump = Math.abs(firarr.indexOf(ostart) - firarr.indexOf("Salah Aldin"))
        result.innerText = (tojump + Math.abs(lasarr.indexOf("Salah Aldin") - lasarr.indexOf(tstop))).toString()
        return tojump + Math.abs(lasarr.indexOf("Salah Aldin") - lasarr.indexOf(tstop))
    }

}
const search = () => {
    stopsBetweenStations(document.getElementById("fline").value, document.getElementById('fsta').value, document.getElementById('lline').value, document.getElementById('lsta').value)
}

