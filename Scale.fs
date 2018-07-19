module Scale

type Note =
    | C
    | Csharp
    | D
    | Eflat
    | E
    | F
    | Fsharp
    | G
    | Aflat
    | A
    | Bflat
    | B

type Scale = Note list

let chromatic : Scale = [C; Csharp; D; Eflat; E; F; Fsharp; G; Aflat; A; Bflat; B]

let major (scale : Scale) = 
    [ scale.[0]; scale.[2]; scale.[4]; scale.[5]; scale.[7]; scale.[9]; scale.[11] ]

let minor (scale : Scale) = 
    [ scale.[0]; scale.[2]; scale.[3]; scale.[5]; scale.[7]; scale.[8]; scale.[10] ]

let stringNotes (note : Note) nFrets : Note list =
    chromatic @ chromatic |> List.skipWhile (fun n -> n <> note) |> List.take nFrets

let notePositions (stringNotes : Note list) (scale : Scale) : int list =
    scale |> List.map (fun scaleNote -> stringNotes |> List.findIndex (fun stringNote -> stringNote = scaleNote)) |> List.sort

