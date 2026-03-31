using System.Runtime.InteropServices;

public class SimpleDataBase<T>
{
    List<T> storedData = new List<T>();
    List<DateTime> inputDate = new List<DateTime>();

    public SimpleDataBase()
    {
        storedData.Clear();
    }

    public void AddNewData<T>(T data)
    {
        dynamic dataAkhir = data;
        storedData.Add(dataAkhir);
        inputDate.Add(DateTime.Now);
    }

    public void printAllData() {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine("Data " + (i + 1) + " Berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDate[i]);
        }
    }
}

public class main
{
    public static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();

        data.AddNewData<int>(12);
        data.AddNewData<int>(34);
        data.AddNewData<int>(36);

        data.printAllData();

    }
}
