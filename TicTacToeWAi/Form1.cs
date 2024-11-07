using System.Diagnostics.Tracing;

namespace TicTacToeWAi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum FieldState
        {
            None,
            X,
            O
        };

        enum PlayerType { 
            O, X
        }; //yes, technically this is not necessary but just keep it here for now for organization sake

        FieldState[,] Board = new FieldState[3, 3];
        FieldState CurrentFieldState = FieldState.X;
        static int[] NormedMoveIndex = { 0, 0 };
        static int moveCounter = 0;
       
        private void Form1_Load(object sender, EventArgs e)  //treat this as init :3
        {
            //init board with empty spots
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = FieldState.None;
                }
            }
        }

        void normMoveIndex(int input)
        {
            NormedMoveIndex[0] = input / 3;
            NormedMoveIndex[1] = input % 3;
        }

        bool checkMoveLegality()
        {
            if (Board[NormedMoveIndex[0], NormedMoveIndex[1]] == FieldState.None) return true;
            else return false;
        }

        private bool checkWin() {
            return true;
        }

        void requestUpdate(int updateId) {

            normMoveIndex(updateId);

            if (moveCounter == 9)
            {
                String[] captionBuffers = { "1", "2" };

                if (checkWin()) {
                    captionBuffers[0] = "Hello Fine Shyt. You Win!";
                                  captionBuffers[1] = "Ok Mister"; }
                updateDisplay(true);      

            }

            else if (checkMoveLegality())
            {
                Board[NormedMoveIndex[0], NormedMoveIndex[1]] = CurrentFieldState;
                //(CurrentFieldState == FieldState.X ? CurrentFieldState = FieldState.O : CurrentFieldState = FieldState.X);
                if (CurrentFieldState == FieldState.X) CurrentFieldState = FieldState.O;
                else CurrentFieldState = FieldState.X;
                moveCounter++;
                updateDisplay();
            }
            else {
                MessageBox.Show("hi fyne shit. there a thang right there.", 
                                "hi fine shyt", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
            };
        }

        private void updateDisplay(bool refresh = false) {
            Label[,] labelArray = { {space00, space01, space02},
                                    {space10, space11, space12},
                                    {space20, space21, space22}};
            if (!refresh)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Board[i, j] == FieldState.None) continue;
                        if (Board[i, j] == FieldState.X) labelArray[i, j].Text = "X";
                        else labelArray[i, j].Text = "O";
                    }
                }
            }
            else {
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++)
                    {
                        labelArray[i, j].Text = "";
                    } 
                }
            }
        }

        private void space00_Click(object sender, EventArgs e)
        {
            requestUpdate(0);
        }

        private void space01_Click(object sender, EventArgs e)
        {
            requestUpdate(1);
        }

        private void space02_Click(object sender, EventArgs e)
        {
            requestUpdate(2);
        }

        private void space10_Click(object sender, EventArgs e)
        {
            requestUpdate(3);
        }

        private void space11_Click(object sender, EventArgs e)
        {
            requestUpdate(4);
        }

        private void space12_Click(object sender, EventArgs e)
        {
            requestUpdate(5);
        }

        private void space20_Click(object sender, EventArgs e)
        {
            requestUpdate(6);
        }

        private void space21_Click(object sender, EventArgs e)
        {
            requestUpdate(7);
        }

        private void space22_Click(object sender, EventArgs e)
        {
            requestUpdate(8);
        }
    }
}