// See https://aka.ms/new-console-template for more information

// registes the notes of 5 student
// each student have 5 notes, stored in a array and print the average
// and depending in the average note, prints a grade letter from a A+,A,A-,B+,B,B-,C+,C,C-,D,F

string[] studentsNames = new string[] {"Sofia", "Valentina", "Juan", "Sebastian", "Carlos"};

double[] gradeStudent1 = new double[] {3.4 , 3.0, 4.1, 4.0, 3.0};
double[] gradeStudent2 = new double[] {3.5 , 3.0, 4.2, 4.5, 3.3};
double[] gradeStudent3 = new double[] {3.8 , 3.8, 4.7, 4.7, 4.7};
double[] gradeStudent4 = new double[] {4.4 , 3.8, 4.9, 4.9, 4.0};
double[] gradeStudent5 = new double[] {4.5 , 3.2, 4.1, 4.0, 3.2};

double sum = 0;
double total = 0;
string gradeLetter;

Console.WriteLine("Students \tGrade \tGrade letter");
foreach (string students in studentsNames){
    if (students == "Sofia"){
        foreach (double grade in gradeStudent1){
            sum += grade;
        }
        total = sum / 5;
        if (total > 4.5){
            gradeLetter = "A";
        }
        else if (total >= 4.0 && total < 4.5){
            gradeLetter = "B";
        }
        else if (total >= 3.5 && total < 4.0){
            gradeLetter = "C";
        }
        else if (total >= 3.0 && total < 3.5){
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }
        Console.WriteLine($"{students} \t\t{total} \t{gradeLetter}");
    }
    
    if (students == "Valentina"){
        sum = 0;
        foreach (double grade in gradeStudent2){
            sum += grade;
        }
        total = sum / 5;
        if (total > 4.5){
            gradeLetter = "A";
        }
        else if (total >= 4.0 && total < 4.5){
            gradeLetter = "B";
        }
        else if (total >= 3.5 && total < 4.0){
            gradeLetter = "C";
        }
        else if (total >= 3.0 && total < 3.5){
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }
        Console.WriteLine($"{students} \t{total} \t{gradeLetter}");
    }
    if (students == "Juan"){
        sum = 0;
        foreach (double grade in gradeStudent3){
            sum += grade;
        }
        total = sum / 5;
        if (total > 4.5){
            gradeLetter = "A";
        }
        else if (total >= 4.0 && total < 4.5){
            gradeLetter = "B";
        }
        else if (total >= 3.5 && total < 4.0){
            gradeLetter = "C";
        }
        else if (total >= 3.0 && total < 3.5){
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }
        Console.WriteLine($"{students} \t\t{total} \t{gradeLetter}");
    }
    if (students == "Sebastian"){
        sum = 0;
        foreach (double grade in gradeStudent4){
            sum += grade;
        }
        total = sum / 5;
        if (total > 4.5){
            gradeLetter = "A";
        }
        else if (total >= 4.0 && total < 4.5){
            gradeLetter = "B";
        }
        else if (total >= 3.5 && total < 4.0){
            gradeLetter = "C";
        }
        else if (total >= 3.0 && total < 3.5){
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }
        Console.WriteLine($"{students} \t{total} \t{gradeLetter}");
    }
    if (students == "Carlos"){
        sum = 0;
        foreach (double grade in gradeStudent5){
            sum += grade;
        }
        total = sum / 5;
        if (total > 4.5){
            gradeLetter = "A";
        }
        else if (total >= 4.0 && total < 4.5){
            gradeLetter = "B";
        }
        else if (total >= 3.5 && total < 4.0){
            gradeLetter = "C";
        }
        else if (total >= 3.0 && total < 3.5){
            gradeLetter = "D";
        }
        else {
            gradeLetter = "F";
        }
        Console.WriteLine($"{students} \t\t{total} \t{gradeLetter}");
    }

}
