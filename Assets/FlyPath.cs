using UnityEngine;
using System;
public class FlyPath : MonoBehaviour
{
...
private void OnDrawGizmos()
    {
        if (waypoints == null) return;

        Gizmos.color = Color.green;
        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Gizmos.DrawLine(waypoints[i].transform.position, waypoints[i +
            1].transform.position);
        }
    }
}