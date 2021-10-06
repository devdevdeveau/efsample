using System.Threading;
using System.Threading.Tasks;

namespace EFSample1
{
    public class EntityFrameworkPlayground
    {
        private readonly MyDbContext _myDbContext;

        public EntityFrameworkPlayground(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public async Task RunEfCommands(CancellationToken cancellationToken)
        {
            _myDbContext.Users.Add(new User
            {
                Email = "Test@test.com",
                Firstname = nameof(User.Firstname),
                LastName = nameof(User.LastName),
                Student = new Student()
            });

            await _myDbContext.SaveChangesAsync(cancellationToken);
        }
    }
}