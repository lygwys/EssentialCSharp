namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_21
{
    public class Program
    {
        public static void Main()
        {
            #region INCLUDE
            int[,] cells = {
                {1, 0, 2},
                {0, 2, 0},
                {1, 2, 1}
            };
            // Set the winning tic-tac-toe move to be player 1
            cells[1, 0] = 1;
            #endregion INCLUDE
        }
    }
}
