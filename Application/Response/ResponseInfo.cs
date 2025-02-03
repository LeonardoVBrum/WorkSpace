using System.Runtime;

namespace Application.Response
{
    public record ResponseInfo
    {
        public string Title { get; set; }
        public string ErroDescription { get; set; }
        public int HTTPStatus { get; set; }
    }
}
