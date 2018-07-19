module Tab
open System

let drawTab showFretNumbers nFrets =
    let tuning = "   E A D G B E "
    let nut =
        if showFretNumbers then
            " 0┌┬─┬─┬─┬─┬─┬┐"
        else
            "  ┌┬─┬─┬─┬─┬─┬┐"

    let board = "  ││ │ │ │ │ ││"

    let fret n =
        if showFretNumbers then
            sprintf "%2d├┼─┼─┼─┼─┼─┼┤" n
        else
            "  ├┼─┼─┼─┼─┼─┼┤"

    let boards = seq { for i in [1 .. nFrets] -> board}
    let frets = seq { for i in [1 .. nFrets] -> fret i}
    let fretboard = Seq.zip boards frets |> Seq.collect (fun (x, y) -> [x; y])
    let lines = seq {
        yield tuning
        yield nut
        yield! fretboard
    }

    String.Join ("\n", lines |> Seq.toArray)