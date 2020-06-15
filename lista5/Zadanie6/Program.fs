// Learn more about F# at http://fsharp.org

open System

type TokenType =
    | Operation = 0
    | Float     = 1
    
type Token = {
    Type: TokenType
    Value: string
}

[<Literal>]
let Operations = "+-*/%"
[<Literal>]
let Numbers = "1234567890."

let private isOperation (c: char) = Operations.Contains(c)

let private isNumber (c: char) = Numbers.Contains(c)

let rec private getfloatLenght (input:string) lenght =
    match input.Length with
    | 0 -> lenght
    | _ ->
        match input.[0] with
        | c when isNumber c -> getfloatLenght (input.Substring(1)) (lenght + 1)
        | _ -> lenght

let rec tokenize (input:string) =
    match input.Length with
    | 0 -> []
    | _ ->
        match input.[0] with
        | c when isOperation c ->
            let token = { Type = TokenType.Operation; Value = input.[0].ToString() }
            token :: (tokenize (input.Substring(1)))
        | c when isNumber c ->
            let floatLenght = getfloatLenght input 0
            let token = { Type = TokenType.Float; Value = input.Substring(0, floatLenght) }
            token :: (tokenize (input.Substring(floatLenght)))
        | _ -> tokenize (input.Substring(1))

[<EntryPoint>]
let main argv =
    let var = tokenize("5 - 2 * 4 + 6 / 3")
    for item in var do
        Console.WriteLine(item.Value.ToString() + " => " + item.Type.ToString());
    0
