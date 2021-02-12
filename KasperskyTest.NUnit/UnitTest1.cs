using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KasperskyTest.NUnit
{
    public class ExceptionTests
    {
        private FileProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new FileProcessor();
        }

        [Test]
        public void UnknownFormatTest()
        {
            Assert.Multiple(() =>
            {
                Assert.Throws<KeyNotFoundException>(() => _processor.ProcessFile("file.Unknown"));
                Assert.Throws<KeyNotFoundException>(() => _processor.ProcessFile("binary"));
            });
        }

        [Test]
        public void NullArgumentTest()
        {
            Assert.Throws<ArgumentNullException>(() => _processor.ProcessFile(null));
        }
    }

    public class FormatTests
    {
        private FileProcessor _processor;

        [SetUp]
        public void Setup()
        {
            _processor = new FileProcessor();
        }


        [Test]
        public void JsonTest()
        {
            Assert.Multiple(() =>
            {
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.Json"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.json"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.JSON"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.JsoN"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.jSoN"));
            });
        }

        [Test]
        public void HtmlTest()
        {
            Assert.Multiple(() =>
            {
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.html"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.HTML"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.htMl"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.HTml"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.hTML"));
            });
        }

        [Test]
        public void TxtTest()
        {
            Assert.Multiple(() =>
            {
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.txt"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.TXT"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.tXt"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.TXt"));
                Assert.DoesNotThrow(() => _processor.ProcessFile("file.TxT"));
            });
        }
    }
}