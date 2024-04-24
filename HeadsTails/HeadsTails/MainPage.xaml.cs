using static System.Net.WebRequestMethods;

namespace HeadsTails
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

         bool headButtonClicked = false;
         bool tailsButtonClicked = false;

        private void headBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            headButtonClicked = true;
            headBtn.BackgroundColor = Color.FromHex("#000000");
            TailsBtn.BackgroundColor = Color.FromHex("#0000FF");

        }

        private void TailsBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            tailsButtonClicked = true;
            TailsBtn.BackgroundColor = Color.FromHex("#000000");
            headBtn.BackgroundColor = Color.FromHex("#0000FF");
        }

        private void randomBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == 0)
            {
                moeda.Source = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/0c0483ff-7316-4928-957d-3d0b1b7e0ec7/d84p3mj-44fe4bd2-a539-499e-bfe7-f830d9dcd193.jpg/v1/fill/w_1600,h_1621,q_75,strp/cara___moeda_de_1__real_vetorizada_by_matheus8b_d84p3mj-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTYyMSIsInBhdGgiOiJcL2ZcLzBjMDQ4M2ZmLTczMTYtNDkyOC05NTdkLTNkMGIxYjdlMGVjN1wvZDg0cDNtai00NGZlNGJkMi1hNTM5LTQ5OWUtYmZlNy1mODMwZDlkY2QxOTMuanBnIiwid2lkdGgiOiI8PTE2MDAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.KhaoPG_8-7w5c52tXnSq2eE4q75hpbqlmrE2q07CkI4";

                if (headButtonClicked==true){
                    DisplayAlert("Cara", "Você Acertou!!", "Ok");
                }
                else if(headButtonClicked == false)
                {
                    DisplayAlert("Cara", "Você Errou!!, tente novamente", "Ok");
                }
            }
            else if (result == 1)
            {
                moeda.Source = "https://t4.ftcdn.net/jpg/05/64/35/03/360_F_564350370_LYxzggTtdpEvOMMUAxVFSTlTeQWfbh1L.jpg";
               
                if (tailsButtonClicked==true){
                    DisplayAlert("Coroa", "Você Acertou!!", "Ok");
                }
                else if(tailsButtonClicked == false)
                {
                    DisplayAlert("Coroa", "Você Errou!!, tente novamente", "Ok");
                }

            }

           
        }
    }

}
