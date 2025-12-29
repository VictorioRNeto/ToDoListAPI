using Microsoft.EntityFrameworkCore;

class TodoDb : DbContext
{
    //chamado do constructor
    public TodoDb(DbContextOptions<TodoDb> options) : base(options){}
    public DbSet<Todo> Todos => Set<Todo>();
    //Aceso ao DB Todo

}