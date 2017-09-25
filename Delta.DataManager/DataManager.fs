module DataManager 
open Delta.Data
open Delta.Data.Models

let private db = DeltaContext()

type Org =
    {Name:string}
type Char = 
    {Name: string 
     Organisation: seq<Org>}
type Entity =
    |Org
    |Char
    |Organisation
    |Character

let map e =
    match e with
    | Organisation o -> Org {Name = o.Name}
    | Character c -> Char {Name = c.Name; Organisation = c.Organisation}
    | _ -> e

let characters = db.Characters |> Seq.cast<Character>
let organisations = db.Organisations |> Seq.cast<Organisation>