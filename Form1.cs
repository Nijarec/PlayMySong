using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using System.Drawing;
using System.IO;

namespace PlayMySong
{
    public partial class Form1 : Form
    {
        //Variables
        // Variables para el sonido NAUDIO
      
private WaveOutEvent outputDevice;
    private AudioFileReader audioFile;
    private int indiceActual = 0;
    private List<string> playlist = new List<string>();

      



        public Form1()
        {
            InitializeComponent();
            // Configurar PictureBox
            pictureCover.SizeMode = PictureBoxSizeMode.Zoom;
            AjustarPictureBox();
            //Tamaño Minimo Form
            this.MinimumSize = new Size(500, 500);
            this.Text = "Play My Song 🎵";
            // Configurar FlowLayoutPanel (botones centrados)
            CentrarBotones();
         
           







            // Conectar eventos
            this.Resize += Form1_Resize;           // cuando cambie el tamaño de la ventana
            panelReproduccion.Resize += PanelReproduccion_Resize; // cuando cambie el tamaño del PanelControl
        }
        //Track Progress
        private void timerProgress_Tick(object sender, EventArgs e)
        {
            if (audioFile == null) return;

            var current = audioFile.CurrentTime;
            var total = audioFile.TotalTime;

            lblCurrentTime.Text = FormatearTiempo(current);

            if (total.TotalSeconds > 0)
            {
                trackProgress1.Value = (int)(
                    (current.TotalSeconds / total.TotalSeconds) * trackProgress1.Maximum
                );
            }
        }
        private string FormatearTiempo(TimeSpan tiempo)
        {
            return $"{(int)tiempo.TotalMinutes:D2}:{tiempo.Seconds:D2}";
        }
         private void trackProgress1_MouseUp(object sender, MouseEventArgs e)
         {
             if (audioFile == null) return;

             double porcentaje = (double)trackProgress1.Value / trackProgress1.Maximum;
             audioFile.CurrentTime = TimeSpan.FromSeconds(
                 audioFile.TotalTime.TotalSeconds * porcentaje
             );
         }




        private void ReproducirCancion(string ruta)
        {
            DetenerCancion();

            audioFile = new AudioFileReader(ruta);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.Play();
            audioFile.Volume = trackVolume.Value / 100f;
            CargarPortada(ruta);
            lblTotalTime.Text = FormatearTiempo(audioFile.TotalTime);
            timerProgress.Start();
            lblSongName.Text = Path.GetFileNameWithoutExtension(ruta);
            /*
            trackProgress1.Minimum = 0;
            trackProgress1.Maximum = (int)audioFile.TotalTime.TotalSeconds;
            */
            // **Actualizar etiqueta de canción**
            ActualizarNombreCancion(ruta);


        }
        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.Volume = trackVolume.Value / 100f;
                if (trackVolume.Value == 0) lblVolume.Text = "🔇";
                else if (trackVolume.Value < 50) lblVolume.Text = "🔉";
                else lblVolume.Text = "🔊";

            }
        }

        private void DetenerCancion()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0)
                return;

            indiceActual++;
            if (indiceActual >= playlist.Count)
                indiceActual = 0;

            ReproducirCancion(playlist[indiceActual]);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (playlist.Count == 0)
                return;

            indiceActual--;
            if (indiceActual < 0)
                indiceActual = playlist.Count - 1;

            ReproducirCancion(playlist[indiceActual]);
        }
       
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (outputDevice == null)
                return;

            if (outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                btnPlay.Text = "⏸";
            }
            else if (outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
                btnPlay.Text = "▶";
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar canciones";
                ofd.Filter = "Archivos de audio (*.mp3;*.wav)|*.mp3;*.wav";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    CargarCanciones(ofd.FileNames);
                   
                }
            }
            if (playlist.Count == 0)
                return;

            ReproducirCancion(playlist[indiceActual]);
        }
        private void CargarCanciones(string[] archivos)
        {
            playlist.Clear();
            playlist.AddRange(archivos);
            indiceActual = 0;

            // Aquí luego reproducirás la primera canción
            MessageBox.Show($"Se cargaron {playlist.Count} canciones");
            btnPlayList.Visible = true;
            lstPlaylist.Items.Clear();
            foreach (var ruta in playlist)
            {
                string nombre = Path.GetFileNameWithoutExtension(ruta);

                // Opcional: usar TagLib para título/artista
                try
                {
                    var file = TagLib.File.Create(ruta);
                    if (!string.IsNullOrEmpty(file.Tag.Title))
                        nombre = file.Tag.Title;
                    if (file.Tag.Performers.Length > 0)
                        nombre += " - " + string.Join(", ", file.Tag.Performers);
                }
                catch { }

                lstPlaylist.Items.Add(nombre);
            }




        }
        //Funciones para Listas de Reproduccion
        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            lstPlaylist.Visible = !lstPlaylist.Visible;
        }
        private void LstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            int index = lstPlaylist.SelectedIndex;
            if (index >= 0 && index < playlist.Count)
            {
                indiceActual = index;
                ReproducirCancion(playlist[indiceActual]);
                lstPlaylist.Visible = false; // opcional: cerrar lista al seleccionar
            }
        }





        private void Form1_Resize(object sender, EventArgs e)
        {
            AjustarPictureBox();
            CentrarBotones();
        }

        private void PanelReproduccion_Resize(object sender, EventArgs e)
        {
            CentrarBotones();
        }

        private void AjustarPictureBox()
        {
            // Ajusta PictureBox para que crezca pero sin salir del panel inferior
            int margen = 10;
            pictureCover.Width = this.ClientSize.Width - 2 * margen;
            pictureCover.Height = this.ClientSize.Height - panelReproduccion.Height - 2 * margen;
            pictureCover.Left = margen;
            pictureCover.Top = margen;
        }

        private void CentrarBotones()
        {
            // Centrar FlowLayoutPanel dentro del PanelControl
            flowLayoutPanel1.Left = (panelReproduccion.ClientSize.Width - flowLayoutPanel1.Width) / 2;
            flowLayoutPanel1.Top = (panelReproduccion.ClientSize.Height - flowLayoutPanel1.Height) / 2;
        }
        private void CargarPortada(string ruta)
        {
            try
            {
                var file = TagLib.File.Create(ruta);

                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = (byte[])file.Tag.Pictures[0].Data.Data;

                    using (var ms = new MemoryStream(bin))
                    {
                        pictureCover.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureCover.Image = Properties.Resources.cover_default;
                }
            }
            catch
            {
                pictureCover.Image = Properties.Resources.cover_default;
            }
        }
        
    
        private void ActualizarNombreCancion(string ruta)
        {
            // Obtener título
            string titulo = Path.GetFileNameWithoutExtension(ruta);

            // Opcional: artista con TagLib
            try
            {
                var file = TagLib.File.Create(ruta);
                if (!string.IsNullOrEmpty(file.Tag.Title))
                    titulo = file.Tag.Title;

                if (file.Tag.Performers.Length > 0)
                    titulo += " - " + string.Join(", ", file.Tag.Performers);
            }
            catch { }

            // Asignar texto
            lblSongName.Text = titulo;

            // Ajustar posición para que crezca a la izquierda
            lblSongName.Left = PanelOpciones.Width - lblSongName.Width - 10;
            lblSongName.Top = (PanelOpciones.Height - lblSongName.Height) / 2; // centrar vertical
        }
        private void panelTop_Resize(object sender, EventArgs e)
        {
            lblSongName.Left = PanelOpciones.Width - lblSongName.Width - 10;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

   
    }
}
