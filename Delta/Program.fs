open Delta.DataManager
open DataManager
open System

[<EntryPoint>]
let main argv = 
    printfn "%A" (characters |> Seq.isEmpty)
    Console.Read() |> ignore
    0 // return an integer exit code
