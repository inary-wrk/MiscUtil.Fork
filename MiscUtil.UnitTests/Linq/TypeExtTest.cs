#if DOTNET35
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using MiscUtil.Linq.Extensions;
using NUnit.Framework;

namespace MiscUtil.UnitTests.Linq
{
    [TestFixture]
    public class TypeExtTest
    {
        [Test]
        public void NullType0()
        {
            Type t = null;
            Assert.Throws<ArgumentNullException>(() => t.Ctor<object>());
        }
        [Test]
        public void NullType1()
        {
            Type t = null;
            Assert.Throws<ArgumentNullException>(() => t.Ctor<int, object>());
        }
        [Test]
        public void NullType2()
        {
            Type t = null;
            Assert.Throws<ArgumentNullException>(() => t.Ctor<int, float, object>());
        }
        [Test]
        public void NullType3()
        {
            Type t = null;
            Assert.Throws<ArgumentNullException>(() => t.Ctor<int, float, string, object>());
        }
        [Test]
        public void NullType4()
        {
            Type t = null;
            Assert.Throws<ArgumentNullException>(() => t.Ctor<int, float, string, decimal, object>());
        }
        [Test]
        public void Invalid0()
        {
            Type t = typeof(char[]);
            Assert.Throws<InvalidOperationException>(() => t.Ctor<string>());
        }
        [Test]
        public void Invalid1()
        {
            Assert.Throws<InvalidOperationException>(() => typeof(string).Ctor<int, string>());
        }
        [Test]
        public void Invalid2()
        {
            Assert.Throws<InvalidOperationException>(() => typeof(string).Ctor<int, float, string>());
        }
        [Test]
        public void Invalid3()
        {
            Assert.Throws<InvalidOperationException>(() => typeof(string).Ctor<int, float, string, string>());
        }
        [Test]
        public void Invalid4()
        {
            Assert.Throws<InvalidOperationException>(() => typeof(string).Ctor<int, float, string, decimal, string>());
        }

        [Test]
        public void Valid0()
        {
            var ctor = typeof(StringBuilder).Ctor<StringBuilder>();
            StringBuilder sb = ctor();
            Assert.IsNotNull(sb);
        }
        [Test]
        public void Valid1()
        {
            var ctor = typeof(char[]).Ctor<int, Array>();
            Array data = ctor(10);
            Assert.AreEqual(10, data.Length);
            Assert.IsNotNull(data);
        }
        [Test]
        public void Valid2()
        {
            var ctor = typeof(Complex).Ctor<decimal, decimal, Complex>();
            Complex c = ctor(4, 4);
            Assert.AreEqual(new Complex(4, 4), c);
        }
        [Test]
        public void Valid3()
        {
            var ctor = typeof(SqlCommand).Ctor<string, SqlConnection, SqlTransaction, IDbCommand>();
            IDbCommand c = ctor("test", null, null);
            Assert.IsNotNull(c);
            Assert.AreEqual("test", c.CommandText);
        }
        [Test]
        public void Valid4()
        {
            var ctor = typeof(DateTime).Ctor<int, int, int, Calendar, DateTime>();
            DateTime dt = ctor(2001, 2, 28, CultureInfo.CurrentCulture.Calendar);
            Assert.AreEqual(2001, dt.Year);
            Assert.AreEqual(2, dt.Month);
            Assert.AreEqual(28, dt.Day);
        }
    }
}
#endif