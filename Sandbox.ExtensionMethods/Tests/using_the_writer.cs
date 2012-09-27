using System;
using System.Text;

using Moq;

using Xunit;

using sanbox_extensionMethods.Abstraction;
using sanbox_extensionMethods.Implementation;

namespace sanbox_extensionMethods.Tests
{
    public class using_the_writer
    {
        void extension_calls_service()
        {
            const string content = "Hello";
            var moq = new Mock<IWriterService>();
            moq
                .Setup(x => x.Write(content, Encoding.Default))
                .Verifiable();

            // act
            moq.Object.Write(content);

            // assert
            moq.Verify();
        }
    }
}