using DevExpress.DataAccess.ObjectBinding;
using WinFormsApp1;

namespace WorkerService3
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
           

                var lista = new ListaDados();
                lista.Lista = new List<Cliente> {
                new Cliente {
                    Nome = "pedro",
                    Email = "teste@emaill.com",
                    Cidade = "londrina",
                    Endereço = "RuaRUA",
                    Bairro = "BairroBairro",
                    Razao = "solteiro",
                    CNPJ = "9999999",
                    Telefone = "9999999",
                    Emitido = DateTime.Now,
                    Vencimento = DateTime.Today.AddMonths(1),
                    Demonstrativo = new List<DemonstrativoItem>
                        {
                        new DemonstrativoItem{Quantidade = 10,Detalhe = "Mensalidades de Locação M2M Multioperadora",Preco = 5.4},
                        new DemonstrativoItem{Quantidade = 5,Detalhe = "Mensalidades de Locação M2M Vivo",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 2,Detalhe = "Despesas de Frete",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 1,Detalhe = "Mensalidades de Locação de Linhas Desativadas",Preco = 2.3},
                        }
                    },
                

                new Cliente
                {
                    Nome = "yara",
                    Email = "yara@emaill.com",
                    Cidade = "londrina",
                    Endereço = "RuaRUA",
                    Bairro = "BairroBairro",
                    Razao = "solteiro",
                    CNPJ = "9999999",
                    Telefone = "9999999",
                    Emitido = DateTime.Now,
                    Vencimento = DateTime.Today.AddMonths(1),
                    Demonstrativo = new List<DemonstrativoItem>
                        {
                        new DemonstrativoItem{Quantidade = 10,Detalhe = "Mensalidades de Locação M2M Multioperadora",Preco = 5.4},
                        new DemonstrativoItem{Quantidade = 50,Detalhe = "Mensalidades de Locação M2M Vivo",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 20,Detalhe = "Despesas de Frete",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 10,Detalhe = "Mensalidades de Locação de Linhas Desativadas",Preco = 2.3},
                        }
                },

                new Cliente
                {
                    Nome = "lucas",
                    Email = "lucas@emaill.com",
                    Cidade = "Maringa",
                    Endereço = "RuaNUA",
                    Bairro = "BairroBairro",
                    Razao = "solteiro",
                    CNPJ = "9999999",
                    Telefone = "9999999",
                    Emitido = DateTime.Now,
                    Vencimento = DateTime.Today.AddMonths(1),
                    Demonstrativo = new List<DemonstrativoItem>
                        {
                        new DemonstrativoItem{Quantidade = 20,Detalhe = "Mensalidades de Locação M2M Multioperadora",Preco = 5.4},
                        new DemonstrativoItem{Quantidade = 3,Detalhe = "Mensalidades de Locação M2M Vivo",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 5,Detalhe = "Despesas de Frete",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 3,Detalhe = "Mensalidades de Locação de Linhas Desativadas",Preco = 2.3},
                        }
                },

                new Cliente
                {
                    Nome = "felipe",
                    Email = "felipe@Gmaill.com",
                    Cidade = "londrina",
                    Endereço = "RuaLUA",
                    Bairro = "Bairrox",
                    Razao = "casado",
                    CNPJ = "9999999",
                    Telefone = "9999999",
                    Emitido = DateTime.Now,
                    Vencimento = DateTime.Today.AddMonths(1),
                    Demonstrativo = new List<DemonstrativoItem>
                        {
                        new DemonstrativoItem{Quantidade = 10,Detalhe = "Mensalidades de Locação M2M Multioperadora",Preco = 5.4},
                        new DemonstrativoItem{Quantidade = 5,Detalhe = "Mensalidades de Locação M2M Vivo",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 2,Detalhe = "Despesas de Frete",Preco = 2.3},
                        new DemonstrativoItem{Quantidade = 1,Detalhe = "Mensalidades de Locação de Linhas Desativadas",Preco = 2.3},
                        }
                }
            };
            foreach (var item in lista.Lista)
                {
                    var relatorio = new XtraReport4();
                    relatorio.DataSource = new ObjectDataSource
                    {
                        DataSource = item,
                    };
                    string pdfExportFile =
                        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                        @"\Downloads\Cliente " +
                        item.Nome +
                        ".pdf";
                    relatorio.ExportToPdf(pdfExportFile);
                    _logger.LogInformation(item.Nome);
                }
            }

        
    }
}