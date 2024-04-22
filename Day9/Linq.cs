// class LINQ
// {
//     int[] ages = [23, 45, 67, 8, 9, 12, 345, 67, 889, 34, 56, 78];
//     List<Student> students = [
//         new Student() { name = "Ram", address = "Ktm"},
//         new Student() { name = "Laxman", address = "Dang"},
//         new Student() { name = "Bikendra", address = "Ktm"},
//         new Student() { name = "Sandip", address = "Dang"},
//         new Student() { name = "Chahana", address = "Dhangadhi"},

//     ]
//     };
//     // Find squares of all numbers in ages collection

//     public void LearnLinq()
//     {
//         // Imperative
//         List<int> sqaures = [];
//         foreach (var age in ages)
//         {
//             var sqaures=age*age;
//             sqaures.Add(Squares);
//         }
//         var square=ages.Select(ages=>ages*age);
//         var odds=ages.Where(x=>x%2==1);
//         var even=ages.Where(age=>age%2==0).Select(age => age * age * age);
//         var address = students.Where(students => students.address == "Dang")
//         .OrderBy(students => students.name);
//     }

