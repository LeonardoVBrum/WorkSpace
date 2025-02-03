using Application.UseCQ.Commands;
using Application.UseCQ.ViewModels;
using Domain.Entity;
using Infraestructure.Percistence;
using MediatR;
using System.Reflection.Metadata.Ecma335;

namespace Application.UseCQ.Handllers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, UserInfoViewModel>
    {
        private readonly TaskDbContext _taskDbContext;
        public CreateUserCommandHandler(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public async Task<UserInfoViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            
            var user = new User()
            {
                Name = request.Name,
                Surname = request.Surname,
                Email = request.Email,
                PasswordHash = request.Password,
                Username = request.Username,
                RefreshToken = Guid.NewGuid().ToString(),
                RefreshTokenExpirationTime = DateTime.Now.AddDays(5)

            };
            _taskDbContext.Users.Add(user);
            _taskDbContext.SaveChanges();

            var userInfo = new UserInfoViewModel()
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Username = user.Username,
                RefreshToken = user.RefreshToken,
                RefreshTojenExpirationTime = user.RefreshTokenExpirationTime,
                TokenJWT = Guid.NewGuid().ToString()
            };
            return userInfo;

        }

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }

    }


}


