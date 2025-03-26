using System.Globalization;

namespace GestorDeProdutos;

public class Produto
{
    private string _nome;
    private double _preco;
    private int _quantidade;
    
    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if (!String.IsNullOrWhiteSpace(value))
                _nome = value;
        }
    }

    public double Preco
    {
        get { return _preco; }
        set { _preco = value; }
    }

    public int Quantidade
    {
        get { return _quantidade; }
        set { _quantidade = value; }
    }
    public double ValorTotalEstoque()
    {
        return _preco * _quantidade;
    }

    public void AdicionarProdutos(int produto)
    {
         _quantidade += produto;
    }

    public void RemoverProdutos(int produto)
    {
        _quantidade -= produto;
    }
    
    public override string ToString()
    {
        return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade + " unidades, Valor Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}