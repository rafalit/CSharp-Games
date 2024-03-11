using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Snake;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly int rows = 15, cols = 15;
    private readonly Image[,] gridImages;

    public MainWindow()
    {
        try
        {
            InitializeComponent();
            gridImages = SetupGrid();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private Image[,] SetupGrid()
    {
        Image[,] images = new Image[rows, cols];
        

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Image imageControl = new Image
                {
                    Source = Images.Head
                };

                images[r, c] = imageControl;
                GameGrid.Children.Add(imageControl);
            }
        }

        return images;
    }

}
