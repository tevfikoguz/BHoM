﻿using System.Collections.Generic;
using BH.oM.Structure.Properties.Surface;

namespace BH.oM.Structure.Elements
{
    public class FEMesh : Base.BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<Node> Nodes { get; set; } = new List<Node>();

        public List<FEMeshFace> MeshFaces { get; set; } = new List<FEMeshFace>();

        public ISurfaceProperty Property { get; set; } = new ConstantThickness();

        /***************************************************/
    }
}