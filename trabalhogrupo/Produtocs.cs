using System.Windows.Forms;
using trabalhogrupo;

public class Vendaproduto
{
    // classe para cadastrar o produto
    public string Id { get; set; }
    public string Descricao { get; set; }
    public string Marca { get; set; }
    public string Tamanho { get; set; }
    public double Quantidade { get; set; }
    public double Valor { get; set; }
    public double Desconto { get; set; }
  
    public double Valorfinal { get; set; }
    public string Data { get; set; }
    public Vendaproduto()
    {

    }
   
    
}