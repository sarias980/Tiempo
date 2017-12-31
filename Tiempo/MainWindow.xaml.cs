using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tiempo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private Alarma AlarmaActual;
        const string FileName = @"..\..\SavedLoan.bin";
        const string HorasName = @"..\..\Secundarias.bin";
        public List<DiferenciaHoraria> horas { get; set; }
        private DiferenciaHoraria diferencia;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Crear_Hora_Secundaria(object sender, RoutedEventArgs e)
        {
            Agregar1 agregar = new Agregar1();
            if (agregar.ShowDialog() == true)
            {
                horas.Add(agregar.Answer);
                ComboBoxItem nou = new ComboBoxItem();
                nou.Content = agregar.Answer.getNombre();
                Horas.Items.Add(nou);
            }
        }

        private void Eliminar_Hora_Secundaria(object sender, RoutedEventArgs e)
        {
            horas.Remove(diferencia);
            Horas.Items.Remove(Horas.SelectedItem);
            Hora_2.Text = null;
            horas.Sort();
            Horas.SelectedItem = horas[0];
            diferencia = null;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Autor: Sergi Arias Fernández \nContacta: sarias980@gmail.com");
        }

        void timer_Tick (object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();

            if (radio_on.IsChecked == true)
            {
                if (Hora.Text == textoAlarma.Text)
                {
                    MessageBox.Show("Es la hora");
                }
            }
            if (diferencia != null)
            {
                Hora_2.Text = DateTime.Now.AddHours(diferencia.getHora()).ToLongTimeString();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AlarmaActual = new Alarma();
            AlarmaActual.Hora = new DateTime();
            horas = new List<DiferenciaHoraria>();

            if (System.IO.File.Exists(FileName))
            {
                Stream TestFileStream = System.IO.File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                AlarmaActual = (Alarma)deserializer.Deserialize(TestFileStream);
                TestFileStream.Close();
            }

            if (System.IO.File.Exists(HorasName))
            {
                    Stream TestHorasStream = System.IO.File.OpenRead(HorasName);
                    BinaryFormatter deserializer = new BinaryFormatter();
                    horas = (List<DiferenciaHoraria>)deserializer.Deserialize(TestHorasStream);
                    TestHorasStream.Close();
            }

            textoAlarma.Text = AlarmaActual.Hora.ToLongTimeString();
            if (AlarmaActual.getAlarma())
            {
                radio_on.IsChecked = true;
            }
            else {
                radio_on.IsChecked = false;
            }

            for (int i = 0; i < horas.Count; i++)
            {
                ComboBoxItem nou = new ComboBoxItem();
                nou.Content = horas[i].getNombre();
                Horas.Items.Add(nou);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            AlarmaActual.Hora = Convert.ToDateTime(textoAlarma.Text);
            if (radio_on.IsChecked == true) {
                AlarmaActual.setActiva(true);
            }else {
                AlarmaActual.setActiva(false);
            }
           
            Stream TestFileStream = System.IO.File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, AlarmaActual);
            TestFileStream.Close();

            Stream TestHorasStream = System.IO.File.Create(HorasName);
            BinaryFormatter serializer2 = new BinaryFormatter();
            serializer2.Serialize(TestHorasStream, horas);
            TestFileStream.Close();
        }

        private void Horas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Horas.SelectedItem != null)
            {
                foreach (DiferenciaHoraria diferenciaHoraria in horas)
                {
                    String[] substrings = Horas.SelectedItem.ToString().Split(' ');

                    if (String.Compare(diferenciaHoraria.getNombre(), substrings[1]) == 0)
                    {
                        diferencia = diferenciaHoraria;
                    }
                }
            }
        }
    }
}