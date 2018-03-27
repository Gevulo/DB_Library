using System;

internal class EfUserRepository
{
    private DbContextFactory dbContextFactory;

    public EfUserRepository(DbContextFactory dbContextFactory)
    {
        this.dbContextFactory = dbContextFactory;
    }

    internal object Create(object username)
    {
        throw new NotImplementedException();
    }

    internal object ReadById(object id)
    {
        throw new NotImplementedException();
    }
}