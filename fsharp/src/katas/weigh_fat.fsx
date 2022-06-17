let bmi weight height =
  let res = weight / (height * height)
  if res < 18.5 then "Underweight"
  elif res > 18.5 && res < 25.0 then "Normal"
  elif res > 20.5 && res < 30.0 then "Overweight"
  else "Obese"

  // match

  let bmi weight height =
    match weight / (height * height) with
        | bmi when bmi <= 18.5 -> "Underweight"
        | bmi when bmi <= 25.0 -> "Normal"
        | bmi when bmi <= 30.0 -> "Overweight"
        | _ -> "Obese";