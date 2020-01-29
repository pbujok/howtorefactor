namespace Interview
{
    public static class UserContext
    {
        public static User User
        {
            get
            {
                return new User
                {
                    Name = "Adam Nowak"
                };
            }
        }
    }
}
