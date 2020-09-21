using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconesObjetos : MonoBehaviour
{
  
    public TMPro.TMP_Text Valor, Espaços;
    public TMPro.TMP_Text Nome, Material, Estilo;



    public FichaMovel Movel;

    public GameObject Objeto;


    // Start is called before the first frame update
    void Start()
    {
        Nome.text = Movel.nome;
        Material.text = Movel.materialPrincipal.ToString();
        Estilo.text = Movel.meuEstilo.ToString();
        Valor.text = Movel.preco.ToString();
        Espaços.text = Movel.espacoNoGrid.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
