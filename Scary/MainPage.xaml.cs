using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;

namespace Scary
{
    public partial class MainPage : ContentPage
    {
        int cont = 0;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            cont++;
            label_mensagem.Text = "Voce clicou" + cont + "vezes";

            var player = CrossSimpleAudioPlayer.Current;
            player.Load("grito_de_medo.mp3");

            if(cont == 10){
                player.Play();
                label_mensagem.Text = "AAAAAAAAAAAAAAAAA";
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
