namespace Delta

module Program =
    open System
    open Delta.Shared.Models
    open DataWorks

    [<EntryPoint>]
    let main argv = 
        let teams = 
            chars
            |> Seq.groupBy (fun x -> x.Organisation)

        Console.Read() |> ignore
        0 // return an integer exit code
