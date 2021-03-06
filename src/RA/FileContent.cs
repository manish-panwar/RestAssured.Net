namespace RA
{
    public class FileContent
    {
        public FileContent(string name, string fileName, string contentDispositionName, string contentType, byte[] content)
        {
            Name = name;
            FileName = fileName;
            ContentType = contentType;
            ContentDispositionName = contentDispositionName;
            Content = content;
        }

        public string Name { get; private set; }
        public string FileName { get; private set; }
        public string ContentType { get; private set; }
        public string ContentDispositionName { get; private set; }
        public byte[] Content { get; private set; }
    }
}