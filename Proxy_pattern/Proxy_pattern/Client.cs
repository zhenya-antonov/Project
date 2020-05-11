using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_pattern
{
    public class Client
    {
        // Клиентский код должен работать со всеми объектами (как с реальными,
        // так и заместителями) через интерфейс Субъекта, чтобы поддерживать как
        // реальные субъекты, так и заместителей. В реальной жизни, однако,
        // клиенты в основном работают с реальными субъектами напрямую. В этом
        // случае, для более простой реализации паттерна, можно расширить
        // заместителя из класса реального субъекта.
        public void ClientCode(ISubject subject)
        {
            // ...

            subject.Request();

            // ...
        }
    }
}
