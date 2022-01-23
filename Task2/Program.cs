using System;

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
    abstract internal class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }

    internal class XMLHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge XML");
        }

        public override void Create()
        {
            Console.WriteLine("Create XML");
        }

        public override void Open()
        {
            Console.WriteLine("Open XML");
        }

        public override void Save()
        {
            Console.WriteLine("Save XML");
        }
    }
    internal class TXTHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge TXT");
        }

        public override void Create()
        {
            Console.WriteLine("Create TXT");
        }

        public override void Open()
        {
            Console.WriteLine("Open TXT");
        }

        public override void Save()
        {
            Console.WriteLine("Save TXT");
        }
    }
    internal class DOCHandler : AbstractHandler
    {
        public override void Chenge()
        {
            Console.WriteLine("Chenge DOC");
        }

        public override void Create()
        {
            Console.WriteLine("Create DOC");
        }

        public override void Open()
        {
            Console.WriteLine("Open DOC");
        }

        public override void Save()
        {
            Console.WriteLine("Save DOC");
        }
    }
}
