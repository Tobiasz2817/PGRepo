using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private ObjectsGenerator _objectsGenerator;
    
    public void InitCubeController(ObjectsGenerator objectsGenerator_) {
        _objectsGenerator = objectsGenerator_;
    }
    
    private void CalculateNeighbors()
    {
        FindClosestNeighbors();
        FindFarthestNeighbor();
    }

    private void FindClosestNeighbors()
    {
        Vector3 cubePosition = transform.position;
        var cubes = new List<Vector3>(_objectsGenerator.cubePositions);

        cubes.Sort((cube1, cube2) =>
        {
            float distance1 = Vector3.Distance(cube1, cubePosition);
            float distance2 = Vector3.Distance(cube2, cubePosition);
            return distance1.CompareTo(distance2);
        });

        int neighborCount = Mathf.Min(cubes.Count - 1, 3);
        for (int i = 0; i < neighborCount; i++)
        {
            Vector3 neighborPosition = cubes[i + 1];
            DrawNeighborLine(transform.position, neighborPosition, Color.green);
        }
    }

    private void FindFarthestNeighbor()
    {
        Vector3 cubePosition = transform.position;
        var cubes = new List<Vector3>(_objectsGenerator.cubePositions);

        cubes.Sort((cube1, cube2) =>
        {
            float distance1 = Vector3.Distance(cube1, cubePosition);
            float distance2 = Vector3.Distance(cube2, cubePosition);
            return distance2.CompareTo(distance1);
        });

        Vector3 farthestNeighborPosition = cubes[0];
        DrawNeighborLine(transform.position, farthestNeighborPosition, Color.red);
    }

    private void DrawNeighborLine(Vector3 cubePosition, Vector3 neighborPosition, Color color)
    {
        Debug.DrawLine(cubePosition, neighborPosition, color);
    }

    private void OnDrawGizmosSelected()
    {
        CalculateNeighbors();
    }
}


