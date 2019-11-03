using Domain;

namespace Application.Boundaries.GetAccountDetails
{
    public interface IOutputPort
    {
        void Standard(GetAccountDetailsOutput getAccountDetailsOutput);
        void NotFound(string message);
    }
}