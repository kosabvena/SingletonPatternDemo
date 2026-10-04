namespace SingletonPatternDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Logger.Instance.Log(txtMessage.Text);
            MessageBox.Show(
                $"Сообщение добавлено.\nВсего вызовов через Logger.Instance: {Logger.Instance.CallCount}",
                "Singleton");
        }

        private void btnCreateSecond_Click(object sender, EventArgs e)
        {
            var first = Logger.Instance;
            var second = Logger.Instance;
            bool sameObject = ReferenceEquals(first, second);

            MessageBox.Show(
                $"first  hash = {first.GetHashCode()}\n" +
                $"second hash = {second.GetHashCode()}\n\n" +
                $"Это один и тот же объект: {sameObject}",
                "Проверка Singleton");
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            txtLog.Text = Logger.Instance.GetLog();
        }
    }
}
