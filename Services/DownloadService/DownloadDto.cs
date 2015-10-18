using System.Runtime.Serialization;

namespace DownloadService
{
    [DataContract]
    public class File
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public byte[] Content { get; set; }
    }
}
