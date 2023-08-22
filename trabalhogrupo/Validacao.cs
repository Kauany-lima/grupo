using System;
using System.Windows.Forms;

public class CPF
{
    //metodo para validar a quantidade de digito
    public bool Validadigito(string cpf,string text)
    {
        cpf = cpf.Replace(".", "");
        cpf =  cpf.Replace("-", "");
        cpf = cpf.Replace(",", "");

        if (cpf.Length != 11 && text.Length < 1)
        {
            return false;
            
        }
        else
        {
            return true;
        }
        
    }
}