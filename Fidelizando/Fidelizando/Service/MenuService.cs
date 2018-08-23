using Fidelizando.Models;
using Fidelizando.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Fidelizando.Service
{
    public class MenuService
    {
        private static ObservableCollection<Fidelizando.Models.Menu> menuLista { get; set; }

        public static ObservableCollection<Fidelizando.Models.Menu> GetMenuItens()
        {
            menuLista = new ObservableCollection<Fidelizando.Models.Menu>();

            var pagina1 = new Fidelizando.Models.Menu() { Titulo = "Inicio", Icone = "", TargetType = typeof(HomePage) };
            var pagina2 = new Fidelizando.Models.Menu() { Titulo = "Meus Pontos", Icone = "", TargetType = typeof(PontosPage) };
            var pagina3 = new Fidelizando.Models.Menu() { Titulo = "Meus Dados", Icone = "", TargetType = typeof(DadosPage) };
            var pagina4 = new Fidelizando.Models.Menu() { Titulo = "Cadastrar Pontos", Icone = "", TargetType = typeof(CadastrarPage) };
            var pagina5 = new Fidelizando.Models.Menu() { Titulo = "Sair", Icone = "", TargetType = typeof(RegisterPage) };

            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
            menuLista.Add(pagina3);
            menuLista.Add(pagina4);
            menuLista.Add(pagina5);

            return menuLista;
        }
    }
}
