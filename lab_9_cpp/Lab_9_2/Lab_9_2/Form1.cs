using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Lab_9_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Movie
        {
            public string Title { get; set; }
            public int Year { get; set; }

            public Movie(string t, int y)
            {
                Title = t;
                Year = y;
            }

            public override string ToString()
            {
                return $"{Title} ({Year})";
            }
        }

        class MovieLibrary
        {
            private Movie[] movies;
            public int Length { get; private set; }
            public int ErrorCode { get; private set; }

            public MovieLibrary(int size)
            {
                movies = new Movie[size];
                Length = size;
            }

            public Movie this[int index]
            {
                get
                {
                    if (index < 0 || index >= Length)
                    {
                        ErrorCode = 1;
                        return null;
                    }

                    ErrorCode = 0;
                    return movies[index];
                }
                set
                {
                    if (index < 0 || index >= Length)
                    {
                        ErrorCode = 1;
                        return;
                    }

                    movies[index] = value;
                    ErrorCode = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieLibrary lib = new MovieLibrary(4);

            lib[0] = new Movie("Interstellar", 2014);
            lib[1] = new Movie("Inception", 2010);
            lib[2] = new Movie("John Wick", 2014);
            lib[3] = new Movie("Mad Max: Fury Road", 2015);

            string s = "";

            for (int i = 0; i < lib.Length; i++)
                s += lib[i].ToString() + "\n";

            label1.Text = s;
        }
    }
}
