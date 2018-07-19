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

let allNotes : Scale = [C; Csharp; D; Eflat; E; F; Fsharp; G; Aflat; A; Bflat; B]

let major (scale : Scale) = 
    [ scale.[0]; scale.[2]; scale.[4]; scale.[5]; scale.[7]; scale.[9]; scale.[11] ]

let minor (scale : Scale) = 
    [ scale.[0]; scale.[2]; scale.[3]; scale.[5]; scale.[7]; scale.[8]; scale.[10] ]

let chromatic length root : Scale =
    let rec extendToLength (notes : Scale) =
        if notes |> List.length >= length then
            notes |> List.take length
        else
            notes @ allNotes |> extendToLength  

    let start = allNotes |> List.skipWhile (fun n -> n <> root)
    start |> extendToLength

let octave = chromatic 12 

let notePositions nFrets root scale : int list =
    let stringNotes = chromatic nFrets root
    let positions = stringNotes |> List.mapi (fun i n -> if (scale |> List.contains n) then Some i else None)
    positions |> List.filter (fun i -> i <> None) |> List.map (fun i -> i.Value)

