open System
open DataProvider
open Delta.Shared.Models

[<EntryPoint>]
let main argv =
    let fractions = 
        [
            "The Abcists" 
            "Hellriders" 
            "Drunkards" 
        ]

    let orgs =
        fractions|> Seq.map (fun x -> 
                                let o = Organisation()
                                o.Name <- x
                                o)

    createRange(orgs)

    printf "Done!"
    Console.ReadKey() |> ignore

    0 // return an integer exit code
