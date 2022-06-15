
let arr = [1;2;3;4;5]
for item in arr do
    printfn "%d" item


for i = 0 to 100 do
    printfn "%d" i

for i = 10 downto 1 do
  printfn "%i" i

let mutable quit = false
  let no = 11
  while not quit do
    printf "Guess a number: "
    let guess = Console.ReadLine() 
    let guessNo = int guess
    if guessNo = no then
      quit <- true
      printfn "You guessed correctly %i is the secret number" no
    else
      printfn "%i is incorrect" guessNo  