using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace ankieta_preferencji;

public partial class MainWindow : Window
{
    private TextBox _InputName;
    private Button _SummaryButton;
    private TextBlock _Summary;
    private ComboBox _InputIntrest;
    public MainWindow()
    {
        InitializeComponent();

        _InputName = this.Find<TextBox>("InputName");
        _InputIntrest = this.Find<ComboBox>("nputIntrest");
        _SummaryButton = this.Find<Button>("SummaryButton");
        _Summary = this.Find<TextBlock>("Summary");
    }

    private void SaveDataButton_CLick(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine(e);
        var inputName = _InputName.Text;
        var inputInsert = (InputIntrest.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";
        
    }

    private void SummaryButton_Click(object? sender, RoutedEventArgs e)
    {
        
    }
}