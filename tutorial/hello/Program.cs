// See https://aka.ms/new-console-template for more information
string[] student = new string[] { "Juan", "Sebastian", "Carlos", "Sofia", "Maria" };
double[] score = new double[] { 3.4, 3.0, 4.1, 4.8, 2.9 };

Console.WriteLine("Student \tGrade \tLetter Grade");
foreach (string students in student){
    Console.WriteLine(students);
    foreach (double scores in score){
        Console.Write($"\t\t{scores}");
    }
}



