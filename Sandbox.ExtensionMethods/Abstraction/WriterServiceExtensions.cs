using System.Text;

namespace sanbox_extensionMethods.Abstraction
{
    public static class WriterServiceExtensions
    {
        /// <summary>
        /// <para>Write using the default encoding <see cref="Encoding.Default"/></para>
        /// <para>This extension will be available to all implementers of <see cref="IWriterService"/></para>
        /// </summary>
        public static void Write(this IWriterService writer, string content)
        {
            writer.Write(content, Encoding.Default);
        }
    }
}