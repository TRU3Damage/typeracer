using System;
using System.Net.Mime;
using System.Threading;
using System.Windows;

namespace chad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public class Quote
        {
            public string Text { get; set; }
            public int Words { get; set; }

            public Quote(string text, int words)
            {
                Text = text;
                Words = words;
            }
        }

        private Quote quote1 = new Quote("My name is jeff.", 4);
        private float wps;
        private float wpm;
        private float time;
        private bool sessionToken = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void session()
        {
            Thread sn = new Thread(session) { IsBackground = true };
            sn.Start();
            while (true)
            {
                Thread.Sleep(10);
                if (sessionToken == true)
                {
                    time = (float)(time + 0.01);
                    if (quote1.Text.Equals(Textbox1.Text))
                    {
                        Textbox1.Text = string.Empty;
                        sessionToken = false;
                        wps = quote1.Words / time;
                        wpm = wps * 60;
                        MessageBox.Show("Done!, words per minute - " + wpm.ToString() + " !");
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (sessionToken == false)
            {
                
            }
        }
    }
}