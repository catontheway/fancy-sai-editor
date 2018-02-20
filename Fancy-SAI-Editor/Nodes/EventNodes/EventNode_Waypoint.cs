﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeAI.Nodes.EventNodes
{
    /// <summary>
    /// SMART_EVENT_WAYPOINT_REACHED
    /// SMART_EVENT_WAYPOINT_START
    /// </summary>
    [Node(MenuName = "Waypoint reached", Type = NodeType.EVENT_WAYPOINT_REACHED, AllowedTypes = new NodeType[] { NodeType.GENERAL_NPC, NodeType.ACTION })]
    public class WaypointReached : EventNode
    {
        /// <summary>
        /// Standard constructor.
        /// Initializes type, node name, tooltips and adds the connectors.
        /// </summary>
        public WaypointReached()
        {
            Type = NodeType.EVENT_WAYPOINT_REACHED;
            
            //Update text
            NodeName.Content = "Waypoint reached";

            AddParam(ParamId.PARAM_1, "Point Id:");
            AddParam(ParamId.PARAM_2, "Path Id:"); // TODO: Replace with general node
        }

        /// <summary>
        /// Clones the class instance.
        /// </summary>
        /// <returns>Returns clone of this class.</returns>
        public override Node Clone()
        {
            return new WaypointReached();
        }
    }
}
