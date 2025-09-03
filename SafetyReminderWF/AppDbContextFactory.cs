using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SafetyReminderWF;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var cs = Environment.GetEnvironmentVariable("SAFETY_DB")
                 ?? "Server=127.0.0.1;Port=3306;Database=safety_reminder;User Id=root;Password=Kossan@123456;";
        var version = new MySqlServerVersion(new Version(8, 0, 36));

        var builder = new DbContextOptionsBuilder<AppDbContext>()
            .UseMySql(cs, version);

        return new AppDbContext(builder.Options);
    }
}
