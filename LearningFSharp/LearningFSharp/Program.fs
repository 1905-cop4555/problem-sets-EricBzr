// Learn more about F# at http://fsharp.org

open System

let succ n = n + 1

[<EntryPoint>]
let main argv =
    printfn "---------- Exercise One ----------"
    printfn "%d" (Code.Exercise1.increment 11)
     
    printfn "\nHello World from F#!"
    0 // return an integer exit code
