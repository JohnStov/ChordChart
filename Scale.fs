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

let chromatic = [C; Csharp; D; Eflat; E; F; Fsharp; G; Aflat; A; Bflat; B]

let major (scale : Note list) = 
    [ scale.[0]; scale.[2]; scale.[4]; scale.[5]; scale.[7]; scale.[9]; scale.[11] ]

let minor (scale : Note list) = 
    [ scale.[0]; scale.[2]; scale.[3]; scale.[5]; scale.[7]; scale.[8]; scale.[10] ]

let scaleOf (note : Note) =
    chromatic @ chromatic |> List.skipWhile (fun n -> n <> note) |> List.take 12

let cChromatic = scaleOf C