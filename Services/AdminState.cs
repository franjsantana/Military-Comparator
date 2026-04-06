namespace MilitaryComparator.Services
{
    public class AdminState
    {
        public bool IsAuthenticated { get; set; } = false;
        
        public void Authenticate() => IsAuthenticated = true;
        public void Logout() => IsAuthenticated = false;
    }
}
