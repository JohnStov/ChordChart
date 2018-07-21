// Learn more about F# at http://fsharp.org

open Tab
open Scale

[<EntryPoint>]
let main argv =
    let cMaj = octave C |> major
    drawTab true 12 guitar cMaj |> printf "%s"
    0 // return an integer exit code
