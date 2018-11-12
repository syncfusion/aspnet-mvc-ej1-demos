using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Syncfusion.JavaScript.DataVisualization.DiagramEnums;
using Syncfusion.JavaScript.DataVisualization.Models;
using Syncfusion.JavaScript.DataVisualization.Models.Diagram;
using Syncfusion.JavaScript.DataVisualization.Models.Collections;
using Label = Syncfusion.JavaScript.DataVisualization.Models.Diagram.Label;

namespace MVCSampleBrowser.Controllers
{
    public partial class DiagramController : Controller
    {
        //
        // GET: /SymmetricalLayout/
        public ActionResult SymmetricalLayout()
        {
            DiagramProperties model = new DiagramProperties();
            model.Height = "550px";
            model.Width = "100%";
            model.PageSettings.ScrollLimit = ScrollLimit.Diagram;
            model.Layout.Type = LayoutTypes.SymmetricLayout;
            model.Layout.SpringLength = 80;
            model.Layout.MaxIteration = 500;
            model.Layout.SpringFactor = .8F;
            model.Layout.Margin.Left = 0;
            model.Layout.Margin.Top = 20;

            Collection Nodes = new Collection();
            Collection Connectors = new Collection();
            populateNodes(Nodes, Connectors);
            model.Nodes = Nodes;
            model.Connectors = Connectors;
            model.DefaultSettings.Node = new Node()
            {
                Constraints = NodeConstraints.Default & ~NodeConstraints.Drag,
            };

            model.DefaultSettings.Connector = new Connector()
            {
                Constraints = ConnectorConstraints.Default & ConnectorConstraints.Select,
            };
            model.EnableContextMenu = false;
            ViewData["diagramModel"] = model;
            return View();
        }

        private Connector ConnectNodes(BasicShape ParentNode, BasicShape ChildNode)
        {
            Connector connector = new Connector()
            {
                Name = ParentNode.Name + ChildNode.Name,
                SourceNode = ParentNode.Name,
                TargetNode = ChildNode.Name,
                LineColor = "black",
                TargetDecorator = new Decorator() { Shape = DecoratorShapes.None }
            };
            return connector;
        }

        private Collection populateNodes(Collection Nodes, Collection Connectors)
        {
            BasicShape ParentRect = GetRectangle("p");
            Nodes.Add(ParentRect);
            for (int i = 0; i < 2; i++)
            {
                BasicShape ChildRect = GetRectangle("c" + i);
                Nodes.Add(ChildRect);
                for (int j = 0; j < 2; j++)
                {
                    BasicShape ChildRect_j = GetRectangle("c" + i + j);
                    Nodes.Add(ChildRect_j);
                    for (int k = 0; k < 6; k++)
                    {
                        BasicShape ChildRect_k = GetRectangle("c" + i + j + k); ;
                        Nodes.Add(ChildRect_k);
                        Connectors.Add(ConnectNodes(ChildRect_j, ChildRect_k));

                    }
                    Connectors.Add(ConnectNodes(ChildRect, ChildRect_j));

                }
                Connectors.Add(ConnectNodes(ParentRect, ChildRect));
            }

            return Nodes;
        }

        private BasicShape GetRectangle(string name)
        {
            BasicShape node = new BasicShape() { Name = name, Height = 25, Width = 25, BorderColor = "#5e5e5e", BorderWidth = 1, FillColor = "#ff6329", Shape = BasicShapes.Ellipse };
            return node;
        }

    }
}