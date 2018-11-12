using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MVCSampleBrowser.Models
{

    public  class DropDownData
    {
        public DropDownData(string _text, string _value)
        {
            this.text = _text;
            this.value = _value;
        }

        public DropDownData() { }

       
        public string text
        {
            get;
            set;
        }
      
        public string value
        {
            get;
            set;
        }

        public static List<DropDownData> GetColors()
        {
            List<DropDownData> PageData = new List<DropDownData>();
            PageData.Add(new DropDownData("White", "white"));
            PageData.Add(new DropDownData("#1a1a1a", "#1a1a1a"));
            PageData.Add(new DropDownData("Black", "black"));
            PageData.Add(new DropDownData("Goldenrod", "goldenrod"));
            PageData.Add(new DropDownData("Indigo", "indigo"));
            PageData.Add(new DropDownData("Chocolate", "chocolate"));
            PageData.Add(new DropDownData("DarkGoldenRod", "darkgoldenrod"));
            PageData.Add(new DropDownData("FireBrick", "firebrick"));
            return PageData;
        }
        public static List<DropDownData> GetSnapItems()
        {
            List<DropDownData> SnapData = new List<DropDownData>();
            SnapData.Add(new DropDownData("ShowLines", "ShowLines"));
            SnapData.Add(new DropDownData("None", "None"));
            SnapData.Add(new DropDownData("SnapToHorizontalLines", "SnapToHorizontalLines"));
            SnapData.Add(new DropDownData("SnapToVerticalLines", "SnapToVerticalLines"));
            SnapData.Add(new DropDownData("SnapToLines", "SnapToLines"));
            SnapData.Add(new DropDownData("ShowHorizontalLines", "ShowHorizontalLines"));
            SnapData.Add(new DropDownData("ShowVerticalLines", "ShowVerticalLines"));
            SnapData.Add(new DropDownData("All", "All"));
            return SnapData;
        }

        public static List<DropDownData> GetBoundary()
        {
            List<DropDownData> BoundaryData = new List<DropDownData>();
            BoundaryData.Add(new DropDownData("Diagram", "diagram"));
            BoundaryData.Add(new DropDownData("Page", "page"));
            BoundaryData.Add(new DropDownData("Infinity", "infinity"));
            return BoundaryData;
        }

        public static List<DropDownData> GetOrientation()
        {
            List<DropDownData> OrientationData = new List<DropDownData>();
            OrientationData.Add(new DropDownData("Portrait", "portrait"));
            OrientationData.Add(new DropDownData("Landscape", "landscape"));
            return OrientationData;
        }
        public static List<DropDownData> GetVisibilityData()
        {
            List<DropDownData> VisibilityData = new List<DropDownData>();
            VisibilityData.Add(new DropDownData("Visible", "1"));
            VisibilityData.Add(new DropDownData("Hidden", "2"));
            VisibilityData.Add(new DropDownData("Hover", "4"));
            VisibilityData.Add(new DropDownData("Connect", "8"));
            return VisibilityData;
        }

        public static List<DropDownData> GetShapeData()
        {
            List<DropDownData> ShapeData = new List<DropDownData>();
            ShapeData.Add(new DropDownData("Circle", "circle"));
            ShapeData.Add(new DropDownData("Square", "square"));
            ShapeData.Add(new DropDownData("X", "x"));
            ShapeData.Add(new DropDownData("Path", "path"));
            return ShapeData;
        }
        public static List<DropDownData> GetsetTool()
        {
            List<DropDownData> SetToolData = new List<DropDownData>();
            SetToolData.Add(new DropDownData("None", "none"));
            SetToolData.Add(new DropDownData("Drag", "drag"));
            SetToolData.Add(new DropDownData("Draw", "draw"));
            return SetToolData;
        }

        public static List<DropDownData> GetLabelFamily()
        {
            List<DropDownData> LabelFamily = new List<DropDownData>();
            LabelFamily.Add(new DropDownData("Arial", "Arial"));
            LabelFamily.Add(new DropDownData("Aharoni", "Aharoni"));
            LabelFamily.Add(new DropDownData("Bell MT", "Bell MT"));
            LabelFamily.Add(new DropDownData("Fantasy", "Fantasy"));
            LabelFamily.Add(new DropDownData("Times New Roman", "Times New Roman"));
            LabelFamily.Add(new DropDownData("Segoe UI", "Segoe UI"));
            LabelFamily.Add(new DropDownData("Verdona", "Verdona"));
            return LabelFamily;
        }

        public static List<DropDownData> GetHorizontalData()
        {
            List<DropDownData> HorizontalData = new List<DropDownData>();
            HorizontalData.Add(new DropDownData("Left", "left"));
            HorizontalData.Add(new DropDownData("Right", "right"));
            HorizontalData.Add(new DropDownData("Center", "center"));
            return HorizontalData;
        }

        public static List<DropDownData> GetVerticalData()
        {
            List<DropDownData> VerticalData = new List<DropDownData>();
            VerticalData.Add(new DropDownData("Top", "top"));
            VerticalData.Add(new DropDownData("Center", "center"));
            VerticalData.Add(new DropDownData("Bottom", "bottom"));
            return VerticalData;
        }

        public static List<DropDownData> GetDecoration()
        {
            List<DropDownData> Decoration = new List<DropDownData>();
            Decoration.Add(new DropDownData("Underline", "underline"));
            Decoration.Add(new DropDownData("Overline", "overline"));
            Decoration.Add(new DropDownData("Line-Through", "line-through"));
            Decoration.Add(new DropDownData("None", "none"));
            return Decoration;
        }

        public static List<DropDownData> GetWrapping()
        {
            List<DropDownData> Wrapping = new List<DropDownData>();
            Wrapping.Add(new DropDownData("NoWrap", "nowrap"));
            Wrapping.Add(new DropDownData("Wrap", "wrap"));
            Wrapping.Add(new DropDownData("WrapWithOverflow", "wrapwithoverflow"));
            return Wrapping;
        }
    }
}