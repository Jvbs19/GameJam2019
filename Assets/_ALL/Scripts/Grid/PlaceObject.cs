using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlaceObject : MonoBehaviour
{
    public int sizeGridX;
    public int sizeGridZ;
    public Transform baseGrid;
    public GameObject place;

    private Vector3 sizePlace = Vector3.zero;
    private Vector3 gridPosition = Vector3.zero;
    private Vector3 startGridPosition = Vector3.zero;

    void Start()
    {
        FillGrid();
    }

    private void Values()
    {
        sizePlace.x = baseGrid.transform.localScale.x / sizeGridX;
        sizePlace.z = baseGrid.transform.localScale.z / sizeGridZ;
        sizePlace.y = 0.25f;

        gridPosition.x = (baseGrid.transform.localScale.x / 2) - (sizePlace.x / 2);
        gridPosition.z = (baseGrid.transform.localScale.z / 2) - (sizePlace.z / 2);
        gridPosition.y = 0.5f;

        startGridPosition = gridPosition;
    }

    public void FillGrid()
    {
        Values();

        for (int x = 0; x < sizeGridX; x++)
        {
            for (int z = 0; z < sizeGridZ; z++)
            {
                GameObject newPlace = Instantiate(place) as GameObject;
                newPlace.transform.localScale = sizePlace;
                newPlace.transform.position = gridPosition;

                if (z >= (sizeGridZ - 1))
                    gridPosition.z = startGridPosition.z;
                else
                    gridPosition.z -= sizePlace.z;

                newPlace.transform.parent = transform;
                newPlace.SetActive(true);
            }
            gridPosition.x -= sizePlace.x;
        }
    }

    public void Destroy()
    {
        //PlaceBehaviour[] places = GetComponentsInChildren<PlaceBehaviour>();

     /*   for (int i = 0; i < places.Length; i++)
        {
            Destroy(places[i].gameObject);
        }*/
    }
}
