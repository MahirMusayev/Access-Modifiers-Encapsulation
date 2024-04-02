namespace Access_Modifiers__Encapsulation_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon(30, 20, 5);
            bool dur = true;

            while (dur)
            {
                Menu();
                string num = Console.ReadLine();
                switch (num)
                {
                    case "0":
                        weapon.ShowInformation();
                        break;
                    case "1":
                        weapon.Shoot();
                        break;
                    case "2":
                        weapon.Fire();
                        break;
                    case "3":
                        weapon.GetRemainBulletCount();
                        break;
                    case "4":
                        weapon.Reload();
                        break;
                    case "5":
                        weapon.ChangeFireMode();
                        break;
                    case "6":
                        dur = false;
                        break;
                    case "T":
                        Console.WriteLine("Enter new bullet capacity:");
                        int newCapacity = int.Parse(Console.ReadLine());
                        weapon.BulletCapacity = newCapacity;
                        break;
                    case "S":
                        Console.WriteLine("Enter new bullet count:");
                        int newnum  = int.Parse(Console.ReadLine());
                        weapon.BulletNumber = newnum;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;

                }
                //Console.ReadKey(); 
                //Console.Clear();


            }
            static void Menu()
            {
                Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün");
            }

        }
    }
}
