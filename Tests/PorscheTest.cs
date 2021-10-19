using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaigiamasisDarbas2.Tests
{
    public class PorscheTest : BaseTest
    {
        [Test]
        public static void TestCookie()
        {
            _porschePage.NavigateToDefaultPage()
                .AcceptCookies();
        }
    }
}
