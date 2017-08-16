using System;


namespace PillarPencil.Model
{
    public class Paper
    {
        public string _txt;


        public Paper()
        {
            _txt = "";
        }


        public string Text()
        {
            return _txt;
        }


        public void Append(string NewText)
        {
            if (NewText == null)
                return;             // Allowed, but do nothing.

            _txt += NewText;
        }


        public void Append(char NewChar)
        {
            _txt += NewChar;
        }


        public int FindFromEnd(string FindText)
        {
            return _txt.LastIndexOf(FindText);
        }


        public bool Replace(int Ndx, char Ch)
        {
            if (Ndx > _txt.Length - 1)
                return false;

            // This is likely not the fastest way. Maybe we need to switch to
            // using an array or a StringBuilder. We'll do some benchmarking later.
            char[] ary = _txt.ToCharArray();
            ary[Ndx] = Ch;
            _txt = new string(ary);

            return true;
        }
    }
}
