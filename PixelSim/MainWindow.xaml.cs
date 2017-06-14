using System;
using System.Windows;
using CellularAutomata.Model;

namespace PixelSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public event EventHandler MapButtonPressed;
        public event EventHandler StartButtonPressed;
        public event EventHandler ShowStatusBoxMenuItemClicked;
        public event EventHandler ChangedTimerTrackBar;
        public event EventHandler GraphicsButtonPressed;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetupMap()
        {
            mapPanel.Width = Map.Width * Map.Resolution;
            mapPanel.Height = Map.Height * Map.Resolution;
        }
    }
}
