using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
    // Интерфейс Субъекта объявляет общие операции как для Реального Субъекта,
    // так и для Заместителя. Пока клиент работает с Реальным Субъектом,
    // используя этот интерфейс, вы сможете передать ему заместителя вместо
    // реального субъекта.
    public interface ISubject
    {
        void Request();
    }
}
