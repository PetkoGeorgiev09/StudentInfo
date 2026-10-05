using StudentInfo;

Student student1 = new Student("Мария Иванова Георгиева", 10293, "Компютърни науки", "Втори курс");
student1.DisplayInfo();

Console.WriteLine();
Console.WriteLine("Невалидни данни:");
student1.FullName = "Аб"; 
student1.FacultyNumber = -100; 
