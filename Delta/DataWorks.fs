module DataWorks

open Delta.Data
open Delta.Shared.Models

let data = DataManager()
let chars = data.ReadAll<Character>()
let fractions = data.ReadAll<Organisation>()