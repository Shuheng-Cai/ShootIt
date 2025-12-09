using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using UnityEngine;

public class AStarManager : MonoBehaviour
{
    public static AStarManager instance;

    void Awake()
    {
        instance = this;
    }

    public List<Node> GeneratePath(Node start, Node end)
    {
        List<Node> openSet = new List<Node>();

        foreach(var n in FindObjectsByType<Node>(FindObjectsSortMode.None))
        {
            n.gScore = float.MaxValue;
        }

        start.gScore = 0;
        start.hScore = Vector2.Distance(start.transform.position, end.transform.position);
        openSet.Add(start);
        int FLowest = 0;
    
        HashSet<Node> closedSet = new HashSet<Node>();

        while(openSet.Count != 0)
        {
            FLowest = 0;
            for(int i = 0; i < openSet.Count; i++)
            {
                if(openSet[i].FScore() < openSet[FLowest].FScore())
                {
                    FLowest = i;
                }
            }
            Node currentNode = openSet[FLowest];
            openSet.Remove(currentNode);
            closedSet.Add(currentNode);

            foreach(Node n in currentNode.connections)
            {
                if (closedSet.Contains(n)) continue;

                if(n.gScore  > currentNode.gScore + n.penalty)
                {
                    n.cameFrom = currentNode;
                    n.gScore = currentNode.gScore + n.penalty;
                    if (!openSet.Contains(n))
                    {
                        n.cameFrom = currentNode;
                        n.gScore = currentNode.gScore + n.penalty;
                        n.hScore = Vector2.Distance(n.transform.position, end.transform.position);
                        openSet.Add(n);
                    }
                }
            }
            
            if(currentNode == end)
            {
                List<Node> path = new List<Node>();
                path.Add(end);

                while(path[path.Count - 1].cameFrom != null)
                {
                    path.Add(path[path.Count - 1].cameFrom);
                }

                path.Reverse();
                return path;
            }
        }

        return null;
    }
}
