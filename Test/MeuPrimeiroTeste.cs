using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class MeuPrimeiroTeste
    {
        [Fact(DisplayName ="Testar")]
        public void Testar()
        {
            var n1 = 1;
            var n2 = 2;

            Assert.Equal(n1,n2);
        }
    }
}
