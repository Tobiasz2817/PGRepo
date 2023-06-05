using System.Collections.Generic;
using UnityEngine;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;
using Unity.Mathematics;

public class ObjectsGenerator : MonoBehaviour
{
        [SerializeField] private CubeController prefab;
        [SerializeField] private int countSpawnObjects = 1000;
        
        private List<CubeController> _spawnedCubes = new List<CubeController>();
        
        private NativeArray<float3> _cubesPosition;
        private NativeArray<ClosestAndFarthest> closestAndFarthests;
        private FindClosestJob _findClosestJob;
        private JobHandle _handler;
        

        private void Awake() => Spawn();
        
        private void Update()
        {
            UpdatePositionDots();
        }

        private void LateUpdate()
        {
            _handler.Complete();

            var spawnedDotsCubeCount = _spawnedCubes.Count;
            var result = _findClosestJob.result;

            for (int i = 0; i < spawnedDotsCubeCount; i++)
            {
                _spawnedCubes[i].Closest = new[] 
                {
                    _spawnedCubes[result[i].first].transform.position,
                    _spawnedCubes[result[i].second].transform.position,
                    _spawnedCubes[result[i].third].transform.position,
                };
                _spawnedCubes[i].Farthest = _spawnedCubes[result[i].farthest].transform.position;
            }
        }
        
        private void Spawn()
        {
            for(int i = 0; i < countSpawnObjects; i++)
                _spawnedCubes.Add(Instantiate(prefab, UnityEngine.Random.insideUnitSphere * 100f, Quaternion.identity, transform));
        }

        private void UpdatePositionDots()
        {
            var spawnedDotsCubesCount = _spawnedCubes.Count;

            if (_cubesPosition.IsCreated)
                _cubesPosition.Dispose();

            if (closestAndFarthests.IsCreated)
                closestAndFarthests.Dispose();

            _cubesPosition = new NativeArray<float3>(spawnedDotsCubesCount, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);
            closestAndFarthests = new NativeArray<ClosestAndFarthest>(spawnedDotsCubesCount, Allocator.TempJob, NativeArrayOptions.UninitializedMemory);

            for(int i = 0; i < spawnedDotsCubesCount; i++)
                _cubesPosition[i] = _spawnedCubes[i].transform.position;

            _findClosestJob = new FindClosestJob
            {
                length = spawnedDotsCubesCount,
                cubesPosition = _cubesPosition,
                result = closestAndFarthests
            };

            _handler = _findClosestJob.Schedule();
        }

        [BurstCompile]
        private struct FindClosestJob : IJob
        {
            public int length;
            [ReadOnly] public NativeArray<float3> cubesPosition;
            [WriteOnly] public NativeArray<ClosestAndFarthest> result;

            public void Execute()
            {
                for (int i = 0; i < length; i++)
                    result[i] = GetClosestAndFarthest(i, cubesPosition[i]);
                
            }

            private ClosestAndFarthest GetClosestAndFarthest(int currentIndex, float3 currentPosition)
            {
                var closestDistances = new NativeArray<float>(3, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
                var closestIndices = new NativeArray<int>(3, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
                
                var farthestDistance = float.MinValue;
                var farthestIndex = -1;

                for (int i = 0; i < 3; i++)
                {
                    closestDistances[i] = float.MaxValue;
                    closestIndices[i] = -1;
                }
                
                for (int i = 0; i < length; i++)
                {
                    if (i == currentIndex)
                        continue;
                    
                    var distance = math.distance(currentPosition, cubesPosition[i]);

                    // Check if the current distance is smaller than the stored distances
                    for (int j = 0; j < 3; j++)
                    {
                        if (distance < closestDistances[j])
                        {
                            // Shift the other closest distances and indices
                            for (int k = 3 - 1; k > j; k--)
                            {
                                closestDistances[k] = closestDistances[k - 1];
                                closestIndices[k] = closestIndices[k - 1];
                            }

                            // Store the new closest distance and index
                            closestDistances[j] = distance;
                            closestIndices[j] = i;
                            break;
                        }
                    }
                    // Check if the current distance is larger than the farthest distance
                    if (distance > farthestDistance)
                    {
                        farthestDistance = distance;
                        farthestIndex = i;
                    }
                }

                return new ClosestAndFarthest()
                {
                    first = closestIndices[0],
                    second = closestIndices[1],
                    third = closestIndices[2],
                    farthest = farthestIndex
                };
            }
        }
}
