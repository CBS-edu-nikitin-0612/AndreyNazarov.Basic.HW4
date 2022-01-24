namespace Task5
{
    class Document
    {
        // Поля
        Title title = new Title();
        Body body = new Body();
        Footer footer = new Footer();

        public Document(string title, string body, string footer)
        {
            this.title.Content = title;
            this.body.Content = body;
            this.footer.Content = footer;
        }
        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }
    }
}
