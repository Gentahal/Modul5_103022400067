// See https://aka.ms/new-console-template for more information

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data: {storedData[i]}, yang disimpan pada waktu Input Date: {inputDates[i]}");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> database = new SimpleDataBase<int>();

        database.AddNewData(12);
        database.AddNewData(34);
        database.AddNewData(56);

        database.PrintAllData();
    }
}