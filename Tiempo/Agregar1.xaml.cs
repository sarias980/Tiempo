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
using System.Windows.Shapes;

namespace Tiempo
{
    /// <summary>
    /// Lógica de interacción para Agregar1.xaml
    /// </summary>
    public partial class Agregar1 : Window
    {
        public DiferenciaHoraria diferencia = new DiferenciaHoraria();

        public Agregar1()
    {
        InitializeComponent();
    }

    private void btnDialogOk_Click(object sender, RoutedEventArgs e)
    {
        diferencia.setNombre(txtAnswer_Nombre.Text);
        diferencia.setHora(Int64.Parse(txtAnswer_Hora.Text));
        this.DialogResult = true;
    }

    private void Window_ContentRendered(object sender, EventArgs e)
    {
        txtAnswer_Nombre.SelectAll();
        txtAnswer_Nombre.Focus();
    }

    public DiferenciaHoraria Answer
    {
        get { return diferencia; }
    }
}
}


