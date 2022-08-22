using CMA.ErrorHandling.Exceptions;
using CMA.ErrorHandling.Exceptions.Execptions;
using CMA.ErrorHandling.GlobalHandling.Domain.Interfaces;

namespace CMA.ErrorHandling.GlobalHandling.Domain.Service
{
    public class ErrorHandlingService : IErrorHandlingService
    {
        public void Error() => throw new AppErrorException("Error");

        public void Success()
        {
            
        }
    }
}