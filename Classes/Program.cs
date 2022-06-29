using System.Globalization;
using Classes;
using CsvHelper;
using CsvHelper.Configuration;





using (var reader = new StreamReader("C:\\Users\\Ng_Le\\source\\repos\\Classes\\Classes\\biostats2.csv"))
using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
{
    var records = new List<Person>();
    csv.Read();     
    csv.ReadHeader();
    while (csv.Read())
    {
        var record = new Person()
        {
            Name = csv.GetField("Name").ToString(),
            Sex = char.Parse(csv.GetField("Sex").ToString()),
            Age = int.Parse(csv.GetField("Age").ToString()),
            Height = int.Parse(csv.GetField("Height").ToString()),
            Weight = float.Parse(csv.GetField("Weight").ToString())
        };
        records.Add(record);
    }


    for (int i = 0; i < records.Count; i++)
        Console.WriteLine(records[i].Name);



}


