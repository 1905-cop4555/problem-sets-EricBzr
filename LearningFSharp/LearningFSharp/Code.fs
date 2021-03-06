﻿module Code

module Exercise1 =

   let increment n = n + 1

   let decrement n = n - 1

module Exercise2 =

   let str1 = "cat"

   let str2 = "catdog"

   let letter =
      printfn "%c" "ball".[0]
   
   let printPairs = 
      printfn "%s" (fst("penguin", "lizard"))
      printfn "%s" (snd("penguin", "lizard"))

module Exercise3 = 

   let rec power pair = 
      if snd pair = 0
        then 1.0
      else fst pair * power (fst pair, (snd pair) - 1)
      
module Exercise4 = 

   let removeOdds list = 
      List.filter (fun x -> x%2 = 0) list

module Exercise5 =

   let rec allOdds list =
      if List.head list % 2 = 0
        then []
      else (List.head list)::(allOdds (List.tail list))

module Exercise6 =

   let prod n = n * n

   let sub2 n = n - 2

   let rec pattern = function
   | 0 -> []
   | n -> n :: [sub2 n]

module Exercise7 =

   let rec fib = function
   | 1 -> 0
   | 2 -> 1
   | i -> fib(i - 2) + fib(i - 1)

      
