module DataProvider
open Delta.Data
open Delta.Shared.Models

let private data = DataManager()

let fractions = data.ReadAll<Organisation>()
let characters = data.ReadAll<Character>()

let read<'t when 't: not struct> condition =
    condition |> data.Read<'t>

let reaRange<'t when 't: not struct> condition =
    condition |> data.ReadRange<'t>

let create<'t when 't: not struct> (entity:'t) =
    entity |> data.Create
    data.SaveChanges()

let createRange<'t when 't: not struct> (set:seq<'t>) =
    set |> data.CreateRange
    data.SaveChanges()

let generateOrganisation name =
    let org = Organisation()
    org.Name <- name
    org

let generateCharacter orgId name =
    let c = Character()
    c.Name <- name
    c.OrganisationId <- orgId
    c