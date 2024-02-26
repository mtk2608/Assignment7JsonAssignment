using Newtonsoft.Json;

namespace JsonAssignment2._0
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            NewUser = LoadData();

            
        }

        #region Properties

        private Profile _profile;

        public Profile NewUser
        {
            get { return _profile; }
            set
            {
                _profile = value;

                OnPropertyChanged();
            }
        }

        #endregion

        #region EventHandlers

        public void SaveData(Profile profile)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalStorageText.txt");
            string profileJson = JsonConvert.SerializeObject(profile);
            File.WriteAllText(filePath, profileJson);

            TextBox.Text = profileJson;
        }


        public Profile LoadData()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalStorageText.txt");

            if (File.Exists(filePath))
            {

                string fileContent = File.ReadAllText(filePath);

                Profile savedProfile = JsonConvert.DeserializeObject<Profile>(fileContent);

                return savedProfile;
            }
            else
                return new Profile();
        }


        private void Save_Clicked(object sender, EventArgs e)
        {
            SaveData(NewUser);
        }

        private void Load_Clicked(object sender, EventArgs e)
        {
            NewUser = LoadData();
        }
        #endregion

    }
}

