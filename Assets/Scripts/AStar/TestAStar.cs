using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class TestAStar : MonoBehaviour
{
    public Node start;
    public Node end;
    public List<Node> path = new List<Node>();

    public bool cnaWalk = true;
    public int i = 0;

    void Start()
    {
        FindShortestPath();
    }

    void Update()
    {
        if (cnaWalk && i <= path.Count - 1)
        {
            StartCoroutine(Walking(i));
            i++;
        }
    }

    private void FindShortestPath()
    {
        path = AStarManager.instance.GeneratePath(start, end);
    }

    IEnumerator Walking(int i)
    {
        transform.position = path[i].transform.position;
        cnaWalk = false;
        yield return new WaitForSeconds(1f);
        cnaWalk = true;
    }
}
