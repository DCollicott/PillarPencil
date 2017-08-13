using System;


namespace PillarPencil.Model
{
    public class Paper
    {
        public string Text { get; private set; }


        public Paper()
        {
            Text = "";
        }


        public void Append(string NewText)
        {
            Text += NewText;
        }
    }
}
