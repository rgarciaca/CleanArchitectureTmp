using FluentValidation.Results;

namespace CleanArchitectureTmp.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException() : base($"Ocurrieron uno o mas errores de validación")
        {
            Errors = new Dictionary<string, string[]>();
        }
        public ValidationException(IEnumerable<ValidationFailure> failures) : this() 
        {
            Errors =failures
                .GroupBy(f => f.PropertyName, e => e.ErrorMessage)
                .ToDictionary(fg => fg.Key, fg => fg.ToArray());
        }

    }
}
