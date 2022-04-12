namespace Identity101.Models.Role
{
    public static class Roles
    {
        public static string Admin = "Admin";
        public static string User = "User";
        public static string Passive = "Passive";

        public static List<string> RoleList = new List<string>()
        {
            Admin,
            User,
            Passive

        };

    }
}