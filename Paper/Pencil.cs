using System;


namespace PillarPencil.Model
{
    public class Pencil
    {
        public Pencil()
        {
        }


        public void Write(Paper Ppr, string NewText)
        {
            Ppr.Append(NewText);
        }
    }
}
