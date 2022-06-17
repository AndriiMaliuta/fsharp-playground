let peopleWithAgeDrink old =
  match old with
    | peopleWithAgeDrink when peopleWithAgeDrink < 14 -> "drink toddy"
    | peopleWithAgeDrink when peopleWithAgeDrink >= 14 && peopleWithAgeDrink < 18 -> "drink coke"
    | peopleWithAgeDrink when peopleWithAgeDrink >= 18 && peopleWithAgeDrink < 21 -> "drink beer"
    | peopleWithAgeDrink when peopleWithAgeDrink >= 21 -> "drink whisky"