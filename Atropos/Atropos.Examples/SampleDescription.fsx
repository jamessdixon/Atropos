﻿// Basic sample statistics

#I @"../../packages/"
#r @"FSharp.Data/lib/net40/FSharp.Data.dll"
open FSharp.Data

type Sample = CsvProvider<"titanic.csv">
type Passenger = Sample.Row

let sample = Sample.GetSample ()

sample.Rows 
|> Seq.length 
|> printfn "Examples: %i"

sample.Rows 
|> Seq.countBy (fun row -> row.Survived)
|> Seq.iter (fun (lbl,cnt) -> printfn "%A: %i" lbl cnt)