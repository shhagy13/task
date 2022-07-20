using System.ComponentModel;

namespace WebApplication2.DTO
{
    public class FieldError
    {
        [ReadOnly(true)]
        public string? code { get; private set; }
        public string? field { get; set; }
        [ReadOnly(true)]
        public string? message { get; private set; }
    }
}
