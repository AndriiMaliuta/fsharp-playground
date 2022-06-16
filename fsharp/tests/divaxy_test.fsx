module Tests = begin
    open Fuchu
    let suite =
        testList "Is it divisible?" [
            testCase "Basic tests" <|
                fun _ ->
                    Assert.Equal("isDivisible 3 3 4", false, isDivisible 3 3 4)
                    Assert.Equal("isDivisible 12 3 4", true, isDivisible 12 3 4)
                    Assert.Equal("isDivisible 8 3 4", false, isDivisible 8 3 4)
                    Assert.Equal("isDivisible 48 3 4", true, isDivisible 48 3 4)
                    Assert.Equal("isDivisible 100 5 10", true, isDivisible 100 5 10)
                    Assert.Equal("isDivisible 100 5 3", false, isDivisible 100 5 3)
                    Assert.Equal("isDivisible 4 4 2", true, isDivisible 4 4 2)
                    Assert.Equal("isDivisible 5 2 3", false, isDivisible 5 2 3)
                    Assert.Equal("isDivisible 17 17 17", true, isDivisible 17 17 17)
                    Assert.Equal("isDivisible 17 1 17", true, isDivisible 17 1 17)
        ]
end