namespace API
{
    public class QueryTest
    {
        //[UseProjection]
        public IQueryable<Entidad> GetEntidades([Service] ElDbContext _db)
        => _db.Entidades;
    }
}
