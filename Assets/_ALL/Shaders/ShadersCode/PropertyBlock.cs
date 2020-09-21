using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyBlock : MonoBehaviour
{

    //Area de cores
    public Color Verde, Vermelho, Transparente;

    public bool SetarCorVerde;
    public bool SetarCorVermelha;
    public bool SetarCorTransparente;

    public bool OutlineVerde;
    public bool OutlineVermelha;
    public bool OutlinePreta;

    public string Brilho = "_MyColor";
    public string OutLine = "_OutlineColor";
   

    private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;
    
    void Awake()
    {
        _propBlock = new MaterialPropertyBlock();
        _renderer = GetComponent<Renderer>();
    }

    void Start()
    {
        SetarCorTransparente = TrocarCor(Brilho, Transparente, SetarCorTransparente);
        OutlinePreta = TrocarCor(OutLine, Transparente, OutlinePreta);
    }

    void Update()
    {
        if (SetarCorVerde == true)
        {
            SetarCorVerde= TrocarCor(Brilho, Verde, SetarCorVerde);
          
        }

        else  if (SetarCorVermelha == true)
        {
            SetarCorVermelha= TrocarCor(Brilho, Vermelho, SetarCorVermelha);
           
        }

        else if  (SetarCorTransparente == true)
        {
            SetarCorTransparente= TrocarCor(Brilho, Transparente, SetarCorTransparente);
            
        }

         if (OutlineVerde == true)
        {
            OutlineVerde= TrocarCor(OutLine, Verde, OutlineVerde);
           
        }
        else if (OutlineVermelha == true)
        {
            OutlineVermelha= TrocarCor(OutLine, Vermelho, OutlineVermelha);
           
        }
        else if(OutlinePreta == true)
        {
            OutlinePreta= TrocarCor(OutLine, Transparente, OutlinePreta);
            
        }
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1)  )
        {
            TrocarCor(Brilho, Random.ColorHSV(),SetarCorVerde);
            TrocarCor(OutLine, Random.ColorHSV(), SetarCorVerde);

        }


    }

    public bool TrocarCor(string propriedade,Color cor, bool Invocador)
    {
        _renderer.GetPropertyBlock(_propBlock);

        _propBlock.SetColor(propriedade, cor);

        _renderer.SetPropertyBlock(_propBlock);

        return Invocador = false;

    }
}
