using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperMap.Data;
using SuperMap.UI;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using SuperMap.Analyst.SpatialAnalyst;
using SuperMap.Mapping;
using SuperMap.Analyst.TerrainAnalyst;

namespace SelectHelper.Hydrology
{
    
    public class Hydrology
    {
        Workspace workspace;
        LayersControl layersControl;
        MapControl mapControl;
        public Hydrology(Workspace workspace,LayersControl layersControl, MapControl mapControl)
        {
            this.workspace = workspace;
            this.layersControl = layersControl;
            this.mapControl = mapControl;
        }
        public void FlowLength(DatasetGrid directionGrid, DatasetGrid weightGrid,  bool upStream, Datasource targetDatasource, string resultGirdName)
        {
            DatasetGrid res=HydrologyAnalyst.FlowLength(directionGrid, weightGrid, upStream, targetDatasource, resultGirdName);
            mapControl.Map.Layers.Add(res,true);
            mapControl.Map.ViewEntire();
            mapControl.Map.Refresh();
        }
    }
}
