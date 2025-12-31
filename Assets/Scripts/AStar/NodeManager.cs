using System.Collections.Generic;
using UnityEngine;

public class NodeManager : MonoBehaviour
{
    public static NodeManager instance;
    public List<Node> allNodes = new List<Node>();

    void Awake()
    {
        instance = this;
    }
}
