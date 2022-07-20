using System.ComponentModel;

namespace WebApplication2.DTO
{
    public class Error
    {
        [ReadOnly(true)]
        public string? code { get;  set; }
        [ReadOnly(true)]
        public string? message { get;  set; }
    }
}
