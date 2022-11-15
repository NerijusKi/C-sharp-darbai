using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public interface ILendable
    {
        Book LendBoo(Book book);
        Magazine LendMagazine(Magazine magazine);

    }
   
}
