namespace G26W07FCardDealer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string[] suits = ["spades", "hearts", "diamonds", "clubs"];
        string[] values = ["ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king"];

        Random random = new Random();

        private void OnDeal(object sender, EventArgs e) {
            PictureBox[] cardBoxes = [Card1, Card2, Card3, Card4, Card5];
            List<int> drawnCards = new List<int>();

            // 중복X 카드 번호 5개 뽑기
            while (drawnCards.Count < cardBoxes.Length) {
                int card = random.Next(suits.Length * values.Length);

                if (!drawnCards.Contains(card)) {
                    drawnCards.Add(card);
                }
            }

            // for문을 사용하여 뽑은 카드를 각각의 Card에 표시
            for (int i = 0; i < cardBoxes.Length; i++) {
                int card = drawnCards[i];

                string suit = suits[card / values.Length];
                string value = values[card % values.Length];

                if (value is "jack" or "queen" or "king") {
                    suit += "2";
                }

                string name = $"{value}_of_{suit}";

                cardBoxes[i].Image = Properties.Resources.ResourceManager
                    .GetObject(name) as Image
                    ?? Properties.Resources.red_joker;
            }
        }
    }
}   