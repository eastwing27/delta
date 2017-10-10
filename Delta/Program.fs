open System
open DataProvider
open Delta.Shared.Models

let addOrg name =
    if fractions |> Seq.map (fun x -> x.Name) |> Seq.contains name then
        false
    else
        name |> generateOrganisation |> create
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
        | _ -> printf ""
        react line


[<EntryPoint>]
let main argv =
    react ""