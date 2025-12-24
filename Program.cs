namespace SWE201_235060003
{
    using GymManagementApp.Services;

    class Program
    {
        static void Main(string[] args)
        {
            GymManager gymManager = new GymManager();
            gymManager.Start();
        }
    }

}
