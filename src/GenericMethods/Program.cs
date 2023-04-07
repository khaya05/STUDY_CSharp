Sample sample = new Sample();   
Employee employee = new Employee() { salary = 30_000};
Student student = new Student() { marks = 80 };

sample.PrintData<Student>(student);
sample.PrintData<Employee>(employee);