using System.Text;

namespace sanbox_extensionMethods.Abstraction
{
    /// <summary>
    /// <para>Service Interface</para>
    /// </summary>
    public interface IWriterService
    {
        /// <summary>
        /// <para>Write method</para>
        /// <para>This contains all parameters required and optional to be passed</para>
        /// <para>All that implement this interface must implement this method only</para>
        /// </summary>
        void Write(string content, Encoding encoding);
    }
}