﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NodeAI.Nodes.ActionNodes
{
    [Node(MenuName = "Add Quest", Type = NodeType.ACTION_ADD_QUEST, AllowedTypes = new NodeType[] { NodeType.GENERAL_QUEST, NodeType.EVENT, NodeType.TARGET })]
    class AddQuest : ActionNode
    {
        public AddQuest()
        {
            Type = NodeType.ACTION_ADD_QUEST;

            //Update text
            NodeName.Content = "Add Quest";

            AddParam<GeneralNodes.Quest>(ParamId.PARAM_1, NodeType.GENERAL_QUEST, "Quest");
        }

        public override Node Clone()
        {
            return new AddQuest();
        }
    }
}
