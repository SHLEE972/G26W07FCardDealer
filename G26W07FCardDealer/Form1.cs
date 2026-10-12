namespace G26W07FCardDealer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void OnDeal(object sender, EventArgs e) {
            String name = "10_of_clubs";

            Card1.Image = Properties.Resources.ResourceManager
                .GetObject(name) as Image
                ?? Properties.Resources.red_joker;
        }
    }
}
