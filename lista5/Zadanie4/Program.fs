// Learn more about F# at http://fsharp.org

open System

type Quaterion(x1: float, y1: float, z1: float, w1: float) =

    let mutable x = x1
    let mutable y = y1
    let mutable z = z1
    let mutable w = w1

    member this.Dot (q: Quaterion) : double = 
        x * q.X + y * q.X + z * q.X + w * q.X

    member this.Norm (q: Quaterion) : float = 
        Math.Sqrt(this.Dot(q))

    member this.Scale(scale: float, q: Quaterion) : bool =
        if scale < 1.0 then
            x <- x * scale
            y <- y * scale
            z <- z * scale
            w <- w * scale
            true
        else false

    member this.MulWith (q: Quaterion) : bool =
        this.X <- w * q.X + x * q.W + y * q.Z - z * q.Y
        this.Y <- w * q.Y + y * q.W + z * q.X - x * q.Z
        this.W <- w * q.W - x * q.X - y * q.Y - z * q.Z
        this.Z <- w * q.Z + z * q.W + x * q.Y - y * q.X
        true

    member this.X with get() = x and set(value) = x <- value
    member this.Y with get() = y and set(value) = y <- value
    member this.Z with get() = z and set(value) = z <- value
    member this.W with get() = w and set(value) = w <- value

    

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
