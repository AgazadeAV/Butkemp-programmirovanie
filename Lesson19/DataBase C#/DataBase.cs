class DataBase
{
    List<Department> depTable;
    List<Worker> workerTable;

    public DataBase()
    {
        depTable = new List<Department>();
        workerTable = new List<Worker>();
    }

    public void AppendWorker(Worker worker)
    {
        workerTable.Add(worker);
    }

    public void AppendDep(Department dep)
    {
        depTable.Add(dep);
    }

    public string SelectAllDep()
    {
        string output = "";

        foreach (var d in depTable)
        {
            output += $"{d.title}\n";
        }
        return output;
    }

    public string SelectAllWorker()
    {
        string output = "";

        foreach (var w in workerTable)
        {
            output += $"{w.fullName}  {w.age}\n";
        }
        return output;
    }

    public List<Tuple<string, int, string>> Report()
    {
        var rep = new List<Tuple<string, int, string>>();

        foreach (var w in workerTable)
        {
            rep.Add(new Tuple<string, int, string>(w.fullName, w.age, depTable[w.depId].title));
        }
        return rep;
    }
}