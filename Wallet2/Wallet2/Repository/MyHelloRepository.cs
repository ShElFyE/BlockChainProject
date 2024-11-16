public class MyHelloRepository : IMyRepository
{
    private readonly MyDbContext _context;

    public MyHelloRepository(MyDbContext context)
    {
        _context = context;
    }

    public string GetTestMessage()
    {
        var entity = _context.MyEntity.FirstOrDefault();
        return entity?.Message ?? "No data found in database";
    }
}
