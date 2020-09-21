using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{

    public int xLength;//how many cubes in the x direction
    public int zLength;//how many in the z 
    public GameObject prefab;//ground cube prefab
    public BuildSystem buildSystem;//ref to the build system


    private void Start()
    {
        for (int x = 0; x < xLength; x++)
        {
            for (int z = 0; z < zLength; z++)
            {
                //go.transform.SetParent(transform);//so the hierarchy looks neater
                Vector3 pos = new Vector3(x + 0.5f, 0, z + 0.5f);//offset the x and z by 0.5 so the left and right sides of ground cube are at whole number intervals
                GameObject go = Instantiate(prefab, transform, false);
                go.transform.localPosition = pos;
                go.GetComponent<GroundCube>().SetBuildSystem(buildSystem);//pass a buildSystem referance to the ground cube prefab
                
            }
        }
    }


}
