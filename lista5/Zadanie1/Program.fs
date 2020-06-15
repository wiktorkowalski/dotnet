// Learn more about F# at http://fsharp.org

open System

let rec fib n =
   if n <= 2 then 1
   else fib (n - 1) + fib (n - 2)

let rec factorial x =
    match x with
        | 0 -> 1
        | 1 -> 1 
        | x -> x * factorial(x-1)

[<EntryPoint>]
let main argv =
    Console.WriteLine("fibbonachi 10 = {0}",fib(10));
    Console.WriteLine("factorial 10 = {0}",factorial(10));
    0
