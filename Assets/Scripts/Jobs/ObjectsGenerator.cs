using UnityEngine;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;
using Random = Unity.Mathematics.Random;

public class ObjectsGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public int minCubeCount = 1000;
    public int maxCubeCount = 10000;
    public float sphereRadius = 10f;

    public NativeArray<Vector3> cubePositions;

    private void Start()
    {
        GenerateCubes();
    }

    private void OnDestroy()
    {
        cubePositions.Dispose();
    }

    private void GenerateCubes()
    {
        int cubeCount = UnityEngine.Random.Range(minCubeCount, maxCubeCount);

        cubePositions = new NativeArray<Vector3>(cubeCount, Allocator.Persistent);

        Random random = new Random((uint)System.Environment.TickCount);

        CubeGeneratorJob generatorJob = new CubeGeneratorJob()
        {
            cubePositions = this.cubePositions,
            random = random,
            sphereRadius = sphereRadius
        };

        JobHandle jobHandle = generatorJob.Schedule(cubeCount, 64);
        jobHandle.Complete();

        for (int i = 0; i < cubeCount; i++)
        {
            GameObject cube = Instantiate(cubePrefab, cubePositions[i], Quaternion.identity);
            cube.GetComponent<CubeController>().InitCubeController(this);
        }
    }

    [BurstCompile]
    private struct CubeGeneratorJob : IJobParallelFor
    {
        public NativeArray<Vector3> cubePositions;

        public Random random;
        public float sphereRadius;

        public void Execute(int index)
        {
            Vector3 position = random.NextFloat3(-sphereRadius, sphereRadius);
            cubePositions[index] = position;
        }
    }
}
