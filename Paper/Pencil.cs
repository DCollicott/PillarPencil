using System;


namespace PillarPencil.Model
{
    public class Pencil
    {
        public int Durability { get; private set; }
        public int Length { get; private set; }
        public int EraserLength { get; private set; }


        private int InitialDurability;


        public Pencil(int Durability, int Length, int EraserLength)
        {
            if ((Durability < 0) || (Length < 0) || (EraserLength < 0))
                throw new ArgumentOutOfRangeException();

            this.Durability = Durability;
            this.InitialDurability = Durability;
            this.Length = Length;
            this.EraserLength = EraserLength;
        }


        public void Write(Paper Ppr, string NewText)
        {
            if (NewText == null)
                return;     // Remember, string is nullable. This is allowed. Just do nothing.

            foreach (char ch in NewText)
            {
                if (Durability < DurabilityCost(ch))
                    break;
                else
                {
                    Ppr.Append(ch);
                    Durability -= DurabilityCost(ch);
                }
            }
        }


        public bool Sharpen()
        {
            if (Length == 0)
                return false;

            Durability = InitialDurability;
            Length -= 1;

            return true;
        }


        private int DurabilityCost(String Str)
        {
            int cost = 0;

            foreach (char ch in Str)
                cost += DurabilityCost(ch);

            return cost;
        }


        private int DurabilityCost(Char Ch)
        {
            if (IsWhiteSpace(Ch))
                return 0;

            if ((Ch >= 'a') && (Ch <= 'z'))
                return 1;

            if ((Ch >= 'A') && (Ch <= 'Z'))
                return 2;

            throw new Exception("Cannot determine DurabilityCost of an invalid character with ASCII value " + (int)Ch);
        }


        private bool IsWhiteSpace(Char Ch)
        {
            return ((Ch == ' ') || (Ch == '\r') || (Ch == '\n'));
        }


        private bool IsWhiteSpace(String Str)
        {
            return ((Str == " ") || (Str == Environment.NewLine));
        }
    }
}
