using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Any File",
        GUID = "9568fec6-8b4c-425e-83fa-adcc80934381",
        Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
    }
}