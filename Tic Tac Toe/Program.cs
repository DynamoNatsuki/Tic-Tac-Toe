// Initialize an array representing the game board with 9 elements.
int[] board = new int[9];

// Loop through each position on the board.
for (int i = 0; i < 9; i++)
{
    // Set each position on the board to 0, indicating it is empty.
    board[i] = 0;
}

// Variables to track the user's and computer's turns, initially set to -1 (no move made yet).
int userTurn = -1;
int computerTurn = -1;

// Create a new Random object for generating random numbers.
Random rand = new Random();

// Loop until there is a winner (checkForWinner() returns a non-zero value).
while (checkForWinner() == 0)
{
    // Prompt the user until they select a valid and unoccupied space.
    while (userTurn == -1 || board[userTurn] != 0)
    {
        Console.WriteLine("Please enter a number from 0 to 8");
        userTurn = int.Parse(Console.ReadLine()); // Read user's input and convert to an integer.
        Console.WriteLine("You typed " + userTurn);
    }

    // Mark the user's move on the board with a 1.
    board[userTurn] = 1;

    // Generate a random move for the computer that is not occupied.
    while (computerTurn == -1 || board[computerTurn] != 0)
    {
        computerTurn = rand.Next(8); // Generate a random number between 0 and 8.
        Console.WriteLine("Computer chooses " + computerTurn);
    }

    // Mark the computer's move on the board with a 2.
    board[computerTurn] = 2;

    // Print the current state of the board.
    printBoard();
}

// Announce the winner (1 for user, 2 for computer).
Console.WriteLine("Player " + checkForWinner() + " won the game!");

// Function to check for a winner.
int checkForWinner()
{
    // Check if the top row has the same value and return it if so.
    if (board[0] == board[1] && board[1] == board[2])
    {
        return board[0];
    }

    // Check if the second row has the same value and return it if so.
    if (board[3] == board[4] && board[4] == board[5])
    {
        return board[3];
    }

    // Check if the third row has the same value and return it if so.
    if (board[6] == board[7] && board[7] == board[8])
    {
        return board[6];
    }

    // Check if the first column has the same value and return it if so.
    if (board[0] == board[3] && board[3] == board[6])
    {
        return board[0];
    }

    // Check if the second column has the same value and return it if so.
    if (board[1] == board[4] && board[4] == board[7])
    {
        return board[1];
    }

    // Check if the third column has the same value and return it if so.
    if (board[2] == board[5] && board[5] == board[8])
    {
        return board[2];
    }

    // Check if the first diagonal has the same value and return it if so.
    if (board[0] == board[4] && board[4] == board[8])
    {
        return board[0];
    }

    // Check if the second diagonal has the same value and return it if so.
    if (board[2] == board[4] && board[4] == board[6])
    {
        return board[2];
    }

    // Return 0 if there is no winner yet.
    return 0;
}

// Function to print the current state of the board.
void printBoard()
{
    // Loop through each position on the board.
    for (int i = 0; i < 9; i++)
    {
        // Print a dot for empty positions.
        if (board[i] == 0)
        {
            Console.Write(".");
        }
        // Print an 'X' for user moves.
        if (board[i] == 1)
        {
            Console.Write("X");
        }
        // Print an 'O' for computer moves.
        if (board[i] == 2)
        {
            Console.Write("O");
        }

        // Print a new line after every third position to format the board.
        if (i == 2 || i == 5 || i == 8)
        {
            Console.WriteLine();
        }
    }
}
