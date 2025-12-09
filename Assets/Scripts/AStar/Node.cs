using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    /// <summary>
    /// Record the node it come from and connect
    /// </summary>
    public Node cameFrom;
    public List<Node> connections;

    /// <summary>
    /// The penalty for each step in this node. It can be high or low.
    /// </summary>
    public float penalty;

    /// <summary>
    /// gScore to the start. hScore to the destination.
    /// </summary>
    public float gScore;
    public float hScore;

    public float FScore()
    {
        return gScore + hScore;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;

        if(connections.Count > 0)
        {
            foreach(var i in connections)
            {
                Gizmos.DrawLine(transform.position, i.transform.position);
            }
        }
    }
}
