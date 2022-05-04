let isMultiple3or5 x = (x % 3 = 0) || (x % 5 = 0)

[1..999] |> List.filter(isMultiple3or5) |> List.sum |> printfn "%i"

