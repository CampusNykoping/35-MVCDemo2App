using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo2.Services;

public class TotalUsers
{
    public long TUsers()
    {
        Random random = new Random();
        return random.Next(10, 100);
    }
}
