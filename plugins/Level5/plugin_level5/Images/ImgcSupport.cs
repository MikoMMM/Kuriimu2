﻿using System.Collections.Generic;
using System.Drawing;
using Kanvas.Encoding;
using Kanvas.Swizzle;
using Komponent.IO.Attributes;
using Kontract.Kanvas;

namespace plugin_level5.Images
{
    class ImgcHeader
    {
        [FixedLength(8)]
        public string magic; // IMGC
        public short const2; // 30 00
        public byte imageFormat;
        public byte const3; // 01
        public byte imageCount;
        public byte bitDepth;
        public short bytesPerTile;
        public short width;
        public short height;
        public int const4; // 30 00 00 00
        public int const5; // 30 00 01 00
        public int tableDataOffset; // always 0x48
        public int const6; // 03 00 00 00
        public int const7; // 00 00 00 00
        public int const8; // 00 00 00 00
        public int const9; // 00 00 00 00
        public int const10; // 00 00 00 00
        public int tileTableSize;
        public int tileTableSizePadded;
        public int imgDataSize;
        public int const11; // 00 00 00 00
        public int const12; // 00 00 00 00
    }

    class ImgcSwizzle : IImageSwizzle
    {
        private readonly MasterSwizzle _zOrder;

        public int Width { get; }
        public int Height { get; }

        public ImgcSwizzle(int width, int height)
        {
            Width = (width + 0x7) & ~0x7;
            Height = (height + 0x7) & ~0x7;

            _zOrder = new MasterSwizzle(Width, new Point(0, 0), new[] { (0, 1), (1, 0), (0, 2), (2, 0), (0, 4), (4, 0) });
        }

        public Point Transform(Point point)
        {
            return _zOrder.Get(point.Y * Width + point.X);
        }
    }

    class ImgcSupport
    {
        // This mapping was determined through Inazuma Eleven GO Big Bang
        public static IDictionary<int, IColorEncoding> ImgcFormats = new Dictionary<int, IColorEncoding>
        {
            [0x00] = new Rgba(8, 8, 8, 8),
            [0x01] = new Rgba(4, 4, 4, 4),
            [0x02] = new Rgba(5, 5, 5, 1),
            [0x03] = new Rgba(8, 8, 8, "BGR"),
            [0x04] = new Rgba(5, 6, 5),

            [0x0A] = new La(8, 8),
            [0x0B] = new La(4, 4),
            [0x0C] = new La(8, 0),
            [0x0D] = new La(4, 0),
            [0x0E] = new La(0, 8),
            [0x0F] = new La(0, 4),

            [0x1B] = new Etc1(false, true),
            [0x1C] = new Etc1(true, true)
        };
    }
}
