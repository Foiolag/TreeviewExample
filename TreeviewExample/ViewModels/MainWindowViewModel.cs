using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TreeviewExample.Models;

namespace TreeviewExample.ViewModels
{
    class MainWindowViewModel : Screen
    {
        private Banco _banco;
        private ObservableCollection<OfxTransação> _transaçõesNãoEncontradas;


        public MainWindowViewModel()
        {
            var transFounded = new List<Transações>()
            {
                new(0,0,true, new("0", DateTime.Now,5.0m,"0","","","Historico 1")),
                new(0,0,true, new("0", DateTime.Now,5.0m,"0","","","Historico 2"))

            };

            Banco = new()
            {
               Nome = "BANK XY",
               Grupos = new List<Grupo>()
               {
                   new(){ Nome = "GROUP 1", isZeroEnabled = true, ValorTotal = 10, Transações = transFounded },
                   new(){Nome = "GROUP 2", isZeroEnabled = true, ValorTotal = 10, Transações = transFounded }
               }
            };

            TransaçõesNãoEncontradas = new()
            {
                new("0", DateTime.Now, 5.0m, "0", "", "", "Item history not found 1"),
                new("0", DateTime.Now, 5.0m, "0", "", "", "Item history not found 2"),
                new("0", DateTime.Now, 5.0m, "0", "", "", "Item history not found 3"),
                new("0", DateTime.Now, 5.0m, "0", "", "", "Item history not found 4")
            };


        }

        public Banco Banco
        {
            get => _banco;
            set
            {
                if (_banco == value)
                    return;

                _banco = value;

                NotifyOfPropertyChange(() => Banco);                
            }
        }
        public ObservableCollection<OfxTransação> TransaçõesNãoEncontradas
        {
            get => _transaçõesNãoEncontradas;
            set
            {
                if (_transaçõesNãoEncontradas == value)
                    return;

                _transaçõesNãoEncontradas = value;
                NotifyOfPropertyChange(() => TransaçõesNãoEncontradas);
            }
        }



        public decimal SaldoNaoEncontrados
        {
            get
            {
                return _transaçõesNãoEncontradas?.Select(x => x.Valor)?.Sum() ?? 0;
            }
        }

        public decimal SaldoEncontrados
        {
            get
            {
                return Banco?.Grupos?.Select(x => x.ValorTotal)?.Sum() ?? 0;
            }
        }

    }
}
