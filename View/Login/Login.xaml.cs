namespace ngaji_yukk.View.Login;
using Riwayat_Mengaji;

public partial class Login : ContentPage{
  public Login(){
		InitializeComponent();
    LoginButton.Text = $"Masuk Sebagai Tamu";
  }
  void handleInput(object sender, TextChangedEventArgs e){
    string oldText = e.OldTextValue;
    string newText = e.NewTextValue;
    string myText = name.Text;
    if(myText.Length <= 1){
      myText = "Tamu";
    }
    LoginButton.Text = $"Masuk Sebagai {newText}";
  }

  async void onClick(object sender, EventArgs e){
    await DisplayAlert("Login Success", $"Halo {name.Text}", "OK");
    await Navigation.PushAsync(new RiwayatMengaji(name.Text));
  }

  void outputHandleInput(object sender, EventArgs e){
    string text = ((Entry)sender).Text;
  }
}