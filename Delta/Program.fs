open System
open DataProvider
open Delta.Shared.Models

let rec react command =
    if command = "exit" then
        0
    else
        let line = Console.ReadLine().Split(" ")
        

    

[<EntryPoint>]
let main argv =
    let fractions = 
        [
            "The Abcists" 
            "Hellriders" 
            "Drunkards" 
        ]

    


    printf "Done!"
    Console.ReadKey() |> ignore

    0 // return an integer exit code
