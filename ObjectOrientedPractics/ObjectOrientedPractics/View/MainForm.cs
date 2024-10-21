using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            itemsTabControl.Items = _store.Items;
            customersTabControl.Customers = _store.Customers;

        }
        private Store _store = new Store();
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void itemsTab1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
