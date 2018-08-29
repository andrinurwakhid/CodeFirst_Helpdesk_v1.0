using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_CodeFirst.Controllers;
namespace Helpdesk_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            int menudefault;
        mdefault:
            Console.WriteLine("==================[ CRUD ]===================");
            Console.WriteLine("||    1. CREATE      ||    3. UPDATE       ||");
            Console.WriteLine("||    2. READ        ||    4. DELETE       ||");
            Console.WriteLine("||                5. EXIT                  ||");
            Console.WriteLine("=============================================");
            Console.Write("Tentukan Pilihanmu : "); menudefault = Convert.ToInt32(Console.ReadLine());
            switch (menudefault)
            {
                case 1:
                    Program mc1 = new Program();
                    mc1.m1();
                    break;
                case 2:
                    Program mc2 = new Program();
                    mc2.m2();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto mdefault;
            }
        }
        public void isimenu()
        {
            Console.WriteLine("||    1. ROLE        ||    4. CATEGORY     ||");
            Console.WriteLine("||    2. USER        ||    5. SUBCATEGORY  ||");
            Console.WriteLine("||    3. DEPARTMENT  ||    6. TICKET       ||");
            Console.WriteLine("||                7. EXIT                  ||");
            Console.WriteLine("=============================================");
        }
        public void m1()
        {
            int menu1;
        m1:
            Console.Clear();
            Console.WriteLine("================== CREATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu1 = Convert.ToInt32(Console.ReadLine());
            switch (menu1)
            {
                case 1:
                    RoleController panggilrole = new RoleController();
                    panggilrole.InsertRole();
                    Console.WriteLine("Sukses");
                    goto m1;
                case 2:
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m1;
            }
        }
        public void m2()
        {
            int menu2;
        m2:
            Console.Clear();
            Console.WriteLine("=================== READ ====================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu2 = Convert.ToInt32(Console.ReadLine());
            switch (menu2)
            {
                case 1:
                    RoleController panggilrole = new RoleController();
                    panggilrole.GetAllRole();
                    Console.WriteLine("Sukses");
                    break;
                case 2:
                    Console.WriteLine("Sukses");
                    break;
                case 3:
                    Console.WriteLine("Sukses");
                    break;
                case 4:
                    Console.WriteLine("Sukses");
                    break;
                case 5:
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m2;
            }
        }
    }
}
