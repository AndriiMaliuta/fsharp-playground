let powersOfTwo n =
  if n = 2 then [1] else
    [for a in 1..n + 1 -> 
      if a = 1 then 1 
      elif a = 2 then 2
      else pown 2 a]