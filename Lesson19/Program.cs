Department dep1 = new Department(0, "Информационные технологии");
Department dep2 = new Department(1, "Отдел кадров");
Department dep3 = new Department(2, "Бухгалтерия");

Worker worker1 = new Worker(0, 2, 23, "Мария Ивановна", 7734);
Worker worker2 = new Worker(1, 0, 26, "Мария Степановна", 3456);
Worker worker3 = new Worker(2, 2, 33, "Василий Петрович", 5432);
Worker worker4 = new Worker(3, 0, 23, "Игнат Петрович", 1432);

DataBase db = new();

db.AppendDep(dep1);
db.AppendDep(dep2);
db.AppendDep(dep3);

db.AppendWorker(worker1);
db.AppendWorker(worker2);
db.AppendWorker(worker3);
db.AppendWorker(worker4);

Console.WriteLine(db.SelectAllDep());
Console.WriteLine(db.SelectAllWorker());