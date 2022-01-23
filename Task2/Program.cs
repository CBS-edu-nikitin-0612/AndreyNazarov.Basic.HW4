namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = new XMLHandler();
            var txt = new TXTHandler();
            var doc = new DOCHandler();

            xml.Chenge();
            xml.Create();
            xml.Open();
            xml.Save();

            txt.Chenge();
            txt.Create();
            txt.Open();
            txt.Save();

            doc.Chenge();
            doc.Create();
            doc.Open();
            doc.Save();
        }
    }
}
