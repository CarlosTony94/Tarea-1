using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                editor1.Text = File.ReadAllText(_fileName);
                editor2.Text = File.ReadAllText(_fileName);
                editor3.Text = File.ReadAllText(_fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //File.WriteAllText(_fileName, editor.Text);
            int nun1 = Int16.Parse(editor1.Text);
            int nun2 = Int16.Parse(editor2.Text);
            int result = nun1 + nun2;
            editor3.Text = result.ToString();
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor1.Text = string.Empty;
            editor2.Text = string.Empty;
            editor3.Text = string.Empty;
        }
    }
}