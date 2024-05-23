using System;

namespace MY.EDocumentArchive.Model
{
    public class Person : Utility.BaseEntity, Utility.ILogEntity
    {
        public DateTime CreationTime { get; set; }
        public string LastModifier { get; set; }
        public DateTime LastModificationTime { get; set; }
        public string Creator { get; set; }
    }
}