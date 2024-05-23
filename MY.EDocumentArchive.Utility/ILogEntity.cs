using System;

namespace MY.EDocumentArchive.Utility
{
    public interface ILogEntity
    {
        string Creator { get; set; }
        DateTime CreationTime { get; set; }
        string LastModifier { get; set; }
        DateTime LastModificationTime { get; set; }
    }
}
