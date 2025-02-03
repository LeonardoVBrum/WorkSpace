using Application.UseCQ.ViewModels;
using MediatR;

namespace Application.UseCQ.Commands
{
                                       // IRequest vem do Pacote Mediator >> e configuramos o response do Usuario 
    public record CreateUserCommand : IRequest<UserInfoViewModel>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
    }
}
