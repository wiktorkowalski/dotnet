// Learn morealabout F# at http://fsharp.org

open System

type Complex(real: float, imaginary:float) = 
    member this.real= real
    member this.imaginary= imaginary

    static member (-) (cmp1: Complex, cmp2: Complex) =
        Complex(cmp1.real- cmp2.real, cmp1.imaginary- cmp2.imaginary)

    static member (+) (cmp1: Complex, cmp2: Complex) =
        Complex(cmp1.real+ cmp2.real, cmp1.imaginary+ cmp2.imaginary)

    static member (*) (cmp1: Complex, cmp2: Complex) =
        Complex(cmp1.real* cmp2.real- cmp1.imaginary* cmp2.imaginary, cmp2.real* cmp1.imaginary+ cmp1.real* cmp2.imaginary)

    static member (/) (cmp1: Complex, cmp2: Complex) =
        Complex((cmp1.real* cmp2.real+ cmp1.imaginary* cmp2.imaginary) / (cmp2.real* cmp2.real+ cmp2.imaginary* cmp2.imaginary), (cmp2.real* cmp1.imaginary- cmp1.real* cmp2.imaginary) / (cmp2.real* cmp2.real+ cmp2.imaginary* cmp2.imaginary))

    override this.ToString() = 
        this.real.ToString() + " " + this.imaginary.ToString() + "i"

[<EntryPoint>]
let main argv =
    Console.WriteLine(new Complex(1.0,2.0) + new Complex(3.0,4.0))
    Console.WriteLine(new Complex(1.0,2.0) * new Complex(3.0,4.0))
    Console.WriteLine(new Complex(1.0,2.0) - new Complex(3.0,4.0))
    Console.WriteLine(new Complex(1.0,2.0) / new Complex(3.0,4.0))
    0
