using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.Generic;


namespace WpfIntro;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnGenerar_Click(object sender, RoutedEventArgs e)
    {
        string nombre = txtNombre.Text;

        ComboBoxItem item =
            (ComboBoxItem)cmbClase.SelectedItem;

        string clase = item.Content.ToString();

        StringBuilder habilidades =
            new StringBuilder();

        if (chkEspada.IsChecked == true)
            habilidades.AppendLine("- Espada");

        if (chkMagia.IsChecked == true)
            habilidades.AppendLine("- Magia");

         if (chkFuerza.IsChecked == true)
            habilidades.AppendLine("- Fuerza");

        switch (clase)
        {
            case "Guerrero":
                imgPersonaje.Source =
                    new BitmapImage(
                        new Uri("Images/evil mosaico.png",
                        UriKind.Relative));
                break;

            case "Mago":
                imgPersonaje.Source =
                    new BitmapImage(
                        new Uri("Images/mosaico.jpg",
                        UriKind.Relative));
                break;

             case "Arquero":
                imgPersonaje.Source =
                    new BitmapImage(
                        new Uri("Images/todavía más evil mosaico.png",
                        UriKind.Relative));
                break;
        }

        txtResultado.Text =
            $"Nombre: {nombre}\n" +
            $"Clase: {clase}\n" +
            $"Habilidades:\n{habilidades}";
    }

    private void BtnLimpiar_Click(object sender, RoutedEventArgs e)
    {
         txtNombre.Clear();
         txtResultado.Text= "";
        chkEspada.IsChecked= false;
        chkMagia.IsChecked= false;
        chkFuerza.IsChecked= false;
        imgPersonaje.Source= null;
        cmbClase.SelectedItem= null;

         
    }
}
