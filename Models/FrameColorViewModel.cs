using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GurpreetFrameAgency.Models
{
    public class FrameColorViewModel
    {
        public List<Frame> Frames { get; set; }
        public SelectList Colors { get; set; }
        public string FrameColor { get; set; }
        public string SearchString { get; set; }
    }
}
