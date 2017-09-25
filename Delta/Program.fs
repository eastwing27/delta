namespace Delta

module Program =
    open System
    open Delta.Shared.Models
    open DataWorks

    let johny = Character()

    [<EntryPoint>]
    let main argv = 
        johny.Name <- "Johny";
        data.Create(johny)

        Console.Read() |> ignore
        0 // return an integer exit code
