using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public int index;

    private bool drawGizmos = false;

    /*public void DrawLines()
    {
        drawGizmos = true;
    }

    private void OnDrawGizmosSelected()
    {
        if (!drawGizmos)
            return;

        DrawNeighborLines(3, Color.green);
        DrawNeighborLines(1, Color.red);

        drawGizmos = false;
    }

    private void DrawNeighborLines(int count, Color color)
    {
        ObjectsGenerator cubeManager = FindObjectOfType<ObjectsGenerator>();
        if (cubeManager == null)
            return;

        NativeArray<Vector3> neighborPositions = cubeManager.neighborPositions;
        NativeArray<int> neighborIndices = cubeManager.neighborIndices;
        
        int startIndex = index * 4;
        for (int i = 0; i < count; i++)
        {
            int neighborIndex = neighborIndices[startIndex + i];
            if (neighborIndex >= 0)
            {
                Gizmos.color = color;
                Gizmos.DrawLine(transform.position, neighborPositions[startIndex + i]);
            }
        }
    }*/
}


