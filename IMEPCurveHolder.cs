using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Diagnostics;


namespace MEP_Supports_distributor
{
     interface IMEPCurveHolder
     {
         List<XYZ> SupportsLocation  { get; set; }
        void GetSupportLocation();
        void JustifySupport();
        void PlaceSupport();
         

     }
}
