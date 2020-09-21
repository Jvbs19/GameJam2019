using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{
    
    public GameObject ScrollRange;
    public int NumObjetos;
    new Vector3 tamanho;

   

   
    
    // Start is called before the first frame update
    void Start()
    {
      

    }
    // Update is called once per frame
    void Update()
    {
        //**********Setando Tamanho da barra de rolagem
        tamanho.Set(NumObjetos * (0.066f), 1, 1);
        ScrollRange.GetComponent<RectTransform>().localScale =(tamanho);
        //*************
        
    }


    



}
