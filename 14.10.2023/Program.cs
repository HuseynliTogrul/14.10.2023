Student student = new Student();
student.Name = "Togrul";
student.SurName = "Huseynli";
student.GetName(student.Name, student.SurName);


student.Group = 655.19;
student.Point = 70;
student.isGraduated = true;
student.GetValue(student.Group, student.Point, student.isGraduated);
student.EnterExam();