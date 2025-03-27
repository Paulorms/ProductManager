using System.Globalization;

namespace GestorDeProdutos;

public class Produto
{
    private string _nome;
    public double Preco { get; set; }
    public int Quantidade { get; set;}
    
    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
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
    
    public double ValorTotalEstoque()
    {
        return Preco * Quantidade;
    }

    public void AdicionarProdutos(int produto)
    {
         Quantidade += produto;
    }

    public void RemoverProdutos(int produto)
    {
        Quantidade -= produto;
    }
    
    public override string ToString()
    {
        return _nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Valor Total: R$ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}