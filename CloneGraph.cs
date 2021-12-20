using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class CloneGraph
    {
        public Node Clone(Node node)
        {
            if (node == null) return node;
            //iterate over the original and append nodes to the new
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            Dictionary<Node, Node> map = new Dictionary<Node, Node>();
            HashSet<Node> contains = new HashSet<Node>();

            while (queue.Count > 0)
            {
                var original = queue.Dequeue();
                var clone = new Node(original.val);

                if (!map.ContainsKey(original)) map.Add(original, clone);
                contains.Add(original);
                foreach (var neighbor in original.neighbors)
                {
                    if (!contains.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                    }
                }
            }
            //we have created a clone for each noe
            //foreach clone, associate it with it's neighbours
            foreach (var item in map)
            {
                var currentClone = item.Value;
                //get neighbours            
                var originalNeighbours = item.Key.neighbors;
                foreach (var oN in originalNeighbours)
                {
                    currentClone.neighbors.Add(map[oN]);
                }
            }


            return map.FirstOrDefault().Value;
        }
    }

    //Map each node copy in the original to it's original
    //original will have a reference to it's neightbours that we can use to check later

    //
}
