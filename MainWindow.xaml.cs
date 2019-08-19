using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;

namespace SpeakHelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Speak_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.Speak("Hello World");
        }

        private void SpeakText_Click(object sender, RoutedEventArgs e)
        {
            SpeechSynthesizer synthText = new SpeechSynthesizer();

            synthText.SetOutputToDefaultAudioDevice();

            synthText.Speak(SpeechInput.Text);
        }

        private void SpeechInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            SpeakText.IsEnabled = true;
        }
    }
}
