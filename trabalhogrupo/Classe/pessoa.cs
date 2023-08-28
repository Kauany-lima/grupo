using System;
//classe para login da pessoa
public class Usuario
{
    
    public string Name { get; set; }
    public string CPF { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string RG { get; set; }
    public string Rua { get; set; }
    public string Bairro { get; set; }
    public string Numero { get; set; }
    public  Usuario() 
    {     
    }

    //Método validação para cpf e nome
    public bool Validadigito(string cpf, string text)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        cpf = cpf.Replace(",", "");

        if (cpf.Length != 11 || text.Length < 1)
        {
            return false;

        }
        else
        {
            return true;
        }

    }

}
