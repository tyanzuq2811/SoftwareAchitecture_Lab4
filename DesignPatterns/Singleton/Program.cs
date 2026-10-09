using Singleton;

Database db1 = Database.GetInstance();
Database db2 = Database.GetInstance();
if (db1 == db2)
{
    Console.WriteLine("Both instances are the same.");
}
else
{
    Console.WriteLine("Instances are different.");
}