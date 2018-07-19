// Learn more about F# at http://fsharp.org

open Tab

[<EntryPoint>]
let main argv =
    drawTab true 5 |> printf "%s"
    0 // return an integer exit code
