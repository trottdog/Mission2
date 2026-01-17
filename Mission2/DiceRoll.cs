namespace Mission2;

internal class DiceRoll
{ 
    public int[] RollDice(int rolls)
    {
        int[] counts = new int[13];
        Random number = new Random();

        for (var i = 0; i < rolls; i++)
        {
            var dice1   = number.Next(1, 7);
            var dice2   = number.Next(1, 7);
            var sum = dice1 + dice2;
            counts[sum]++;
        }
        return counts;
    }
}
