using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Novo Movel", menuName = "Movel")]
public class FichaMovel : ScriptableObject
{
    public enum Estilo { Retro, Rustico, Classico, Tradicional, Moderno, Industrial };
    public enum Colecao { ColecaoTeste }
    public enum Material { Madeira, Metal, Pano, Plastico, Couro, Vidro }
    public enum Base { Cama, Cadeira, Eletrodomestico, Eletronico, Iluminacao, Sofa, Estante, Armario }
    public enum Cor { Vermelho, Laranja, Azul, Verde, Branco, Preto, Cinza, Amarelo }

    public string nome;
    public Estilo meuEstilo;
    public Colecao minhaColecao;
    public Material materialPrincipal;
    public Base movelBase;
    public Cor corPrincipal;
    public int preco;
    public int espacoNoGrid;

    public int[] multiplicador = new int[] { 1, 1, 1, 1, 1 };

    public string GetNome()
    {
        return nome;
    }

    public string GetEstilo()
    {
        return System.Enum.GetName(typeof(Estilo), meuEstilo);
    }

    public string GetColecao()
    {
        return System.Enum.GetName(typeof(Colecao), minhaColecao);
    }

    public string GetMaterial()
    {
        return System.Enum.GetName(typeof(Material), materialPrincipal);
    }

    public string GetBase()
    {
        return System.Enum.GetName(typeof(Base), movelBase);
    }

    public string GetCor()
    {
        return System.Enum.GetName(typeof(Cor), corPrincipal);
    }

    public int GetPreco()
    {
        return preco;
    }

    public int GetEspacoOcupado()
    {
        return espacoNoGrid;
    }

    public int GetMultiplicador(int qual)
    {
        return multiplicador[qual];
    }

}
