using System.Data.SQLite;

internal class Program
{
    private static void Main(string[] args)
    {

        //CreateTable(NewConnection());
        //InsertData(NewConnection());
        ReadData(NewConnection());

    }

    //Establece la conexión
    static SQLiteConnection NewConnection()
    {
        string bd = "database_ex1.db";

        string direccion = $"C:\\Users\\alu\\SQLite_DB\\{bd}; Version=3; New=Flase; Compress=True";

        SQLiteConnection conn = new SQLiteConnection("Data Source = " + direccion);

        try
        {
            conn.Open();
            Console.WriteLine($"Conexión a la BD: {bd} con éxito!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }

        return conn;
    }

    //crear tabla
    static void CreateTable(SQLiteConnection conn)
    {
        string createSql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";

        SQLiteCommand cmd = conn.CreateCommand();
        cmd.CommandText = createSql;

        try 
        {
            cmd.ExecuteNonQuery();
            Console.WriteLine("Query 'CREATE TABLE' ejecutada con éxito!");
        } 
        catch (Exception e) 
        { 
            Console.WriteLine($"Error: {e}");
        }
        finally
        {
            if (conn != null) conn.Close();
        }

    }

    //insert data
    static void InsertData(SQLiteConnection conn)
    {
        string insertSql1 = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test1 Text', 1)";
        string insertSql2 = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test2 Text', 2)";
        string insertSql3 = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test3 Text', 3)";

        SQLiteCommand cmd = conn.CreateCommand();
        
        try
        {
            cmd.CommandText = insertSql1;
            cmd.ExecuteNonQuery();
            cmd.CommandText = insertSql2;
            cmd.ExecuteNonQuery();
            cmd.CommandText = insertSql3;
            cmd.ExecuteNonQuery();
            Console.WriteLine("Query ''INSERT'' ejecutada con éxito!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }
        finally
        {
            if (conn != null) conn.Close();
        }

    }

    //read data
    static void ReadData(SQLiteConnection conn)
    {
        string readSql = "SELECT * FROM SampleTable";

        SQLiteDataReader sQLiteDataReader;
        SQLiteCommand sQLiteCommand;

        sQLiteCommand = conn.CreateCommand();
        sQLiteCommand.CommandText = readSql;

        try
        {
            sQLiteDataReader = sQLiteCommand.ExecuteReader();

            while (sQLiteDataReader.Read())
            {
                string myReader = sQLiteDataReader.GetString(0);
                int myInt = sQLiteDataReader.GetInt16(1);
                Console.WriteLine(myReader + " " + myInt);
            }


        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e}");
        }
        finally
        {
            if (conn != null) conn.Close();
        }

    }

}