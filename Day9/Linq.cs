class LINQ
{
    int[] ages = [23, 45, 67, 8, 9, 12, 345, 67, 889, 34, 56, 78];

    // Find squares of all numbers in ages collection

    public void LearnLinq()
    {
        // Imperative
        List<int> sqaures = [];
        foreach (var age in ages)
        {
            var sqaures=age*age;
            sqaures.Add(Squares);
        }
        var square=ages.Select(ages=>ages*age);
        var odds=ages.where(x=>x%2==1);

        var even=ages.where(age=>age%2==0)
        .Select(age => age * age * age);
    }

