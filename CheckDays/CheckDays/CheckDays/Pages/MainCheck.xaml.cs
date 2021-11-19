using CheckDays.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckDays.Pages
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class MyImageBut : ImageButton
    {
        public new int Id { get; set; }
        public MyImageBut() : base(){ }

    }
    
    public partial class MainCheck : TabbedPage
    {
        protected int CoinsCount = 0;
        public MainCheck()
        {
            InitializeComponent();
        }
        private async void ButtonPlusPressed( object sender, EventArgs e)
        {
            var action=await DisplayActionSheet("Тип задачи", "", "Отмена", "Обычная","Быстрая","Важная");
            MyImageBut ImgBut = new MyImageBut
            {
                HeightRequest = MainCheckdata.HeightStackCheck,
                BackgroundColor = Color.FromHex(MainCheckdata.ColorNormal),
                Id = CoinsCount
            };
            ImgBut.Clicked += ImgButClicked;
            switch(action)
            {
                case "Обычная":
                    ImgBut.BackgroundColor = Color.FromHex(MainCheckdata.ColorNormal);
                    MainCheckedList.Children.Add(ImgBut);
                    ++CoinsCount;
                    break;
                case "Быстрая":
                    ImgBut.BackgroundColor = Color.FromHex(MainCheckdata.ColorNow);
                    MainCheckedList.Children.Add(ImgBut);
                    ++CoinsCount;
                    break;
                case "Важная":
                    ImgBut.BackgroundColor = Color.FromHex(MainCheckdata.ColorNext);
                    MainCheckedList.Children.Add(ImgBut);
                    ++CoinsCount;
                    break;
            }
            
        }
        private void ButtonMinusPressed(object sender, EventArgs e)
        {
            MainCheckedList.Children.RemoveAt(MainCheckedList.Children.Count-1);
        }
        private async void ImgButClicked(object sender, EventArgs e)
        {
            MyImageBut but = (MyImageBut)sender;
            //MainCheckedList.Children.Remove(but);
            await Navigation.PushAsync(new YourCheckPage());
        }
    }
}