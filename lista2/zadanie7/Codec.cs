using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class Codec
    { 
        public Codec(ImageCodecInfo item)
        {
            Name = item.CodecName;
            Extension = item.FilenameExtension;
            Flags = item.Flags;
        }

        public string Name { get; set; }
        public string Extension { get; set; }
        public ImageCodecFlags Flags { get; set; }
        public override string ToString()
        {
            return Name;
            //return $"Name: {Name}\nExtension type: {Extension}\nFlags: {Flags}";
        }
        public string GetCodecInfo()
        {
            return $"Name: {Name}\nExtension type: {Extension}\nFlags: {Flags}";
        }
    }
}
