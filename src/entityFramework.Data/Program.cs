namespace entityFramework.Data
{
    public static class Program
    {
        // - Taken from http://benjii.me/2016/06/entity-framework-core-migrations-for-class-library-projects/
        //   to make EF work.
        // - Used this to generate EF scaffolding at the command line in the root of the project:
        //     dotnet ef dbcontext scaffold "server=localhost;database=MyDatabaseName;Trusted_Connection=true;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models/EF
        public static void Main(string[] args)
        {
        }
    }
}