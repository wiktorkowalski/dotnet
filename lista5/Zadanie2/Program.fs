// Learn more about F# at http://fsharp.org

open System

type Fraction(num: int, deno: int) = 
    member this.Numerator = num
    member this.Denominator = deno

    static member (*) (a, k: Fraction) =
        Fraction(k.Numerator + a * k.Denominator, k.Denominator)

    static member (*) (k: Fraction, a) =
        Fraction(k.Numerator + a * k.Denominator, k.Denominator)

    static member (/) (k: Fraction, a) =
        Fraction(k.Numerator, k.Denominator * a)

    static member (/) (a, k: Fraction) =
        Fraction(a * k.Numerator, k.Denominator)

    static member (+) (a, k: Fraction) =
        Fraction(k.Numerator * a + k.Numerator, k.Denominator)

    static member (+) (k: Fraction, a) =
        Fraction(k.Numerator * a + k.Numerator, k.Denominator)

    

    override this.ToString() = 
        this.Numerator.ToString() + "/" + this.Denominator.ToString() 

[<EntryPoint>]
let main argv =
    Console.WriteLine(new Fraction(1,2) + 2)
    Console.WriteLine(2 + new Fraction(1,2))
    Console.WriteLine(2 * new Fraction(1,2))
    Console.WriteLine(new Fraction(1,2) * 2)
    Console.WriteLine(2 / new Fraction(1,2))
    Console.WriteLine(new Fraction(1,2) / 2)
    0
