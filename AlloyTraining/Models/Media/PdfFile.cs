using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Portable Document Format",
        // your code will have a GUID
        GUID = "5BC22BAB-A067-4446-AE59-484FE600BA56",
        Description = "Use this to upload Portable Document Format (PDF) files.")]
    [MediaDescriptor(ExtensionString = "pdf")]
    public class PdfFile : MediaData
    {
        [Display(Name = "Render preview image")]
        // false: render as simple hyperlink
        // true: render as clickable thumbnail preview image
        public virtual bool RenderPreviewImage { get; set; }
    }
}