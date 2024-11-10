using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

//yes, this file was written in full by nebojsa ramic. think of this as my copyright disclaimer
//no assistive tools nor help was used during its creation (this much is apparent, this code is really unoptimized)
//yes, i think c++ would have been better :(

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

        FieldState[,] Board = new FieldState[3, 3];
        AI mainAi = new AI();
         //rudementary expandability matrix, gives a value to each field that illustrates how 
                                                    //many winning positions can be reached from the given field
                                                    //used for eval of a position without a definite end

        FieldState determineWinner(FieldState[,] BIn)
        {
            for (int i = 0; i < 3; i++)
            {
                if (BIn[0, i] != FieldState.None)
                {
                    if (BIn[0, i] == BIn[1, i] && BIn[1, i] == BIn[2, i]) return BIn[0, i];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (BIn[i, 0] != FieldState.None)
                {
                    if (BIn[i, 0] == BIn[i, 1] && BIn[i, 1] == BIn[i, 2]) return BIn[i, 0];
                }
            }
            if (BIn[0, 0] != FieldState.None && BIn[0, 0] == BIn[1, 1] && BIn[1, 1] == BIn[2, 2]) return BIn[0, 0];
            if (BIn[0, 2] != FieldState.None && BIn[0, 2] == BIn[1, 1] && BIn[1, 1] == BIn[2, 0]) return BIn[0, 2];
            return FieldState.None;
        }

        class MoveNode {
            private int move;
            private FieldState moveSign;
            private FieldState[,] InternalBoard = new FieldState[3, 3];
            int[,] expandabilityMatrix = {{3, 2, 3 },
                                          {2, 4, 2 },
                                          {3, 2, 3 }};
            public MoveNode() {
                this.move = 0;
            }

            public int returnMove() { return this.move; }
            public void setMove(int move) { this.move = move; }
            public void setmoveSign(FieldState input) { this.moveSign = input; }
            public FieldState getMoveSign() { return this.moveSign; }
            public void setBoard(FieldState[,] InputBoard) { this.InternalBoard = InputBoard; }
            public FieldState[,] getBoard() { return this.InternalBoard; }
            public void displayDebug() {
                System.Diagnostics.Debug.WriteLine($"move: {move}");
            }
        }

        class MoveMap {
            private MoveNode[] moveSequence;
            private int numberOfMoves;
            FieldState[,] currentBoard = new FieldState[3, 3];

            private float eval;

            public MoveMap() {
                moveSequence = new MoveNode[1];
                numberOfMoves = 1;
            }

            public void setcurrentBoard(FieldState[,] Board) { 
                
            }

            public MoveMap(MoveNode[] moves) {
                moveSequence = new MoveNode[moves.Length];
                moveSequence = moves;
                numberOfMoves = moves.Length;
            }

            public void addMoveToMap(MoveNode move)
            {
                MoveNode[] tempMoves = new MoveNode[numberOfMoves];
                tempMoves = moveSequence;
                numberOfMoves++;
                moveSequence = new MoveNode[numberOfMoves];
                moveSequence = tempMoves;
                tempMoves = null; //MAYBE WONT WORK
            }

            public void addMoveToMap(MoveNode[] move)
            {
                MoveNode[] tempMoves = new MoveNode[numberOfMoves];
                numberOfMoves += move.Length;
                tempMoves = moveSequence;
                moveSequence = new MoveNode[numberOfMoves];
                moveSequence = tempMoves;
                for (int i = moveSequence.Length; i < numberOfMoves; i++)
                {
                    moveSequence[i] = move[i];
                }
                tempMoves = null; //MAYBE WONT WORK
            }

            public void removeMoves(int removalNumber)
            {
                if (removalNumber > numberOfMoves) return;
                MoveNode[] tempMoves = new MoveNode[numberOfMoves];
                numberOfMoves -= removalNumber;
                tempMoves = moveSequence;
                moveSequence = new MoveNode[numberOfMoves];
                for (int i = 0; i < numberOfMoves; i++) {
                    moveSequence[i] = tempMoves[i];
                }
                tempMoves = null;
            }

        }

        bool AIIsActive = false;
        int[] allMoves = new int[9];

        class AI
        {
            Random randUtil = new Random();
            private bool isFirstMove = true;
            private FieldState selfSign;
            private FieldState[,] Board = new FieldState[3, 3];
            private FieldState[,] AnalysisBoard = new FieldState[3, 3];
            MoveMap[] bestMoves = new MoveMap[3];
            List<MoveMap[]> moveMaps = new List<MoveMap[]>();
            List<MoveNode[]> moves = new List<MoveNode[]>();
            float temperature;
            int searchDepth;
            public void setSearchDepth(int searchDepth) { this.searchDepth = searchDepth; }
            public void setTemperature(float temperature) { this.temperature = temperature; }

            public void resetState() {
                isFirstMove = true;
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Board[i, j] = FieldState.None; AnalysisBoard[i, j] = FieldState.None; } }
                bestMoves = new MoveMap[3];
                moves.Clear();
            }

            public void setTeam(FieldState input) { this.selfSign = input; }
            public AI(){
                temperature = 0;
                searchDepth = 1;
                selfSign = FieldState.O;
                isFirstMove = true;
            }
            public AI(FieldState selfSign, int temperature = 0, int searchDepth = 0){
                this.temperature = temperature;
                this.searchDepth = searchDepth;
                this.selfSign = selfSign;
                isFirstMove=true;
            }
            public FieldState team() {
                return selfSign;
            }
            private int getVacancyCountOnBoard() {
                int result = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (Board[i, j] == FieldState.None) result++;
                    }
                }
                return result;
            }

            private bool[,] getVacancyMatrix() {
                bool[,] vacancyMatrix = new bool[3, 3];
                for (int i = 0; i < 3; i++) {
                    for (int j = 0; j < 3; j++) {
                        vacancyMatrix[i, j] = (Board[i, j] == FieldState.None);
                    }
                }
                return vacancyMatrix;
            }

            public string[,] displayInternalBoard() {
                string[,] board = new string[3, 3];
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) {

                        if (Board[i, j] == FieldState.None) board[i, j] = "";
                        else if (Board[i, j] == FieldState.X) board[i, j] = "X";
                        else board[i, j] = "O";
                    
                }}
                return board;
            }

            private MoveNode[] findMovesForVacantBoard(FieldState[,] InputBoard) {
                Board = InputBoard;

                bool[,] vacancyMatrix = new bool[3, 3];

                int vacancyCounter = getVacancyCountOnBoard();
                vacancyMatrix = getVacancyMatrix();

                int movemapIndex = 0;

                MoveNode[] newMoveNode = new MoveNode[vacancyCounter];
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (vacancyMatrix[i, j])
                        {
                            newMoveNode[movemapIndex].setMove(i * 3 + j);
                            newMoveNode[movemapIndex].setBoard(returnModulatedBoard(InputBoard, newMoveNode[movemapIndex].returnMove(), moveCounter));
                            System.Diagnostics.Debug.Write(newMoveNode[movemapIndex].returnMove() + ",");
                            movemapIndex++;
                        }
                    }
                }
                return newMoveNode;
            }

            private FieldState[,] returnModulatedBoard(FieldState[,] InputBoard, int move, int moveCount) {
                FieldState fieldstatebuffer;
                if (moveCount % 2 == 0) fieldstatebuffer = FieldState.O;
                else fieldstatebuffer = FieldState.X;

                FieldState[,] newBoard = new FieldState[3, 3];
                newBoard = InputBoard;
                newBoard[move / 3, move % 3] = fieldstatebuffer;
                return newBoard;
            }

            private void throwAwayUselessBranches(int branchIndex, FieldState[,] InputBoard) {
                int startIndex = branchIndex * (9 - moveCounter - (branchIndex + 1));
                MoveNode[] tempNode = new MoveNode[9 - moveCounter - (branchIndex + 1)];
                for (int j = 0; j < tempNode.Length; j++)
                {
                    tempNode[j] = moves[branchIndex][startIndex + j];
                }
                moves[branchIndex-1] = tempNode;
            }

            public int makeMove(FieldState[,] InputBoard) {

                if (isFirstMove) { findMovesForVacantBoard(InputBoard); isFirstMove = false; }
                else {
                    for (int i = 0; i < moves[0].Length; i++)
                    {
                        if (returnModulatedBoard(InputBoard, moves[0][i].returnMove(), moveCounter) == InputBoard)
                        {
                            for (int j = 1; j < searchDepth; j++) {
                                throwAwayUselessBranches(j, InputBoard);
                            }
                        }
                    }
                }
                int missingTiers = searchDepth - moves.Count;
                for (int i = 0; i < missingTiers; i++) {
                    int indexSize;
                }
                return 0;
            }
        }
        
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
            return false;
        }

        void resetGame() {
            mainAi.resetState();
            updateDisplay(true);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board[i, j] = FieldState.None;
                }
            }
            moveCounter = 0;
            CurrentFieldState = FieldState.X;
        }

        public int unnormMoveIndex() {
            int result = 0;
            result = NormedMoveIndex[0] * 3 + NormedMoveIndex[1];
            return result;
        }

        private void requestUpdate(int updateId) {
            normMoveIndex(updateId);

            if (checkMoveLegality())
            {
                Board[NormedMoveIndex[0], NormedMoveIndex[1]] = CurrentFieldState;
                //(CurrentFieldState == FieldState.X ? CurrentFieldState = FieldState.O : CurrentFieldState = FieldState.X);
                if (CurrentFieldState == FieldState.X) CurrentFieldState = FieldState.O;
                else CurrentFieldState = FieldState.X;
                allMoves[moveCounter] = updateId;
                moveCounter++;
                updateDisplay();
                switch (determineWinner(Board)) {
                    case FieldState.X:
                        MessageBox.Show("X wins", "X wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetGame();
                        return;
                    case FieldState.O:
                        MessageBox.Show("O wins", "O wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetGame();
                        return;
                }
                if (AIIsActive)
                {
                    normMoveIndex(mainAi.makeMove(Board));
                    Board[NormedMoveIndex[0], NormedMoveIndex[1]] = CurrentFieldState;
                    if (CurrentFieldState == FieldState.X) CurrentFieldState = FieldState.O;
                    else CurrentFieldState = FieldState.X;
                    moveCounter++;
                    updateDisplay();
                    switch (determineWinner(Board))
                    {
                        case FieldState.X:
                            MessageBox.Show("X wins", "X wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetGame();
                            return;
                        case FieldState.O:
                            MessageBox.Show("O wins", "O wins", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            resetGame();
                            return;
                    }
                }
            }
            else
            {
                MessageBox.Show("hi fyne shit. there a thang right there.",
                                "hi fine shyt",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            };
            if (moveCounter == 9)
            {
                String[] captionBuffers = { "1", "2" };
                switch (determineWinner(Board)) {
                    case FieldState.None:
                        captionBuffers[0] = "draw";
                        captionBuffers[1] = "draw";
                        break;
                    case FieldState.X:
                        captionBuffers[0] = "X won";
                        captionBuffers[1] = "X won";
                        break;
                    case FieldState.O:
                        captionBuffers[0] = "O won";
                        captionBuffers[1] = "O won";
                        break;
                }
                MessageBox.Show(
                    captionBuffers[0],
                    captionBuffers[1],
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                resetGame();
            }
        }
        private void updateDisplay(bool refresh = false) {
            Label[,] labelArray = { {space00, space01, space02},
                                    {space10, space11, space12},
                                    {space20, space21, space22}};
            Label[,] aiLabelArray = { {aispace00, aispace01, aispace02 },
                                      {aispace10, aispace11, aispace12 },
                                      {aispace20, aispace21, aispace22 } };
            if (!refresh)
            {
                for (int i = 0; i < 3; i++){for (int j = 0; j < 3; j++){
                        if (Board[i, j] == FieldState.None) continue;
                        if (Board[i, j] == FieldState.X) labelArray[i, j].Text = "X";
                        else labelArray[i, j].Text = "O";

                        if (AIIsActive && CurrentFieldState == mainAi.team()) {
                            string[,] aianalasysboard = mainAi.displayInternalBoard();
                            for (int k = 0; k < 3; k++){for (int g = 0; g < 3; g++){ aiLabelArray[k, g].Text = aianalasysboard[k, g]; }}
                        }}}
            }
            else {
                for (int i = 0; i < 3; i++) {for (int j = 0; j < 3; j++){labelArray[i, j].Text = "";}}
            }
        }

        private void space00_Click_1(object sender, EventArgs e)
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

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}