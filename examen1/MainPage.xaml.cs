using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examen1
{
    public partial class MainPage : ContentPage
    {
        public static List<Preguntas> listapreguntas = new List<Preguntas>
        {
            new Preguntas
            {
                Id = 1,
                Quest_ = "1. QUE ES XAMARIN",
                resp1_ = "es un framework de desarrollo web",
                resp2_ = "un lenguaje de programacion",
                resp3_ = "una plataforma para crear aplicaciones multiplataforma",
                resp4_ = "un emulador",
                Correcto = "una plataforma para crear aplicaciones multiplataforma",
            },
            new Preguntas
            {
                Id = 2,
                Quest_ = "2. CUAL DE LAS SIGUIENTES PLATAFORMAS ES COMPATIBLE CON XAMARIN",
                resp1_ = "android",
                resp2_ = "IOS",
                resp3_ = "windows",
                resp4_ = "todas las anteriores",
                Correcto = "todas las anteriores",
            },
            new Preguntas
            {
                Id = 3,
                Quest_ = "3. QUE LENGUAJES DE PROGRAMACION SE PUEDEN UTILIZAR CON XAMARIN",
                resp1_ = "solo C#",
                resp2_ = "solo F#",
                resp3_ = "C# y F#",
                resp4_ = "C#, F# y JAVA",
                Correcto = "C# y F#"
            },
            new Preguntas
            {
                Id = 4,
                Quest_ = "4. CUAL ES LA VENTAJA DE USAR XAMARIN PARA DESARROLLAR APLICACIONES",
                resp1_ = "mayor velocidad de desarrollo",
                resp2_ = "mayor control sobre el hardware del dispositivo",
                resp3_ = "desarrollo mas sencillo",
                resp4_ = "ahorro en los costos de desarrollo",
                Correcto = "ahorro en los costos de desarrollo"

            }
        };
        int point = 1, score = 0;
        string RespuestaCorrecta;
        public MainPage()
        {
            InitializeComponent();
        }

        protected void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private string SetPregunta(int ID)
        {
            Preguntas list = listapreguntas.Where(a => a.Id == ID).SingleOrDefault();
            try
            {
                lblpreguntita.Text = list.Quest_;
                btnresp1.Text = list.resp1_;
                btnresp2.Text = list.resp2_;
                btnresp3.Text = list.resp3_;
                btnresp4.Text = list.resp4_;
                RespuestaCorrecta = list.Correcto;
            }
            catch (Exception)
            {

            }

            return RespuestaCorrecta;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (btnresp1.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            if (btnresp2.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            if (btnresp3.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            if (btnresp4.Text == RespuestaCorrecta)
            {
                score++;
            }
            point++;
            SetPregunta(point);
            btnPuntuacion.IsVisible = true;

        }
        async void MostrarAlerta(object sender, EventArgs e)
        {
            await DisplayAlert("Puntuación", "Su Puntuación final es de: " + score + " / 4 puntos.", "OK");
        }
    }
}
