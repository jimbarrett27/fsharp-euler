let fib  (fst, snd) = Some(fst + snd, (snd, fst + snd))
let lessThan4Mil x = x < 4000000 
let isEven x = x % 2 = 0 

Seq.unfold(fib) (0,1) |> Seq.takeWhile(lessThan4Mil) |> Seq.toList |> List.filter(isEven) |> List.sum |> printfn "%i"
