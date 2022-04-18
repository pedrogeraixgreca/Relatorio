using DevExpress.DataAccess.ObjectBinding;
using System.Collections.Generic;
using System.ComponentModel;
public class ListaDados
{
    public List<Cliente> Lista { get; set; }
}

public class Cliente
    {
        public string Nome { get; set; }
        public string Razao { get; set; }
        public string CNPJ { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Emitido { get; set; }
        public double? Total { get; set; }
        public List<DemonstrativoItem> Demonstrativo { get; set; }  


    }

public class DemonstrativoItem
{
    public double Quantidade {get; set;}
    public string Detalhe { get; set; }
    public double Preco { get; set; }
}

