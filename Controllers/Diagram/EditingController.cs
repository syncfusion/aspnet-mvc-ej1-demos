using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using MVCSampleBrowser.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /Diagram/
        DiagramProperties model = new DiagramProperties();
        public ActionResult Editing()
        {
            model.Height = "550px";
            model.Width = "700px";
            model.DataSourceSettings = new DataSourceSettings()
            {
                DataSource = DiagramContext.HierarchicalData.ToList(),
                Id = "Name",
                CustomFields = new List<string>() 
                {
                    "Description",
                    "Color"
                },
                CrudAction = new CRUDAction()
                {
                    Create = "/Diagram/InsertShape",
                    Update = "/Diagram/UpdateShape",
                    Destroy = "/Diagram/DeleteShape"
                },
                ConnectionDataSource = new ConnectionDataSourceSettings()
                {
                    DataSource = DiagramContext.HierarchicalDetails.ToList(),
                    Id = "Name",
                    SourceNode = "SourceNode",
                    TargetNode = "TargetNode",
                    CrudAction = new CRUDAction()
                    {
                        Create = "/Diagram/InsertConnector",
                        Update = "/Diagram/UpdateConnector",
                        Destroy = "/Diagram/DeleteConnector"
                    }
                }
            };
            model.Layout = new Layout()
            {
                Type = LayoutTypes.HierarchicalTree,
                HorizontalSpacing = 40,
                VerticalSpacing = 40,
                Margin = new Margin()
                {
                    Top = 50
                }
            };
            model.DefaultSettings.Node = new Node()
            {
                Width = 100,
                Height = 50,
                Constraints = (NodeConstraints.Default &~ NodeConstraints.Interaction) | (NodeConstraints.Select| NodeConstraints.PointerEvents),
                BorderColor = "black",
                BorderWidth = 1,
                Labels = new Collection() { new Label() { FontColor = "white", FontSize = 12 } }
            };
            model.DefaultSettings.Connector = new Connector()
            {
                LineColor = "#000000",
                Constraints = ConnectorConstraints.Default & ~ConnectorConstraints.Drag,
                Segments = new Collection() { new Segment() { Type = Segments.Orthogonal } }
            };
            model.NodeTemplate = "nodeTemplate";
            model.ConnectorSourceChange = "connectionChange";
            model.ConnectorTargetChange = "connectionChange";
            model.SelectionChange = "selectionChange";
            ViewData["DiagramModel"] = model;
            return View();
        }

        [HttpPost]
        public void InsertShape(List<HierarchicalData> data)
        {
            foreach (HierarchicalData hdata in data)
            {
                DiagramContext.HierarchicalData.InsertOnSubmit(hdata);
                DiagramContext.SubmitChanges();
            }
        }

        [HttpPost]
        public void UpdateShape(List<HierarchicalData> data)
        {
            foreach (HierarchicalData hdata in data)
            {
                HierarchicalData originalData = DiagramContext.HierarchicalData.Single(h => h.Name == hdata.Name);
                originalData.Description = hdata.Description;
                originalData.Color = hdata.Color;
                DiagramContext.SubmitChanges();
            }
            
        }

        [HttpPost]
        public void DeleteShape(List<HierarchicalData> data)
        {
            foreach (HierarchicalData hdata in data)
            {
                HierarchicalData originalData = DiagramContext.HierarchicalData.Single(h => h.Name == hdata.Name);
                DiagramContext.HierarchicalData.DeleteOnSubmit(originalData);
                DiagramContext.SubmitChanges();
            }
        }

        [HttpPost]
        public void InsertConnector(List<HierarchicalDetail> data)
        {
            foreach (HierarchicalDetail hdata in data)
            {
                DiagramContext.HierarchicalDetails.InsertOnSubmit(hdata);
                DiagramContext.SubmitChanges();
            }
        }

        [HttpPost]
        public void UpdateConnector(List<HierarchicalDetail> data)
        {
            foreach (HierarchicalDetail hdata in data)
            {
                HierarchicalDetail originalData = DiagramContext.HierarchicalDetails.Single(h => h.Name == hdata.Name);
                originalData.SourceNode = hdata.SourceNode;
                originalData.TargetNode = hdata.TargetNode;
                DiagramContext.SubmitChanges();
            }
        }

        [HttpPost]
        public void DeleteConnector(List<HierarchicalDetail> data)
        {
            foreach (HierarchicalDetail hdata in data)
            {
                HierarchicalDetail originalData = DiagramContext.HierarchicalDetails.Single(h => h.Name == hdata.Name);
                DiagramContext.HierarchicalDetails.DeleteOnSubmit(originalData);
                DiagramContext.SubmitChanges();
            }
        }

        private DiagramDataDataContext _diagramContext;
        public DiagramDataDataContext DiagramContext
        {
            get
            {
                if (_diagramContext == null)
                    _diagramContext = new DiagramDataDataContext();
                return _diagramContext;
            }
        }

    }
}
