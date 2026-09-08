// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
string myName = "Виктория Мушникова";
string groupName = "ИСП-251";
int courseNumber = 2;
double averageGrade = 4.6;
bool isBudget = true;

Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");


Console.WriteLine();
Console.WriteLine("Ремонт: комната");

double roomWidth = 3.5;
double roomLenght = 4.2;

double roomArea = roomWidth * roomLenght;
double roomPerimeter = (roomWidth + roomLenght) * 2;

Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLenght} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");


Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");

int laptopPrice = 65000;
int monthsCount = 12;
double interesRate = 0.08;

double totalWithInterest = laptopPrice * (1 + interesRate);
double monthlyPayment = totalWithInterest / monthsCount;

Console.WriteLine($"Цена ноутбука: {laptopPrice} руб.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");


Console.WriteLine();
Console.WriteLine("Внимание: деление int");

int totalStudents = 25;
int groupsCount = 4;
int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;
Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");


Console.WriteLine();
Console.WriteLine("Способы собрать строку");

string firstName = "Анна";
string lastName = "Смирнова";

// Способ 1: конкатенация через оператор +
string fullNameConcat = firstName + " " + lastName;

//Способ 2: интерполяция через $" "
string fullNameInterp = $"{firstName} {lastName}";

//Способ 3: метод string.Concat
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");


Console.WriteLine();
Console.WriteLine("Константы");

const double VatRate = 0.18;
const string CollegeName = "ВФ ВолГУ";

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, С НДС ({VatRate}): {priceWithVat}");


//Однострочный комментарий - до конца строки

/*
Многострочный комментарий - может занимать несколько строк
*/

// TODO: часто используют, чтобы отметить недоделанный участок кода


// See https://aka.ms/new-console-template for more information
Console.WriteLine("ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
const string Name = "Мушникова Виктория Андреевна";
string group = "ИСП-251";
int course = 2;
string spesial = "09.02.07";
int isb = 16;
bool ctipendia = true;
int work1 = 5;
int work2 = 4;
int work3 = 5;
double work = (work1 + work2 + work3) / 3;




Console.WriteLine($"ФИО: {Name}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {spesial}");

Console.WriteLine($"Средний балл за 3 работы: {work}");
Console.WriteLine($"Стипендия положена (>= 4.0): {ctipendia}");

Console.WriteLine($"Учебных недель осталось в семестре: {isb}");














