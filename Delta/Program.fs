open System
open DataProvider
open Delta.Shared.Models
open Delta.Shared.Models.Ships

let addOrg name =
    if fractions |> Seq.map (fun x -> x.Name) |> Seq.contains name then
        false
    else
        name |> generateOrganisation |> create
        true

let addChar name =
    if characters |> Seq.map(fun x -> x.Name) |> Seq.contains name then
        false
    else
        fractions |> Seq.iter (fun x -> printfn "%d - %s" x.Id x.Name)
        printf "Enter fraction ID: "
        let id = Console.ReadLine()
        let org = 
            if String.IsNullOrEmpty(id) then
                 Nullable<int>()
            else
                Nullable(Convert.ToInt32(id))
        (org, name) ||> generateCharacter |> create
        true

let rec react command =
    if command = "exit" then
        0
    else
        printf ">> "
        let line = Console.ReadLine()
        match line with
        | s when s |> String.IsNullOrEmpty -> printf ""
        | s when "organisation".StartsWith(s) ->
            printfn "Input organisation name:"
            if Console.ReadLine() |> addOrg then
                printfn "Added!"
            else
                printfn "Already exists!"
        | s when "character".StartsWith(s) ->
            printfn "Input character name:"
            if Console.ReadLine() |> addChar then
                printfn "Added!"
            else
                printfn "Already exists!"
        | _ -> printf ""
        react line

let bargeDeck = 
    HigherDeck(
        [|
            HigherDeckPlace()
            HigherDeckPlace()
            HigherDeckPlace()
            HigherDeckPlace()
            HigherDeckPlace()
            HigherDeckPlace()
            HigherDeckPlace()
        |]
    )
let barge =
    ShipClass(
        "Barge",
        "Long floating platfrom with lot of place for cargo or weapon. It has no its own engine and must be transported by tow",
        7uy,
        bargeDeck |> Array.singleton,
        IShipBow(),
        IShipForage()
    )

[<EntryPoint>]
let main argv =
    react ""