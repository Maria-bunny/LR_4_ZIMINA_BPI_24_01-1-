using System.Windows;
using LR_4_ZIMINA_BPI_24_01.ViewModel;

namespace LR_4_ZIMINA_BPI_24_01.View
{
    public partial class WindowRole : Window
    {
        public WindowRole()
        {
            InitializeComponent();
            DataContext = new RoleViewModel(); 
        }
    }
}