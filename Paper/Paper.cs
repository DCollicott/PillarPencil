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
    }
}
