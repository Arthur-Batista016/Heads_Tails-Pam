﻿using CommunityToolkit.Mvvm.ComponentModel;
using HeadsTails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HeadsTails.viewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        //public string Resultado { get; set; }//
        private string resultado;


        [ObservableProperty]
        //public string Imagem { get; set; }
        private string imagem;
        
        [ObservableProperty]
        //public string Escolha { get; set; }
        private string escolha;

        public ICommand JogarCommand {get;}

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);

        }

        public void Jogar()
        {
            //instanciando uma moeda
            //sorteio um lado
            //comparo o lado sorteado com a escolha do jogador
            //exibo o resultado

            Coin coin = new Coin();
            coin.Jogar();
            Resultado = Escolha == coin.LadoSorteado ? "Você Venceu" : "Você Perdeu";// if Ternario = If resumido//
        }
    }
}
