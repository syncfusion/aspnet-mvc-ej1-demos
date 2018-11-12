using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /UML/

        public ActionResult UMLDiagram()
        {
            DiagramProperties model = new DiagramProperties();
            model.Width = "100%";
            model.Height = "700px";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Tool = Tool.SingleSelect | Tool.ZoomPan;
            model.DefaultSettings.Node = new Node()
            {
                Constraints = NodeConstraints.Default,
                FillColor = "#26A0DA",
                BorderColor = "white",
                BorderWidth = 2,
                Labels = new Collection() {
                                new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label() { FontColor = "white", FontFamily = "Segoe UI" },
                                new Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label() { FontColor = "white", FontFamily = "Segoe UI" }
                             }
            };
            model.DefaultSettings.Connector = new Connector()
            {
                Constraints = ConnectorConstraints.None,
                TargetDecorator = new Decorator() { FillColor = "#666666", Height = 10, Width = 10 }
            };
            model.NodeTemplate = "nodeTemplate";
            model.DataSourceSettings.DataSource = GetUMLData();
            this.GetConnectors(model.Connectors);
            ViewData["diagramModel"] = model;
            return View();
        }
        public void GetConnectors(Collection connectors)
        {
            connectors.Add(GetConnector("Connector1", "Patient", "Person", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector2", "Person", "Hospital", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector3", "Department", "Hospital", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector4", "OperationStaff", "Patient", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector5", "Doctor", "OperationStaff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector6", "Nurse", "OperationStaff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector7", "Surgeon", "Doctor", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector8", "FrontDeskStaff", "AdministrativeStaff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector9", "Technician", "TechnicalStaff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector10", "Technologist", "TechnicalStaff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector11", "SurgicalTechnologist", "Technologist", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector12", "Staff", "Department", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector13", "Staff", "Person", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector14", "OperationStaff", "Staff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector15", "AdministrativeStaff", "Staff", UMLRelationships.Association));
            connectors.Add(GetConnector("Connector16", "TechnicalStaff", "Staff", UMLRelationships.Association));
        }
        public Connector GetConnector(string name, string sourceNode, string targetNode, UMLRelationships relationship)
        {
            Connector connector = new Connector();
            connector.Name = name;
            connector.TargetNode = targetNode;
            connector.SourceNode = sourceNode;
            connector.Segments = new Collection() { new Segment() { Type = Segments.Straight } };
            connector.Shape = new UMLConnectorShape()
            {
                Relationship = relationship
            };
            
            connector.Constraints = ConnectorConstraints.None;
            return connector;
        }
        public object GetUMLData()
        {
            string allText = System.IO.File.ReadAllText(Server.MapPath("~/App_Data/UML.json"));
            Dictionary<string, object> requestArgs = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(allText);
            return requestArgs["data"];
        }
    }
}
