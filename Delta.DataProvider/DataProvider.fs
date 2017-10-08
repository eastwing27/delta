module DataProvider
open Delta.Data
open Delta.Shared.Models

let private data = DataManager()

let read<'t when 't: not struct> condition =
    condition |> data.Read<'t>

let reaRange<'t when 't: not struct> condition =
    condition |> data.ReadRange<'t>

let create<'t when 't: not struct> (entity:'t) =
    entity |> data.Create

let createRange<'t when 't: not struct> (set:seq<'t>) =
    set |> data.CreateRange
