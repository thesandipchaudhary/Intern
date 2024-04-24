// Animal a1=new();
// Animal a2=new();
// a1.species="Dog";
// a1.age=9;
// a1.weight=20;
// a1.color="red";
// a1.leg=4;
// a1.Animaldetails();

// a2.species="Cat";
// a2.age=3;
// a2.weight=5;
// a2.color="Black";
// a2.leg=4;
// a2.Animaldetails();
 
// Rectangle rec=new(2.4,4);
// var p=rec.GetArea();

// Rectangle rec2=new(2.4,4);
// var p1=rec.GetPerimeter();
// Console.WriteLine("Area of Rectangle"+p);
// Console.WriteLine("Perimeter of Rectangle"+p1);

// var square1=new square(2.4);
// var sa=square1.GetArea();


// var c=new Circle(5.6);
// var cc=c.GetArea();
// var c2=c.Perimeter();

// Console.WriteLine("Area of circle "+cc);
// Console.WriteLine("Perimeter of circle "+c2);

// Parallelll parallel=new();
// parallel.ProcessNumbers();

BasicDBContext Db=new();
var teacher1 =new Teacher
{
    Name="Sita",
    Address="Ghorahi",
    Gender='F',
    Qualification="BCA",
    Dob=new DateTime(2005,6,5)
};
Db.Teachers.Add(teacher1);
Db.SaveChanges();

// var teachers=Db.Teachers.ToList();
var teachers=Db.Teachers.Where(x=>x.Gender=='F' && x.Address=="Dang").ToList();
foreach(var teacher in teachers)
{
    Console.WriteLine($"Name{teacher.Name} Dob{teacher.Dob}");
}