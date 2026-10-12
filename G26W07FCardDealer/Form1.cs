namespace G26W07FCardDealer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string[] suits = ["spades", "hearts", "diamonds", "clubs"];
        string[] values = ["ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"];

        Random random = new Random();

        private void OnDeal(object sender, EventArgs e) {


            int card = random.Next(suits.Length * values.Length);

            string suit = suits[card / values.Length];
            string value = values[card % values.Length];

            //if (value == "jack" || value == "queen" || value == "king") { suit += "2";}
            if (value is "jack" or "queen" or "king") {
                suit += "2";
            }


            string name = $"{value}_of_{suit}";

            Card1.Image = Properties.Resources.ResourceManager
                .GetObject(name) as Image
                ?? Properties.Resources.red_joker;
        }
    }
}
