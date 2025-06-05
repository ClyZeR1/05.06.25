using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    enum Post
    {
        Менеджер = 160,
        Программист = 160,
        Тестировщик = 160,
        Дизайнер = 160
    }
    class Accountant
    {
        public bool AskForBonus(Post worker, int hoursWorked)
        {
            int requiredHours = (int)worker;
            return hoursWorked > requiredHours;
        }
    }
}
