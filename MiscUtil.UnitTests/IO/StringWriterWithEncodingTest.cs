using System;
using System.Globalization;
using System.IO;
using System.Text;
using MiscUtil.IO;
using NUnit.Framework;

namespace MiscUtil.UnitTests.IO
{
    [TestFixture]
    public class StringWriterWithEncodingTest
    {
        [Test]
        public void NullEncoding()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new StringWriterWithEncoding(null);
            });
        }

        [Test]
        public void NullEncodingWithFormat()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new StringWriterWithEncoding(CultureInfo.CurrentCulture, null);
            });
        }

        [Test]
        public void NullEncodingWithStringBuilder()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new StringWriterWithEncoding(new StringBuilder(), null);
            });
        }

        [Test]
        public void NullEncodingWithStringBuilderAndFormat()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                new StringWriterWithEncoding(new StringBuilder(), CultureInfo.CurrentCulture, null);
            });
        }

        [Test]
        public void EncodingIsReturnedConstructingWithJustEncoding()
        {
            // Create a new one so we are really sure it's not fiddling things
            Encoding enc = new ASCIIEncoding();

            StringWriter writer = new StringWriterWithEncoding(enc);
            Assert.AreSame(enc, writer.Encoding);
        }

        [Test]
        public void EncodingIsReturnedConstructingWithFormat()
        {
            // Create a new one so we are really sure it's not fiddling things
            Encoding enc = new ASCIIEncoding();

            StringWriter writer = new StringWriterWithEncoding(CultureInfo.CurrentCulture, enc);
            Assert.AreSame(enc, writer.Encoding);
        }


        [Test]
        public void EncodingIsReturnedConstructingWithStringBuilder()
        {
            // Create a new one so we are really sure it's not fiddling things
            Encoding enc = new ASCIIEncoding();

            StringWriter writer = new StringWriterWithEncoding(new StringBuilder(), enc);
            Assert.AreSame(enc, writer.Encoding);
        }

        [Test]
        public void EncodingIsReturnedConstructingWithStringBuilderAndFormat()
        {
            // Create a new one so we are really sure it's not fiddling things
            Encoding enc = new ASCIIEncoding();

            StringWriter writer = new StringWriterWithEncoding(new StringBuilder(), 
                                                               CultureInfo.CurrentCulture,
                                                               enc);
            Assert.AreSame(enc, writer.Encoding);
        }
    }
}
