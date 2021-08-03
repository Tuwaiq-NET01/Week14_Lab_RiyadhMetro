let red = ['Alwrod', 'Salah Aldin', 'Alnzha', 'HittinQwrtba', 'KSU', 'Almalaz', 'Diplomatic']
let blue = ['Alakeek', 'Alyasmin', 'Salah Aldin', 'Rahmanea', 'Motamrat', 'Alolya', 'Almoroj']
let green = ['Nmar', 'PNU', 'Salah Aldin', 'Solaymanea', 'Alamal', 'Tayba', 'Alhazem', 'Alzahra']


const stopsBetweenStations = (oline, ostart, tline, tstop) => {
    let firarr
    let lasarr
    let result = document.getElementById('result')
    if (oline === 'red') firarr = red
    else if (oline === 'blue') firarr = blue
    else if (oline === 'green') firarr = green

    let firstindex = firarr.indexOf(ostart)
    if (oline === tline) {
        let lastindex = firarr.indexOf(tstop)
        result.innerText = Math.abs(lastindex - firstindex)
        return Math.abs(lastindex - firstindex)
    } else {
        let tojump = Math.abs(firarr.indexOf(ostart) - firarr.indexOf("Salah Aldin"))
        if (tline === 'red') lasarr = red
        else if (tline === 'blue') lasarr = blue
        else if (tline === 'green') lasarr = green
        result.innerText = (tojump + Math.abs(lasarr.indexOf("Salah Aldin") - lasarr.indexOf(tstop))).toString()
        return tojump + Math.abs(lasarr.indexOf("Salah Aldin") - lasarr.indexOf(tstop))
    }

}
const search = () => {
    stopsBetweenStations(document.getElementById("fline").value,document.getElementById('fsta').value,document.getElementById('lline').value,document.getElementById('lsta').value)
}

