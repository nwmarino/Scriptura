using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Scriptura
{
    public class SxRenderer : ToolStripProfessionalRenderer
    {
        protected readonly Color theme;
        public SxRenderer(Color theme) : base(new ColorTable(theme)) { }
    }
    public class ColorTable : ProfessionalColorTable
    {
        private readonly Color theme;
        public ColorTable(Color theme)
        {
            this.theme = theme;
            base.UseSystemColors = false;
        }
        // drop down area border
        public override Color MenuBorder
        {
            get { return Color.FromArgb(100,100,100); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }

        // drop down area to the right of image
        public override Color ToolStripDropDownBackground
        {
            get { return theme; }
        }
        // drop down area around image
        public override Color ImageMarginGradientBegin
        {
            get { return theme; }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return theme; }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return theme; }
        }
        // menu item background when pressed
        public override Color MenuItemPressedGradientBegin
        {
            get { return theme; }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return theme; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return theme; }
        }
        // hover colors
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(50, 50, 50); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(50, 50, 50); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(50, 50, 50); }
        }
        // color of seperator
        public override Color SeparatorDark
        {
            get { return Color.FromArgb(100, 100, 100); }
        }
    }
}
