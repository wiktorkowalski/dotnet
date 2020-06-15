// Learn more about F# at http://fsharp.org

open System

let Agent =
   MailboxProcessor.Start(fun inbox ->
     async { while true do
               let! msg = inbox.Receive()
               printfn "got message '%s'" msg})

[<EntryPoint>]
let main argv =
    Agent.Post("yeet")
    0 // return an integer exit code
