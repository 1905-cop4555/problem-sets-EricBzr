// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv

    printfn "%d" (5 + 2)

    printfn "Press ENTER to continue..."
    System.Console.ReadLine() |> ignore

    0 // return an integer exit code
