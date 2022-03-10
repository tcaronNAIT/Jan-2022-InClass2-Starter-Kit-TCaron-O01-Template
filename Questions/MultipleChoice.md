# InClass2 - Classes, Objects, and File I/O

## Multiple Choice

( **1 mark each** ) For each of the following questions, select the best answer that applies.

## PUT YOUR ANSWERS IN THE **feedback.md** FILE THAT IS IN THE **feedback** FOLDER

------------------------------------------------------------------------


```csharp
01    using src;
02    using System.Collections.Generic;
03
04        try
05        {
06            Student theStudent = new Student("Joe");
07            StudentInfo theStudentInfo = new StudentInfo(theStudent);
08            theStudentInfo.AddMark(new Mark("Math", 67.0, 80.0));
09            Console.WriteLine(theStudentInfo.Student.ToString());
10            foreach (Mark item in theStudentInfo.Marks)
11            Console.WriteLine(item.ToString());
12        }
13        catch (Exception ex)
14        {
15            Console.WriteLine($"Exception: {ex.Message}");
16        } 
17    namespace src
18    {
19        internal class Student
20        {
21            public readonly string StudentName;
22            public Student(string studentName)
23            {
24                StudentName = studentName;
25            }
26            public override string ToString()
27            {
28                return $"Student Name: {StudentName}";
29            }        
30        }
31        internal class Mark
32        {
33            public readonly string CourseName;
34            public readonly double RawMark;
35            public readonly double PossibleMarks;
36            public double MarkInPercent {get {return (RawMark/PossibleMarks * 100);}}
37            public Mark(string courseName, double rawMark, double possibleMarks)
38            {
39                CourseName = courseName;
30                RawMark = rawMark;
41                PossibleMarks = possibleMarks;
42            }
43            public override string ToString()
44            {
45                return $"Course Name: {CourseName}, Mark in Percent: {MarkInPercent}";
46            }             
47        }
48        internal class StudentInfo
49        {
50            public Student Student { get; private set; }
51            public List<Mark> Marks { get; set; } = new();
52            public StudentInfo(Student student)
53            {
54                Student = student;
55            }
56            public void AddMark(Mark mark)
57            {
58                if (mark == null)
59                    throw new ArgumentNullException("No mark supplied. Mark not added.");
60                Marks.Add(mark); 
61            } 
62        }
63    }
```


1)	Which term best describes the words `System.Collections.Generic` from line 02 of the code above?

```
a.	Class Name
b.	Method Name
c.	Object Name
d.	Namespace
```

2)	Which term best describes the word `”Joe”` from line 06 of the code above?

```
a.	Data Type
b.	Variable
c.	Literal Value
d.	Expression
```

3)	Which term best describes the words `Student(“Joe”)` from line 06 of the code above?

```
a.	Instance Method Call
b.	Static Method Call
c.	Global Method Call
d.	Constructor Call
```

4)	Which term best describes the word `AddMark` from line 08 of the code above?

```
a.	Instance Method Call
b.	Class Method Call
c.	Global Method Call
d.	Constructor Call
```

5)	Which term best describes the word `”Math”` from line 08 of the code above?

```
a.	Parameter
b.	Return Type
c.	Argument
d.	Constructor
```

6)	Which term best describes the word `WriteLine` from line 09 of the code above?

```
a.	Instance Method Call
b.	Class Method Call
c.	Global Method Call
d.	Constructor Call
```

7)	Which term best describes line 21 of the code above?

```
a.	Auto-Implemented Property
b.	Fully-Implemented Property
c.	Field
d.	Constructor
e.	Method
```

8)	Which term best describes the word `string` from line 22 of the code above?

```
a.	Data Type
b.	Variable
c.	Literal Value
d.	Expression
```

9)	Which term best describes the words `string studentName` from line 22 of the code above?

```
a.	Argument
b.	Return Type
c.	Parameter
d.	Constructor
```

10)	Which term best describes the word `RawMark` from line 36 of the code above?

```
a.	Local Variable
b.	Field
c.	Property
d.	Method Name
```

11)	Which term best describes the word `MarkInPercent` from line 36 of the code above?

```
a.	Local Variable
b.	Field
c.	Property
d.	Method Name
e.	Class
```

12)	Which term best describes line 36 of the code above?

```
a.	Auto-Implemented Property
b.	Fully-Implemented Property
c.	Field
d.	Constructor
e.	Method
```

13)	Which term best describes the word `Mark` from line 37 of the code above?

```
a.	Local Variable
b.	Field
c.	Property
d.	Method Name
e.	Constructor
```

14)	Which term best describes the word `string` from line 43 of the code above?

```
a.	Argument
b.	Return Type
c.	Parameter
d.	Constructor
```

15)	Which term best describes line 43 of the code above?

```
a.	Auto-Implemented Property
b.	Fully-Implemented Property
c.	Field
d.	Constructor
e.	Method
```
16)	Which term best describes line 50 of the code above?

```
a.	Auto-Implemented Property
b.	Fully-Implemented Property
c.	Field
d.	Constructor
e.	Method
```

17)	Which term best describes line 52 of the code above?

```
a.	Auto-Implemented Property
b.	Fully-Implemented Property
c.	Field
d.	Constructor
e.	Method
```

18)	Which term best describes the word `AddMark` from line 56 of the code above?

```
a.	Local Variable
b.	Field
c.	Property
d.	Method Name
e.	Parameter
```

19)	Which term best describes the word `void` from line 56 of the code above?

```
a.	Argument
b.	Return Type
c.	Parameter
d.	Constructor
```

20)	Which term best describes line 56 of the code above?

```
a.	Auto-Implemented Property
b.	Fully-Implemented Property
c.	Field
d.	Constructor
e.	Method
```
