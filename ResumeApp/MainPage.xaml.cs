namespace ResumeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnShowResumeButtonClicked(object sender, EventArgs e)
        {
            string resumeText = await LoadResumeAsync();
            ResumeLabel.Text = resumeText;
        }

        private async Task<string> LoadResumeAsync()
        {
            using (var stream = await FileSystem.OpenAppPackageFileAsync("Resume.txt"))
            using (var reader = new StreamReader(stream))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }

}
