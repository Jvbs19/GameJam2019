using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    int[] pontos = new int[] { 0, 0, 0, 0, 0 };
    [SerializeField]
    string Estilo, Colecao, Material, Base, Cor;
    public int PontuacaoFinal;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void CalculaPontos()
    {
        GameObject[] Moveis = GameObject.FindGameObjectsWithTag("Building");
        for (int i = 0; i < Moveis.Length; i++)
        {
            FichaMovel MovelAtual = Moveis[i].GetComponent<Movel>().minhaFicha;
            if (MovelAtual.meuEstilo.ToString() == Estilo)
            {
                print(MovelAtual.meuEstilo.ToString());
                PontuacaoFinal += pontos[0] * MovelAtual.multiplicador[0];
            }
            if (MovelAtual.minhaColecao.ToString() == Colecao)
            {
                print(MovelAtual.minhaColecao.ToString());
                PontuacaoFinal += pontos[1] * MovelAtual.multiplicador[1];
            }
            if (MovelAtual.materialPrincipal.ToString() == Material)
            {
                print(MovelAtual.materialPrincipal.ToString());
                PontuacaoFinal += pontos[2] * MovelAtual.multiplicador[2];
            }
            if (MovelAtual.movelBase.ToString() == Base)
            {
                print(MovelAtual.movelBase.ToString());
                PontuacaoFinal += pontos[3] * MovelAtual.multiplicador[3];
            }
            if (MovelAtual.corPrincipal.ToString() == Cor)
            {
                print(MovelAtual.corPrincipal.ToString());
                PontuacaoFinal += pontos[4] * MovelAtual.multiplicador[4];
            }
        }
        print(PontuacaoFinal);
        PontuacaoFinal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
