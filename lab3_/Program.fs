open System
(*
let readSeq () =
    printfn "Введите строки через пробел:"
    let input = Console.ReadLine()
    Seq.ofArray (input.Split(' '))

[<EntryPoint>]
let main argv =  
    let strings = readSeq ()

    printfn "Введите символ:"
    let symbol = Console.ReadLine().[0]

    let modified = Seq.map (fun s -> s + string symbol) strings

    printfn "Новая последовательность:"
    Seq.iter (printfn "%s") modified

    0
    *)
    
let readSeq () =
    printfn "Введите строки через пробел:"
    let input = Console.ReadLine()
    Seq.ofArray (input.Split(' '))

[<EntryPoint>]
let main argv =
    let strings = readSeq ()
    let first = Seq.head strings
    let shortest =
        Seq.fold (fun acc s ->
            if String.length s < String.length acc then 
                s 
            else 
                acc
        ) first strings

    printfn "Самая короткая строка: %s" shortest

    0