using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
   public GameObject Preview;
    public bool OnGrid = false;
    bool StopCast;
    float Tempo = 0.5f;

    private Collider[] ObjetosArea()
    {
        var hitColliders = Physics.OverlapSphere(transform.position + transform.up * -2, 3);

        return hitColliders;
    }
    void OnGridObject()
    {
        Collider[] objetos = ObjetosArea();
        if (objetos.Length > 0)
        {
            for (int i = 0; i < objetos.Length; i++)
            {
                if (objetos[i].gameObject.tag == "GroundCube")
                {
                    OnGrid = true;
                    StopCast = true;
                }
            }
        }
    }

    IEnumerator DestroyOutGrid()
    {       
        yield return new WaitForSeconds(Tempo);
        Destroy(this.gameObject);
    }

    void Update()
    {
        if (StopCast == false)
        {
            OnGridObject();
        }
        if (OnGrid == false)
        {
            StartCoroutine(DestroyOutGrid());
        }
    }
}

